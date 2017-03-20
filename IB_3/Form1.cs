using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte[] key_sym = new byte[0];
        byte[] iv_sym = new byte[0];
        string DataToEncryptSym = "";
        byte[] DataToDecryptSym = new byte[0];

        private void btn_hashing_Click(object sender, EventArgs e)
        {
            var alg_name = cmbbx_hash_algs.Text;
            if (alg_name.Length == 0)
                return;
            var hash = Hash.encrypt(alg_name, txtbx_msg.Text);

            txtbx_hash.Text = String.Concat(hash.Select(i => Convert.ToString(i, 16)));


        }
        private void btn_sym_data_encr_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataToEncryptSym = File.ReadAllText(openFileDialog1.FileName);
            }
        }
        private void btn_sym_data_decr_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataToDecryptSym = File.ReadAllBytes(openFileDialog1.FileName);
                MessageBox.Show("Файл для дешифровки введён!");
            }
        }
        private void btn_sym_data_encr_Click_1(object sender, EventArgs e)
        {
            try
            {
                var crypt_mess_sym = SymKeyAlgs.THREEDES.Encrypt(DataToEncryptSym, key_sym, iv_sym);
                txtbx_sym_encr.Text = String.Concat(crypt_mess_sym.Select(i => i.ToString() + " "));

                File.WriteAllBytes("EncrData", crypt_mess_sym);
            }
            catch (CryptographicException)
            {
                if (key_sym.Length == 0)
                    MessageBox.Show("Введите ключ!");
                if (iv_sym.Length == 0)
                    MessageBox.Show("Введите вектор!");
            }
        }
        private void btn_sym_gen_key_Click(object sender, EventArgs e)
        {
            var key = SymKeyAlgs.THREEDES.GenerateKey();

            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                {
                    fs.Write(key, 0, key.Length);
                }
            }
        }
        private void btn_sym_gen_iv_Click(object sender, EventArgs e)
        {
            var iv = SymKeyAlgs.THREEDES.GenerateIV();

            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                {
                    fs.Write(iv, 0, iv.Length);
                }
            }
        }
        private void btn_sym_read_key_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //key_sym = openFileDialog1.FileName;
                key_sym = File.ReadAllBytes(openFileDialog1.FileName);
                MessageBox.Show("Ключ введен");
            }
        }
        private void btn_sym_read_iv_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //iv_sym = openFileDialog1.FileName;
                iv_sym = File.ReadAllBytes(openFileDialog1.FileName);
                MessageBox.Show("Вектор введен");
            }
        }
        private void btn_sym_data_decr_Click_1(object sender, EventArgs e)
        {
            try
            {
                var crypt_mess_sym = SymKeyAlgs.THREEDES.Decrypt(DataToDecryptSym, key_sym, iv_sym);
                txtbx_sym_decr.Text = crypt_mess_sym;//String.Concat(crypt_mess_sym.Select(i => i.ToString() + " "));

                File.WriteAllText("DecrData.txt", txtbx_sym_decr.Text);
            }
            catch
            {
                if (key_sym.Length == 0)
                    MessageBox.Show("Введите ключ!");
                if (iv_sym.Length == 0)
                    MessageBox.Show("Введите вектор!");
                if (DataToDecryptSym.Length == 0)
                    MessageBox.Show("Введите данные!");

            }
        }

        RSACryptoServiceProvider RSA_assym = new RSACryptoServiceProvider();
        RSAParameters key_public_assym, key_private_assym;
        byte[] dataToDecrypt = new byte[0];
        byte[] dataToEncrypt = new byte[0];

        private void btn_asym_data_encr_Click(object sender, EventArgs e)
        {
            try
            {
                //Create a UnicodeEncoder to convert between byte array and string.
                UnicodeEncoding ByteConverter = new UnicodeEncoding();

                byte[] encryptedData;

                //Create a new instance of RSACryptoServiceProvider to generate
                //public and private key data.
                encryptedData = AsymKeyAlgs.RSA.RSAEncrypt(dataToEncrypt, key_public_assym, false);

                txtbx_asym_encr.Text = String.Concat(encryptedData.Select(i => i.ToString() + " "));

                File.WriteAllBytes("EncrAsymData", encryptedData);
            }
            catch (CryptographicException)
            {
                MessageBox.Show("Открытый ключ не введен!");
            }
        }
        private void btn_asym_data_decr_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Create byte arrays to hold original, encrypted, and decrypted data.
                dataToDecrypt = File.ReadAllBytes(openFileDialog1.FileName);
                MessageBox.Show("Данные для расшифровки введены!");
            }
        }
        private void btn_gen_rsa_keys_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save private key";
            RSA_assym.ExportParameters(true);
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                File.WriteAllText(saveFileDialog1.FileName, RSA_assym.ToXmlString(true));
            }

            saveFileDialog1.Title = "Save public key";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                File.WriteAllText(saveFileDialog1.FileName, RSA_assym.ToXmlString(false));
            }
        }
        private void btn_read_rsa_publ_key_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    RSA_assym.FromXmlString(File.ReadAllText(openFileDialog1.FileName));
                    key_public_assym = RSA_assym.ExportParameters(false);
                    MessageBox.Show("Открытый ключ введен");
                }
            }
            catch
            {
                MessageBox.Show("Неверные данные!");
            }
        }
        private void btn_read_rsa_priv_key_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    RSA_assym.FromXmlString(File.ReadAllText(openFileDialog1.FileName));
                    key_private_assym = RSA_assym.ExportParameters(true);
                    MessageBox.Show("Закрытый ключ введен");
                }
            }
            catch
            {
                MessageBox.Show("Неверные данные!");
            }
        }
        private void btn_rsa_data_decr_Click(object sender, EventArgs e)
        {
            try
            {
                //Create a UnicodeEncoder to convert between byte array and string.
                UnicodeEncoding ByteConverter = new UnicodeEncoding();

                //Create byte arrays to hold original, encrypted, and decrypted data.
                byte[] decryptedData;

                //Create a new instance of RSACryptoServiceProvider to generate
                //public and private key data.
                decryptedData = AsymKeyAlgs.RSA.RSADecrypt(dataToDecrypt, key_private_assym, false);

                //Display the decrypted plaintext to the console. 
                txtbx_asym_decr.Text = System.Text.Encoding.UTF8.GetString(decryptedData);//String.Concat(decryptedData.Select(i => i.ToString() + " "));

                File.WriteAllText("DencrAsymData.txt", txtbx_asym_decr.Text);
            }
            catch (CryptographicException)
            {
                if(dataToEncrypt.Length == 0)
                    MessageBox.Show("Введите данные для расшифровки!");

                MessageBox.Show("Введите закрытый ключ!");
            }
        }
        private void btn_asym_read_data_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dataToEncrypt = File.ReadAllBytes(openFileDialog1.FileName);
                MessageBox.Show("Данные для шифрования введены!");
            }
        }

        RSACryptoServiceProvider RSA_sign = new RSACryptoServiceProvider();
        RSAParameters key_public_sign, key_private_sign;
        string dataToSign = "";
        byte[] sign = new byte[0];

        private void btn_cds_read_private_key_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    RSA_sign.FromXmlString(File.ReadAllText(openFileDialog1.FileName));
                    key_private_sign = RSA_sign.ExportParameters(true);
                    MessageBox.Show("Закрытый ключ введен");
                }
            }
            catch
            {
                MessageBox.Show("Неверные данные!");
            }
        }
        private void btn_cds_read_open_key_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    RSA_sign.FromXmlString(File.ReadAllText(openFileDialog1.FileName));
                    key_public_sign = RSA_sign.ExportParameters(false);
                    MessageBox.Show("Открытый ключ введен");
                }
            }
            catch
            {
                MessageBox.Show("Неверные данные!");
            }
        }
        private void btn_cds_read_data_to_sign_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dataToSign = File.ReadAllText(openFileDialog1.FileName);
                MessageBox.Show("Данные введены!");
            }
        }

        private void btn_cds_read_sign_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    sign = File.ReadAllBytes(openFileDialog1.FileName);
                    MessageBox.Show("Подпись введена");
                }
            }
            catch
            {
                MessageBox.Show("Неверные данные!");
            }
        }

        private void btn_cds_verify_data_Click(object sender, EventArgs e)
        {
            try
            {
                var verify = Sign.Verify(dataToSign, sign, key_public_sign);
                MessageBox.Show("Результат проверки: " + verify.ToString());
            }
            catch
            {
                if (sign.Length == 0)
                    MessageBox.Show("Введте подпись!");
                MessageBox.Show("Введите ключ!");
            }
        }

        private void btn_cds_sign_data_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Title = "Подпись";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    File.WriteAllBytes(saveFileDialog1.FileName, Sign.ToSign(dataToSign, key_private_sign));
                }
            }
            catch
            {
                MessageBox.Show("Ключ не введён!");
            }
        }
        private void btn_cds_gen_keys_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save private key";
            RSA_assym.ExportParameters(true);
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                File.WriteAllText(saveFileDialog1.FileName, RSA_sign.ToXmlString(true));
            }

            saveFileDialog1.Title = "Save public key";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                File.WriteAllText(saveFileDialog1.FileName, RSA_sign.ToXmlString(false));
            }
        }



    }
}