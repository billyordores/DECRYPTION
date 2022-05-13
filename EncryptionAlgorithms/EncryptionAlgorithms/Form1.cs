
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;
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
            listBoxInput.Items.Add(text);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"C:/Users/becario/Pictures/Documentos/Criptografia y seguridad/Archivo de clave capturada (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream tempStream;
                if ((tempStream = openFileDialog.OpenFile()) != null)
                {
                    string xmlFile = new StreamReader(tempStream).ReadToEnd();
                    byte[] encriptedData = RSAProvider.DecryptText(listBoxInput.Text, xmlFile);
                    listBoxResult.Items.Add(Encoding.ASCII.GetString(encriptedData));
                }
            }
        }

        private void listBoxInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

//https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.xml.encryptedkey?view=dotnet-plat-ext-6.0