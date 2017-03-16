using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace IB_3
{
    static class SymKeyAlgs
    {
        static public class THREEDES
        {
            static public byte[] GenerateKey()
            {
                var alg = new TripleDESCryptoServiceProvider();

                return alg.Key;
            }

            static public byte[] GenerateIV()
            {
                var alg = new TripleDESCryptoServiceProvider();

                return alg.IV;
            }

            static public byte[] Encrypt(string data, byte[] Key, byte[] IV)
            {

                byte[] encrypted;
                var tdsAlg = new TripleDESCryptoServiceProvider();
                tdsAlg.Key = Key;
                tdsAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = tdsAlg.CreateEncryptor(tdsAlg.Key, tdsAlg.IV);

                // Create the streams used for encryption.
                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {

                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(data);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
                 return encrypted;
            }

            static public string Decrypt(byte[] Data, byte[] Key, byte[] IV)
            {
                // Create a new MemoryStream using the passed 
                // array of encrypted data.
                MemoryStream msDecrypt = new MemoryStream(Data);

                var des = new TripleDESCryptoServiceProvider();
                des.Padding = PaddingMode.None;

                // Create a CryptoStream using the MemoryStream 
                // and the passed key and initialization vector (IV).
                CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                    des.CreateDecryptor(Key, IV),
                    CryptoStreamMode.Read);


                // Create buffer to hold the decrypted data.
                byte[] fromEncrypt = new byte[Data.Length];

                // Read the decrypted data out of the crypto stream
                // and place it into the temporary buffer.
                csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);

                //Convert the buffer into a string and return it.
                return System.Text.Encoding.UTF8.GetString(fromEncrypt);//new ASCIIEncoding().GetString(fromEncrypt).TrimEnd('\0');
            }
        }
    }
}
