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
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBoxInput = new System.Windows.Forms.ListBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.labelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(99, 415);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(94, 38);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.Text = "encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(214, 415);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(94, 38);
            this.decryptButton.TabIndex = 1;
            this.decryptButton.Text = "decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBoxInput
            // 
            this.listBoxInput.FormattingEnabled = true;
            this.listBoxInput.ItemHeight = 15;
            this.listBoxInput.Location = new System.Drawing.Point(85, 146);
            this.listBoxInput.Name = "listBoxInput";
            this.listBoxInput.Size = new System.Drawing.Size(270, 244);
            this.listBoxInput.TabIndex = 3;
            this.listBoxInput.SelectedIndexChanged += new System.EventHandler(this.listBoxInput_SelectedIndexChanged);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 15;
            this.listBoxResult.Location = new System.Drawing.Point(402, 146);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(270, 244);
            this.listBoxResult.TabIndex = 4;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(85, 87);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(112, 15);
            this.labelText.TabIndex = 5;
            this.labelText.Text = "ENCRYPT/DECRUPT";
            this.labelText.Click += new System.EventHandler(this.labeText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 589);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.listBoxInput);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button encryptButton;
        private Button decryptButton;
        private OpenFileDialog openFileDialog1;
        private ListBox listBoxInput;
        private ListBox listBoxResult;
        private Label labelText;
    }
}