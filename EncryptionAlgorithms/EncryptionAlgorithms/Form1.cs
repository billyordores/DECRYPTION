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
        public static OpenFileDialog openFileDialogClave = new OpenFileDialog();
        public static OpenFileDialog openFileDialogTexto = new OpenFileDialog();
        public static OpenFileDialog openFileDialogXmlPublic = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            try 
            {
                if (comboBoxAlgo.Text =="RSA" && comboBoxED.Text=="Desencriptar") {
                    using (var sr = new StreamReader(openFileDialogClave.OpenFile()))
                    {
                        XDocument doc = new XDocument();
                        doc = XDocument.Parse(sr.ReadToEnd().Replace("&lt;", "<").Replace("&gt;", ">"));
                        using (var sr2 = new StreamReader(openFileDialogTexto.OpenFile()))
                        {
                            RSAd rsa = new RSAd(doc, sr2.ReadToEnd());
                            listBoxResult.Items.Add(rsa.decrypt());
                        }
                    }
                }
                else if(comboBoxAlgo.Text == "RSA" && comboBoxED.Text == "Encriptar") 
                {
                    if (textBoxTexto.Text == "")
                    {
                        textBoxTexto.Text = "Escriba algo el texto a encriptar aquí";
                    }
                    else 
                    {       
                        using (var keyPublic = new StreamReader(openFileDialogXmlPublic.OpenFile()))
                        {
                            RSAe rsaE = new RSAe(textBoxTexto.Text, keyPublic.ReadToEnd());
                            listBoxResult.Items.Add(rsaE.Encrypt());
                            FolderBrowserDialog browserDialog = new FolderBrowserDialog();

                            if (browserDialog.ShowDialog() == DialogResult.OK)
                            {
                                string folderName = browserDialog.SelectedPath;
                                FileStream fileStream = new FileStream(Path.Combine(folderName, "TextoEncriptado.txt"), FileMode.Create, FileAccess.Write);
                                byte[] textEncrypted = Convert.FromBase64String(rsaE.Encrypt());
                                fileStream.Write(textEncrypted, 0, textEncrypted.Length);
                                fileStream.Close();
                            }
                        }
                    }
                                  
                }
                else {
                    labelToE.Text = "Error seleccione el algoritmo";
                }
                
            } 
            catch (Exception E) { labelToE.Text = E.Message; }

        }

        private void listBoxInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxResult.HorizontalScrollbar = true;
        }

        private void labeText_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxED_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxED.Text == "Desencriptar")
            {
                buttonCargar1.Visible = true;
                buttonCargar2.Visible = true;
                listBoxInput.Visible = true;
            }
            else {
                buttonCargar1.Visible = false;
                buttonCargar2.Visible = false;
                listBoxInput.Visible = false;
            }
            if (comboBoxED.Text == "Encriptar")
            {
                buttonCreateKeys.Visible = true;
                buttonSaveXmlPublic.Visible = true; 
                labelTexto.Visible = true;
                labelClave.Visible = true;
                textBoxTexto.Visible = true;
            }
            else {
                labelTexto.Visible = false;
                buttonCreateKeys.Visible= false;
                buttonSaveXmlPublic.Visible = false;
                labelClave.Visible = false;
                textBoxTexto.Visible = false;
            }
        }

        private void listBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxResult.HorizontalScrollbar = true;
        }

        private void buttonCargar1_Click(object sender, EventArgs e)
        {
            openFileDialogClave.Filter = "Archivo de clave capturada (*.xml)|*.xml";
            if (openFileDialogClave.ShowDialog() == DialogResult.OK)
            {
                using (var sr = new StreamReader(openFileDialogClave.OpenFile()))
                {
                    XDocument doc = new XDocument();
                    doc = XDocument.Parse(sr.ReadToEnd().Replace("&lt;", "<").Replace("&gt;", ">").Replace("  ", ""));
                    listBoxInput.Items.Add("Clave: "+ doc.ToString());
                }                    
            }
            else
            {
                listBoxInput.Items.Add("Clave: Se encontro un error al cargar la clave");
            }
        }

        private void buttonCargar2_Click(object sender, EventArgs e)
        {
            openFileDialogTexto.Filter = "Archivo de clave capturada (*.txt)|*.txt";
            if (openFileDialogTexto.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialogTexto.OpenFile()))
                {                    
                    listBoxInput.Items.Add("Texto Encriptado: " + sr.ReadToEnd());
                }
            }
            else 
            {
                listBoxInput.Items.Add("Clave: Se encontro un error al cargar el texto");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Keys key = new Keys();
            key.createKeys();
        }

        private void buttonSaveXmlPublic_Click(object sender, EventArgs e)
        {
            openFileDialogXmlPublic.Filter = "Archivo de clave capturada (*.xml)|*.xml";
            if (openFileDialogXmlPublic.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialogXmlPublic.OpenFile()))
                {
                    listBoxResult.Items.Add("Texto Encriptado: " + sr.ReadToEnd());
                }
                listBoxResult.Items.Add("Clave Publica Cargada.");
            }
            else
            {
                listBoxResult.Items.Add("Clave: Se encontro un error al cargar la clave");
            }
        }
    }
}

