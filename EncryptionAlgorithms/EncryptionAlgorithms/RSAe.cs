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
        
        string text;
        string xmlPublic;
        byte[] PublicKey;
        byte[] PrivateKeyTo;
        public RSAe(string text, string xmlPublic)
        {
            this.text = text;   
            this.xmlPublic = xmlPublic;
        }

        public string Encrypt()
        {
            try
            {
                //Create a UnicodeEncoder to convert between byte array and string.
                UnicodeEncoding ByteConverter = new UnicodeEncoding();

                byte[] dataToEncrypt = Encoding.UTF8.GetBytes(text);
                byte[] encryptedData;
                byte[] decryptedData;

                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    
                    encryptedData = RSAEncrypt(dataToEncrypt, xmlPublic, false);
                    return Convert.ToBase64String(DecodeTextByte(encryptedData));
                }
            }
            catch (ArgumentNullException)
            {
                return "Error tu en la encriptación";
            }


            
        }
        public static byte[] RSAEncrypt(byte[] DataToEncrypt, string xmlPublic, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    
                    RSA.FromXmlString(xmlPublic);
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
        private static byte[] DecodeTextByte(byte[] encodedData)
        {
            return Encoding.UTF8.GetBytes(Convert.ToBase64String(encodedData));
        }
        private static string DecodeTextString(string encodedData)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(encodedData));
        }

    }
}
