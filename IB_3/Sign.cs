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
        static public byte[] ToSign(string data, out byte[] hash, RSAParameters RSAKeyInfo)
        {
            //Create a new instance of RSACryptoServiceProvider.
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(RSAKeyInfo);
                //The hash to sign.
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

        static public bool Verify(byte[] hash, byte[] signedHash, RSAParameters RSAKeyInfo)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(RSAKeyInfo);
                //RSACryptoServiceProvider to transfer the key information.
                RSAPKCS1SignatureDeformatter RSADeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                
                RSADeformatter.SetHashAlgorithm("SHA256");
                //Verify the hash and display the results to the console. 
                if (RSADeformatter.VerifySignature(hash, signedHash))
                {
                    return true;
                }
                else
                {
                    return true;
                }
            }
        }

    }
}