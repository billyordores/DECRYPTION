using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EncryptionAlgorithms
{
    internal class dataTreatment
    {
        public static OpenFileDialog openFileDialog = new OpenFileDialog();
        public static void loadData() {
            
            openFileDialog.Filter = "Archivo de clave capturada (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("Data cargada correctamente");               
            }

        }
        public static string getKeyByName( string nameKey) {
            try
            {
                using (var sr = new StreamReader(openFileDialog.OpenFile()))
                {
                    //rsa2.FromXmlString(sr.ReadToEnd());
                    XDocument doc = new XDocument();
                    doc = XDocument.Parse(sr.ReadToEnd().Replace("&lt;", "<").Replace("&gt;", ">"));
                    List<string> ids = doc.Descendants(nameKey).Select(e => e.Value).ToList();
                    foreach (string id in ids)
                    {
                        return id;
                    }
                }

            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
            return "";
        
        }
    }
}
