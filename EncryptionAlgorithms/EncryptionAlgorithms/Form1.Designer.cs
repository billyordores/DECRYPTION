namespace EncryptionAlgorithms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonStart = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBoxInput = new System.Windows.Forms.ListBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.labelText = new System.Windows.Forms.Label();
            this.comboBoxAlgo = new System.Windows.Forms.ComboBox();
            this.comboBoxED = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCargar1 = new System.Windows.Forms.Button();
            this.buttonCargar2 = new System.Windows.Forms.Button();
            this.textBoxTexto = new System.Windows.Forms.TextBox();
            this.labelTexto = new System.Windows.Forms.Label();
            this.labelClave = new System.Windows.Forms.Label();
            this.labelToE = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonCreateKeys = new System.Windows.Forms.Button();
            this.buttonSaveXmlPublic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(487, 446);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(107, 51);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "GOO.. :)";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBoxInput
            // 
            this.listBoxInput.FormattingEnabled = true;
            this.listBoxInput.HorizontalScrollbar = true;
            this.listBoxInput.ItemHeight = 15;
            this.listBoxInput.Location = new System.Drawing.Point(79, 173);
            this.listBoxInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxInput.Name = "listBoxInput";
            this.listBoxInput.Size = new System.Drawing.Size(308, 319);
            this.listBoxInput.TabIndex = 3;
            this.listBoxInput.SelectedIndexChanged += new System.EventHandler(this.listBoxInput_SelectedIndexChanged);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 15;
            this.listBoxResult.Location = new System.Drawing.Point(693, 173);
            this.listBoxResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxResult.Size = new System.Drawing.Size(308, 319);
            this.listBoxResult.TabIndex = 4;
            this.listBoxResult.SelectedIndexChanged += new System.EventHandler(this.listBoxResult_SelectedIndexChanged);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("SimSun-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelText.Location = new System.Drawing.Point(389, 22);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(219, 33);
            this.labelText.TabIndex = 5;
            this.labelText.Text = "Criptografia";
            this.labelText.Click += new System.EventHandler(this.labeText_Click);
            // 
            // comboBoxAlgo
            // 
            this.comboBoxAlgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlgo.Items.AddRange(new object[] {
            "RSA",
            "Algotimo2",
            "Algotimo3",
            "Algotimo4"});
            this.comboBoxAlgo.Location = new System.Drawing.Point(462, 351);
            this.comboBoxAlgo.Name = "comboBoxAlgo";
            this.comboBoxAlgo.Size = new System.Drawing.Size(154, 23);
            this.comboBoxAlgo.TabIndex = 6;
            this.comboBoxAlgo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxED
            // 
            this.comboBoxED.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxED.Items.AddRange(new object[] {
            "Encriptar",
            "Desencriptar"});
            this.comboBoxED.Location = new System.Drawing.Point(462, 229);
            this.comboBoxED.Name = "comboBoxED";
            this.comboBoxED.Size = new System.Drawing.Size(154, 23);
            this.comboBoxED.TabIndex = 7;
            this.comboBoxED.SelectedIndexChanged += new System.EventHandler(this.comboBoxED_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(419, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Encriptar o Desenciptar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(419, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seleccione el Algoritmo";
            // 
            // buttonCargar1
            // 
            this.buttonCargar1.Location = new System.Drawing.Point(79, 119);
            this.buttonCargar1.Name = "buttonCargar1";
            this.buttonCargar1.Size = new System.Drawing.Size(132, 29);
            this.buttonCargar1.TabIndex = 10;
            this.buttonCargar1.Text = "Cargar Xml";
            this.buttonCargar1.UseVisualStyleBackColor = true;
            this.buttonCargar1.Visible = false;
            this.buttonCargar1.Click += new System.EventHandler(this.buttonCargar1_Click);
            // 
            // buttonCargar2
            // 
            this.buttonCargar2.Location = new System.Drawing.Point(229, 119);
            this.buttonCargar2.Name = "buttonCargar2";
            this.buttonCargar2.Size = new System.Drawing.Size(192, 29);
            this.buttonCargar2.TabIndex = 13;
            this.buttonCargar2.Text = "Cargar Texto Encriptado";
            this.buttonCargar2.UseVisualStyleBackColor = true;
            this.buttonCargar2.Visible = false;
            this.buttonCargar2.Click += new System.EventHandler(this.buttonCargar2_Click);
            // 
            // textBoxTexto
            // 
            this.textBoxTexto.Location = new System.Drawing.Point(79, 381);
            this.textBoxTexto.Name = "textBoxTexto";
            this.textBoxTexto.Size = new System.Drawing.Size(308, 23);
            this.textBoxTexto.TabIndex = 14;
            this.textBoxTexto.Visible = false;
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Location = new System.Drawing.Point(79, 351);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(38, 15);
            this.labelTexto.TabIndex = 15;
            this.labelTexto.Text = "Texto:";
            this.labelTexto.Visible = false;
            // 
            // labelClave
            // 
            this.labelClave.AutoSize = true;
            this.labelClave.Location = new System.Drawing.Point(79, 195);
            this.labelClave.Name = "labelClave";
            this.labelClave.Size = new System.Drawing.Size(39, 15);
            this.labelClave.TabIndex = 16;
            this.labelClave.Text = "Clave:";
            this.labelClave.Visible = false;
            // 
            // labelToE
            // 
            this.labelToE.AutoSize = true;
            this.labelToE.Location = new System.Drawing.Point(476, 535);
            this.labelToE.Name = "labelToE";
            this.labelToE.Size = new System.Drawing.Size(58, 15);
            this.labelToE.TabIndex = 17;
            this.labelToE.Text = "labelToErr";
            // 
            // buttonCreateKeys
            // 
            this.buttonCreateKeys.Location = new System.Drawing.Point(79, 229);
            this.buttonCreateKeys.Name = "buttonCreateKeys";
            this.buttonCreateKeys.Size = new System.Drawing.Size(132, 29);
            this.buttonCreateKeys.TabIndex = 18;
            this.buttonCreateKeys.Text = "Crear Claves";
            this.buttonCreateKeys.UseVisualStyleBackColor = true;
            this.buttonCreateKeys.Visible = false;
            this.buttonCreateKeys.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSaveXmlPublic
            // 
            this.buttonSaveXmlPublic.Location = new System.Drawing.Point(229, 229);
            this.buttonSaveXmlPublic.Name = "buttonSaveXmlPublic";
            this.buttonSaveXmlPublic.Size = new System.Drawing.Size(132, 29);
            this.buttonSaveXmlPublic.TabIndex = 19;
            this.buttonSaveXmlPublic.Text = "Cargar Xml Public";
            this.buttonSaveXmlPublic.UseVisualStyleBackColor = true;
            this.buttonSaveXmlPublic.Visible = false;
            this.buttonSaveXmlPublic.Click += new System.EventHandler(this.buttonSaveXmlPublic_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1068, 620);
            this.Controls.Add(this.buttonSaveXmlPublic);
            this.Controls.Add(this.buttonCreateKeys);
            this.Controls.Add(this.labelToE);
            this.Controls.Add(this.labelClave);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.textBoxTexto);
            this.Controls.Add(this.buttonCargar2);
            this.Controls.Add(this.buttonCargar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxED);
            this.Controls.Add(this.comboBoxAlgo);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.listBoxInput);
            this.Controls.Add(this.buttonStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonStart;
        private OpenFileDialog openFileDialog1;
        private ListBox listBoxInput;
        private ListBox listBoxResult;
        private Label labelText;
        private ComboBox comboBoxAlgo;
        private ComboBox comboBoxED;
        private Label label1;
        private Label label2;
        private Button buttonCargar1;
        private Button buttonCargar2;
        private TextBox textBoxTexto;
        private Label labelTexto;
        private Label labelClave;
        private Label labelToE;
        private System.Windows.Forms.Timer timer1;
        private Button buttonCreateKeys;
        private Button buttonSaveXmlPublic;
    }
}