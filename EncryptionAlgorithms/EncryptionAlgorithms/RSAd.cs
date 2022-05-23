using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EncryptionAlgorithms
{
    internal class RSAd
    {
        XDocument xml = new XDocument();
        String texto;
        public RSAd(XDocument xml, String texto) {
            this.xml = xml;
            this.texto = texto;
        }

        public string decrypt() {

            try
            {

                byte[] decryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048))
                {
                    //Import the RSA Key information. This needs
                    //to include the private key information.
                    RSA.ImportParameters(getParameters());

                    //Decrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    decryptedData = RSA.Decrypt(Convert.FromBase64String(DecodeText(texto)), false);

                    return Encoding.Default.GetString(decryptedData);
                }

            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                return "Error en la desencriptación";

            }

            
        
        }
        public string getKeyByName(XDocument xml, string nameKey)
        {
            try
            {
                
               List<string> ids = xml.Descendants(nameKey).Select(e => e.Value).ToList();
               foreach (string id in ids)
               {
                  return id;
               }

            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
            return "";
        }
        public RSAParameters getParameters() {

            RSAParameters rsaP = new RSAParameters();
            rsaP.Modulus = Convert.FromBase64String(getKeyByName(xml, "Modulus"));
            rsaP.Exponent = Convert.FromBase64String(getKeyByName(xml, "Exponent"));
            rsaP.P = Convert.FromBase64String(getKeyByName(xml, "P"));
            rsaP.Q = Convert.FromBase64String(getKeyByName(xml, "Q"));
            rsaP.DP = Convert.FromBase64String(getKeyByName(xml, "DP"));
            rsaP.DQ = Convert.FromBase64String(getKeyByName(xml, "DQ"));
            rsaP.InverseQ = Convert.FromBase64String(getKeyByName(xml, "InverseQ"));
            rsaP.D = Convert.FromBase64String(getKeyByName(xml, "D"));

            return rsaP;
        }
        private static string DecodeText(string encodedData)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(encodedData));
        }
    }
}
