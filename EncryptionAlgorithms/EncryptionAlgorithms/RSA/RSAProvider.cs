using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAlgorithms.RSA
{
    public class RSAProvider
    {
        public RSACryptoServiceProvider RSAService { get; set; }

        public RSAProvider()
        {
            this.RSAService = new RSACryptoServiceProvider();
        }

        public byte[] CreatePublicKey()
        {
            string xmlPublicKey = this.RSAService.ToXmlString(false);
            return Encoding.ASCII.GetBytes(xmlPublicKey);
        }

        public byte[] CreatePrivateKey() 
        {
            string xmlPrivateKey = this.RSAService.ToXmlString(true);
            return Encoding.ASCII.GetBytes(xmlPrivateKey);
        }
        public static byte[] DecryptText(string encryptedText, string xmlPrivate)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024);
            RSA.FromXmlString(xmlPrivate);
            byte[] decryptData = RSA.Decrypt(Convert.FromBase64String(encryptedText), false);
            return decryptData;
        }
    }
}
