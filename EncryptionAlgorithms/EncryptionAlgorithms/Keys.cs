using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAlgorithms
{
    internal class Keys
    {
        public RSACryptoServiceProvider RSAService { get; set; }
        
        public Keys()
        {
            this.RSAService = new RSACryptoServiceProvider();   
        }
        public void createKeys() {
            try
            {
                FolderBrowserDialog browserDialog = new FolderBrowserDialog();

                if (browserDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderName = browserDialog.SelectedPath;

                    FileStream fileStream = new FileStream(Path.Combine(folderName, "PublicKey.xml"), FileMode.Create, FileAccess.Write);
                    byte[] publicBytes = Encoding.ASCII.GetBytes(RSAService.ToXmlString(false));
                    fileStream.Write(publicBytes, 0, publicBytes.Length);
                    fileStream.Close();

                    fileStream = new FileStream(Path.Combine(folderName, "PrivateKey.xml"), FileMode.Create, FileAccess.Write);
                    byte[] privateBytes = Encoding.ASCII.GetBytes(RSAService.ToXmlString(true));
                    fileStream.Write(privateBytes, 0, privateBytes.Length);
                    fileStream.Close();
                }
            }
            catch (Exception) { 
                
            }
            
        }
    }
}
