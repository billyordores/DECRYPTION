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
                        RSAe rsae = new RSAe(textBoxTexto.Text);
                        listBoxResult.Items.Add("Texto encriptado: " + rsae.Encrypt());
                        listBoxResult.Items.Add("Clave publica: " + rsae.getPublicKey());
                        listBoxResult.Items.Add("Clave privada: " + rsae.getPrivateKey);

                    }
                                  
                }
                else {
                    labelToE.Text = "Error seleccione el algoritmo";
                }
            } 
            catch (Exception E) { labelToE.Text = "Error revise bien las selecciones"; }

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
                textBoxClave.Visible = true;
                labelTexto.Visible = true;
                labelClave.Visible = true;
                textBoxTexto.Visible = true;
            }
            else {
                labelTexto.Visible = false;
                textBoxClave.Visible= false;
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
                    doc = XDocument.Parse(sr.ReadToEnd().Replace("&lt;", "<").Replace("&gt;", ">"));
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
    }
}

