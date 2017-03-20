using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IB_3
{
    class Sign
    {
        static public byte[] ToSign(string data, RSAParameters RSAKeyInfo)
        {
            //Create a new instance of RSACryptoServiceProvider.
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(RSAKeyInfo);
                //The hash to sign.
                byte[] hash;
                using (SHA256 sha256 = SHA256.Create())
                {
                    hash = sha256.ComputeHash(Encoding.ASCII.GetBytes(data));
                }

                //Create an RSASignatureFormatter object and pass it the 
                //RSACryptoServiceProvider to transfer the key information.
                RSAPKCS1SignatureFormatter RSAFormatter = new RSAPKCS1SignatureFormatter(rsa);

                //Set the hash algorithm to SHA256.
                RSAFormatter.SetHashAlgorithm("SHA256");

                //Create a signature for HashValue and return it.
                return RSAFormatter.CreateSignature(hash);
            }

        }

        static public bool Verify(string data, byte[] signedData, RSAParameters RSAKeyInfo)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(RSAKeyInfo);
                //RSACryptoServiceProvider to transfer the key information.
                RSAPKCS1SignatureDeformatter RSADeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                byte[] hash;
                using (SHA256 sha256 = SHA256.Create())
                {
                    hash = sha256.ComputeHash(Encoding.ASCII.GetBytes(data));
                }
                RSADeformatter.SetHashAlgorithm("SHA256");
                //Verify the hash and display the results to the console. 
                return (RSADeformatter.VerifySignature(hash, signedData));
            }
        }

    }
}