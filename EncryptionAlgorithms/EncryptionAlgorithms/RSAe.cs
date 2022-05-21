using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAlgorithms
{
    internal class RSAe
    {
        String text;
        byte[] PublicKey;
        byte[] PrivateKeyTo;
        public RSAe(string text)
        {
            this.text = text;   
        }

        public string Encrypt()
        {
            try
            {
                //Create a UnicodeEncoder to convert between byte array and string.
                UnicodeEncoding ByteConverter = new UnicodeEncoding();

                byte[] dataToEncrypt = ByteConverter.GetBytes(text);
                byte[] encryptedData;
                byte[] decryptedData;

                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    encryptedData = RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false);
                    PublicKey = RSA.ExportRSAPublicKey();
                    PrivateKeyTo = RSA.ExportRSAPrivateKey();
                    return Convert.ToBase64String(encryptedData);
                }
            }
            catch (ArgumentNullException)
            {
                return "Error tu en la encriptación";
            }


            
        }
        public static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
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
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
        }
        public string getPublicKey() {
            return Convert.ToBase64String(PublicKey);
        }
        public string getPrivateKey()
        {
            return Convert.ToBase64String(PrivateKeyTo);
        }
    }
}
