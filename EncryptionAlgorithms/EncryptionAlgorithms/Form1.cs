using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using EncryptionAlgorithms.RSA;

namespace EncryptionAlgorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText(@"C:/Users/becario/Pictures/Documentos/Criptografia y seguridad/Archivo de texto encriptado.txt");
            //string text = "ZDA3dzNpMnJTVG0yQ3FQS25RUFBIV0tLWjVrNHlqQi9oM3hTVFFRdWxsbnRMcU1tQzdGb2E5RW82a0FRSTJxODVpYWp5Nkhzc2hGWXBRcVNVN0FIWnRhU24wVnBxL1F2cE5lZXBxdm9qYm52YnFndnRqVEJnSzU5bzNjeHJRU2ptTVFYanYwYWlmektaSmhnZ3R1MTNKMlBrZlBKVzJzUzVUQzNBT3NVUlJ3PQ==";
            listBoxInput.Items.Add(text);

            dataTreatment.loadData();

            
            try 
            {
                byte[] dataEncrypted = Encoding.UTF8.GetBytes(text);
                CspParameters csp = new CspParameters();    
                RSAParameters rsaP = new RSAParameters();

                 rsaP.Modulus = Convert.FromBase64String(dataTreatment.getKeyByName("Modulus"));
                 rsaP.Exponent = Convert.FromBase64String(dataTreatment.getKeyByName("Exponent"));
                 rsaP.P = Convert.FromBase64String(dataTreatment.getKeyByName("P"));
                 rsaP.Q = Convert.FromBase64String(dataTreatment.getKeyByName("Q"));
                 rsaP.DP = Convert.FromBase64String(dataTreatment.getKeyByName("DP"));
                 rsaP.DQ = Convert.FromBase64String(dataTreatment.getKeyByName("DQ"));
                 rsaP.InverseQ = Convert.FromBase64String(dataTreatment.getKeyByName("InverseQ"));
                 rsaP.D = Convert.FromBase64String(dataTreatment.getKeyByName("D"));
                /** rsaP.Modulus = Convert.FromBase64String("t3wHJ20FIxJLF862VXhdJVKJBrNuPHYzNgVEoplwaqZCXg85Y1UBcWsLFo2z2Kw2+inuFQq7i0nWPc5HdbsarJO4QMl6+p8QO4vggvRe/LyOLu2F9woSy22jcCywN7UM8cX5aKcVy5eKYjRXtCarda1gQAp4+JH/y3KsQYwOkP0=");
                 rsaP.Exponent = Convert.FromBase64String("AQAB");
                 rsaP.P = Convert.FromBase64String("7JpuVJ4+3ZH4L8Q4DywYw4R7MphshRx39Nkb1dI3y9lGmDWtC4DY9MsuE5FeUNbyM1hizusubCtTECv6PV3Q2w==");
                 rsaP.Q = Convert.FromBase64String("xobMenFpgAaWP9eZsHPm4g7tMDe66hg9gLEpB1ClsYt7WNyjsjAqjNAcyOrOEmDct2cr+nz51Wu5YPkWRxcBBw==");
                 rsaP.DP = Convert.FromBase64String("Vr8YDHYoXlwSPpEWbJmiSqzb7mTsBLG3WVHwXqjAREDZHR0w4LLQ2I9VyV7W0ZS9IA4by/l1/7qyrY8yJCWtWQ==");
                 rsaP.DQ = Convert.FromBase64String("p3PmH9VvppRnwXvq38IzWjQ67rPjTjeaEOXd9JSa3jIHncGltdQY3+NelD4yCaB4K56zorotxU3y9I/Fsbr+mw==");
                 rsaP.InverseQ = Convert.FromBase64String("ssbEa+0/f0XuO19mhcuO0U+tTYwjR9tFNBL2rjXlVkQsv8jnqAY22oZwwEK6vgqd+qaDTFtbc5qxIwqGKaqvqA==");
                 rsaP.D = Convert.FromBase64String("qEYPKZFKTMfSJptljS09/6SaFpMoXjro7HoYYCboembQJwM/VmH3WNUa7iw27FfEc9lQh+u35B5rZXNxBf/6jQw8dTccheuUniZ2uS3ump4gj0VXSHZ3hx5pttbWhA7XKEbRSZS64OV8yKPCqdgOkLmeNfG+Qc38wm/cVJLr5eE=");**/

                

                byte[] encryptedData  = System.Text.UTF8Encoding.UTF8.GetBytes(text);
                 
                RSADecrypt(encryptedData, rsaP, false);

                //labelText.Text = encryptedData.Length.ToString();

            } catch (Exception E) { labelText.Text = E.Message; }

        }

        private void listBoxInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labeText_Click(object sender, EventArgs e)
        {

        }
        public void RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                CspParameters csp = new CspParameters(1, "Schlumberger Cryptographic Service Provider");
                csp.Flags = CspProviderFlags.UseArchivableKey;
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

                    //labelText.Text = decryptedData;
                }
                
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                 labelText.Text = e.Message;

            }
        }
    }
}

