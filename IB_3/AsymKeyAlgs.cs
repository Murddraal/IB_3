﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace IB_3
{
    static class AsymKeyAlgs
    {
        static public class RSA
        {
            static public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
            {
                byte[] encryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    //Import the RSA Key information. This only needs
                    //toinclude the public key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Encrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }

            static public byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
            {
                    byte[] decryptedData;
                    //Create a new instance of RSACryptoServiceProvider.
                    using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                    {
                        //Import the RSA Key information. This needs
                        //to include the private key information.
                        RSA.ImportParameters(RSAKeyInfo);

                        //Decrypt the passed byte array and specify OAEP padding.  
                        //OAEP padding is only available on Microsoft Windows XP or
                        //later.  
                        decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                    }
                    return decryptedData;
            }
        }
    }
}
