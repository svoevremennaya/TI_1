namespace lab_1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCipherTypes = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.txbData = new System.Windows.Forms.TextBox();
            this.txbKey = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.rbEncrypt = new System.Windows.Forms.RadioButton();
            this.rbDecrypt = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cmbCipherTypes
            // 
            this.cmbCipherTypes.FormattingEnabled = true;
            this.cmbCipherTypes.Items.AddRange(new object[] {
            "Rail-fence cipher",
            "Column cipher",
            "Turning grille cipher",
            "Vigenere cipher"});
            this.cmbCipherTypes.Location = new System.Drawing.Point(110, 47);
            this.cmbCipherTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCipherTypes.Name = "cmbCipherTypes";
            this.cmbCipherTypes.Size = new System.Drawing.Size(246, 26);
            this.cmbCipherTypes.TabIndex = 0;
            this.cmbCipherTypes.Text = "Choose type of cipher";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(107, 104);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(120, 18);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Input the plaintext";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(107, 176);
            this.lblKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(90, 18);
            this.lblKey.TabIndex = 2;
            this.lblKey.Text = "Input the key";
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(110, 127);
            this.txbData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(463, 24);
            this.txbData.TabIndex = 3;
            // 
            // txbKey
            // 
            this.txbKey.Location = new System.Drawing.Point(110, 199);
            this.txbKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbKey.Name = "txbKey";
            this.txbKey.Size = new System.Drawing.Size(463, 24);
            this.txbKey.TabIndex = 4;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(110, 272);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(130, 43);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "Start";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(107, 358);
            this.lblRes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(115, 18);
            this.lblRes.TabIndex = 6;
            this.lblRes.Text = "The ciphertext is";
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(110, 380);
            this.txbResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(463, 24);
            this.txbResult.TabIndex = 7;
            // 
            // rbEncrypt
            // 
            this.rbEncrypt.AutoSize = true;
            this.rbEncrypt.Location = new System.Drawing.Point(475, 37);
            this.rbEncrypt.Name = "rbEncrypt";
            this.rbEncrypt.Size = new System.Drawing.Size(79, 22);
            this.rbEncrypt.TabIndex = 10;
            this.rbEncrypt.TabStop = true;
            this.rbEncrypt.Text = "Encrypt";
            this.rbEncrypt.UseVisualStyleBackColor = true;
            // 
            // rbDecrypt
            // 
            this.rbDecrypt.AutoSize = true;
            this.rbDecrypt.Location = new System.Drawing.Point(475, 65);
            this.rbDecrypt.Name = "rbDecrypt";
            this.rbDecrypt.Size = new System.Drawing.Size(80, 22);
            this.rbDecrypt.TabIndex = 11;
            this.rbDecrypt.TabStop = true;
            this.rbDecrypt.Text = "Decrypt";
            this.rbDecrypt.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 480);
            this.Controls.Add(this.rbDecrypt);
            this.Controls.Add(this.rbEncrypt);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txbKey);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cmbCipherTypes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Simple ciphers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCipherTypes;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.TextBox txbKey;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.RadioButton rbEncrypt;
        private System.Windows.Forms.RadioButton rbDecrypt;
    }
}

