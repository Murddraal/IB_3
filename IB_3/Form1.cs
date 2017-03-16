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
        string key_file = "";
        string iv_file = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hashing_Click(object sender, EventArgs e)
        {
            var alg_name = cmbbx_hash_algs.Text;
            if (alg_name.Length == 0)
                return;
            var hash = Hash.encrypt(alg_name, txtbx_msg.Text);

            txtbx_hash.Text = String.Concat(hash.Select(i => Convert.ToString(i, 16)));


        }

        private void btn_gen_key_Click(object sender, EventArgs e)
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

        private void btn_gen_iv_Click(object sender, EventArgs e)
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

        private void btn_read_key_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                key_file = openFileDialog1.FileName;
                MessageBox.Show("Ключ введен");
            }
        }

        private void btn_read_iv_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                iv_file = openFileDialog1.FileName;
                MessageBox.Show("Вектор введен");
            }
        }

        private void btn_sym_data_encr_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var mess = File.ReadAllText(openFileDialog1.FileName);
                byte[] key;
                byte[] iv;

                using (FileStream fs = new FileStream(key_file, FileMode.Open))
                {
                    key = new byte[fs.Length];
                    fs.Read(key, 0, (int)fs.Length);
                }
                using (FileStream fs = new FileStream(iv_file, FileMode.Open))
                {
                    iv = new byte[fs.Length];
                    fs.Read(iv, 0, (int)fs.Length);
                }

                var crypt_mess_sym = SymKeyAlgs.THREEDES.Encrypt(mess, key, iv);
                txtbx_sym_encr.Text = String.Concat(crypt_mess_sym.Select(i => i.ToString() + " "));

                File.WriteAllBytes("EncrData", crypt_mess_sym);
            }
        }

        private void btn_sym_data_decr_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var mess = File.ReadAllBytes(openFileDialog1.FileName);
                byte[] key;
                byte[] iv;

                using (FileStream fs = new FileStream(key_file, FileMode.Open))
                {
                    key = new byte[fs.Length];
                    fs.Read(key, 0, (int)fs.Length);
                }
                using (FileStream fs = new FileStream(iv_file, FileMode.Open))
                {
                    iv = new byte[fs.Length];
                    fs.Read(iv, 0, (int)fs.Length);
                }

                var crypt_mess_sym = SymKeyAlgs.THREEDES.Decrypt(mess, key, iv);
                txtbx_sym_decr.Text = crypt_mess_sym;//String.Concat(crypt_mess_sym.Select(i => i.ToString() + " "));

                File.WriteAllText("DecrData.txt", txtbx_sym_decr.Text);
            }
        }

        RSACryptoServiceProvider RSA_sign = new RSACryptoServiceProvider();
        RSACryptoServiceProvider RSA_assym = new RSACryptoServiceProvider();
        RSAParameters key_public_assym, key_private_assym;
        int k = 0;

        private void btn_asym_data_encr_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Create a UnicodeEncoder to convert between byte array and string.
                UnicodeEncoding ByteConverter = new UnicodeEncoding();

                //Create byte arrays to hold original, encrypted, and decrypted data.
                var dataToEncrypt = File.ReadAllBytes(openFileDialog1.FileName);
                //byte[] dataToEncrypt = ByteConverter.GetBytes("Data to Encrypt");
                byte[] encryptedData;

                //Create a new instance of RSACryptoServiceProvider to generate
                //public and private key data.
                encryptedData = AsymKeyAlgs.RSA.RSAEncrypt(dataToEncrypt, key_public_assym, false);

                txtbx_asym_encr.Text = String.Concat(encryptedData.Select(i => i.ToString() + " "));

                File.WriteAllBytes("EncrAsymData", encryptedData);
            }

        }

        private void btn_asym_data_decr_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Create a UnicodeEncoder to convert between byte array and string.
                UnicodeEncoding ByteConverter = new UnicodeEncoding();

                //Create byte arrays to hold original, encrypted, and decrypted data.
                var dataToDecrypt = File.ReadAllBytes(openFileDialog1.FileName);
                byte[] decryptedData;

                //Create a new instance of RSACryptoServiceProvider to generate
                //public and private key data.
                decryptedData = AsymKeyAlgs.RSA.RSADecrypt(dataToDecrypt, key_private_assym, false);

                //Display the decrypted plaintext to the console. 
                txtbx_asym_decr.Text = System.Text.Encoding.UTF8.GetString(decryptedData);//String.Concat(decryptedData.Select(i => i.ToString() + " "));

                File.WriteAllText("DencrAsymData.txt", txtbx_asym_decr.Text);
            }
        }

        private void btn_gen_rsa_publ_key_Click(object sender, EventArgs e)
        {
            if (k == 2)
            {
                RSA_assym = new RSACryptoServiceProvider();
                k = 0;
            }
            ++k;
            RSA_assym.ExportParameters(true);
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                File.WriteAllText(saveFileDialog1.FileName, RSA_assym.ToXmlString(false));
            }
        }

        private void btn_gen_rsa_priv_key_Click(object sender, EventArgs e)
        {
            if (k == 2)
            {
                RSA_assym = new RSACryptoServiceProvider();
                k = 0;
            }
            ++k;

            RSA_assym.ExportParameters(true);
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                File.WriteAllText(saveFileDialog1.FileName, RSA_assym.ToXmlString(true));
            }
        }

        private void btn_read_rsa_publ_key_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RSA_assym.FromXmlString(File.ReadAllText(openFileDialog1.FileName));
                key_public_assym = RSA_assym.ExportParameters(false);
                MessageBox.Show("Открытый ключ введен");

            }
        }

        private void btn_read_rsa_priv_key_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RSA_assym.FromXmlString(File.ReadAllText(openFileDialog1.FileName));
                key_private_assym = RSA_assym.ExportParameters(true);
                MessageBox.Show("Закрытый ключ введен");

            }
        }

    }
}