namespace WF_lab3_zad1_v2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboBoxAlgorithm = new ComboBox();
            textBoxPlainText = new TextBox();
            textBoxPlainTextHex = new TextBox();
            textBoxEncryptedTextAscii = new TextBox();
            textBoxEncryptedTextHex = new TextBox();
            textBoxDecryptedTextAscii = new TextBox();
            textBoxDecryptedTextHex = new TextBox();
            textBoxKey = new TextBox();
            textBoxIV = new TextBox();
            buttonGenerateKeys = new Button();
            buttonEncrypt = new Button();
            buttonDecrypt = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBoxEncryptTime = new TextBox();
            textBoxDecryptTime = new TextBox();
            label11 = new Label();
            buttonmanualKeys = new Button();
            label12 = new Label();
            SuspendLayout();
            // 
            // comboBoxAlgorithm
            // 
            comboBoxAlgorithm.FormattingEnabled = true;
            comboBoxAlgorithm.Location = new Point(119, 13);
            comboBoxAlgorithm.Margin = new Padding(4, 3, 4, 3);
            comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            comboBoxAlgorithm.Size = new Size(349, 23);
            comboBoxAlgorithm.TabIndex = 0;
            // 
            // textBoxPlainText
            // 
            textBoxPlainText.Location = new Point(119, 77);
            textBoxPlainText.Margin = new Padding(4, 3, 4, 3);
            textBoxPlainText.Multiline = true;
            textBoxPlainText.Name = "textBoxPlainText";
            textBoxPlainText.Size = new Size(349, 18);
            textBoxPlainText.TabIndex = 1;
            textBoxPlainText.Text = "Wprowadź tekst jawny";
            // 
            // textBoxPlainTextHex
            // 
            textBoxPlainTextHex.Location = new Point(119, 101);
            textBoxPlainTextHex.Margin = new Padding(4, 3, 4, 3);
            textBoxPlainTextHex.Multiline = true;
            textBoxPlainTextHex.Name = "textBoxPlainTextHex";
            textBoxPlainTextHex.Size = new Size(349, 27);
            textBoxPlainTextHex.TabIndex = 2;
            // 
            // textBoxEncryptedTextAscii
            // 
            textBoxEncryptedTextAscii.Location = new Point(119, 187);
            textBoxEncryptedTextAscii.Margin = new Padding(4, 3, 4, 3);
            textBoxEncryptedTextAscii.Multiline = true;
            textBoxEncryptedTextAscii.Name = "textBoxEncryptedTextAscii";
            textBoxEncryptedTextAscii.Size = new Size(349, 31);
            textBoxEncryptedTextAscii.TabIndex = 3;
            // 
            // textBoxEncryptedTextHex
            // 
            textBoxEncryptedTextHex.Location = new Point(119, 233);
            textBoxEncryptedTextHex.Margin = new Padding(4, 3, 4, 3);
            textBoxEncryptedTextHex.Multiline = true;
            textBoxEncryptedTextHex.Name = "textBoxEncryptedTextHex";
            textBoxEncryptedTextHex.Size = new Size(349, 33);
            textBoxEncryptedTextHex.TabIndex = 4;
            // 
            // textBoxDecryptedTextAscii
            // 
            textBoxDecryptedTextAscii.Location = new Point(119, 296);
            textBoxDecryptedTextAscii.Margin = new Padding(4, 3, 4, 3);
            textBoxDecryptedTextAscii.Multiline = true;
            textBoxDecryptedTextAscii.Name = "textBoxDecryptedTextAscii";
            textBoxDecryptedTextAscii.ReadOnly = true;
            textBoxDecryptedTextAscii.Size = new Size(349, 51);
            textBoxDecryptedTextAscii.TabIndex = 5;
            // 
            // textBoxDecryptedTextHex
            // 
            textBoxDecryptedTextHex.Location = new Point(119, 365);
            textBoxDecryptedTextHex.Margin = new Padding(4, 3, 4, 3);
            textBoxDecryptedTextHex.Multiline = true;
            textBoxDecryptedTextHex.Name = "textBoxDecryptedTextHex";
            textBoxDecryptedTextHex.ReadOnly = true;
            textBoxDecryptedTextHex.Size = new Size(349, 51);
            textBoxDecryptedTextHex.TabIndex = 6;
            // 
            // textBoxKey
            // 
            textBoxKey.Location = new Point(119, 468);
            textBoxKey.Margin = new Padding(4, 3, 4, 3);
            textBoxKey.Name = "textBoxKey";
            textBoxKey.Size = new Size(349, 23);
            textBoxKey.TabIndex = 7;
            // 
            // textBoxIV
            // 
            textBoxIV.Location = new Point(119, 498);
            textBoxIV.Margin = new Padding(4, 3, 4, 3);
            textBoxIV.Name = "textBoxIV";
            textBoxIV.Size = new Size(349, 23);
            textBoxIV.TabIndex = 8;
            // 
            // buttonGenerateKeys
            // 
            buttonGenerateKeys.Location = new Point(119, 541);
            buttonGenerateKeys.Margin = new Padding(4, 3, 4, 3);
            buttonGenerateKeys.Name = "buttonGenerateKeys";
            buttonGenerateKeys.Size = new Size(350, 27);
            buttonGenerateKeys.TabIndex = 9;
            buttonGenerateKeys.Text = "Generate Keys";
            buttonGenerateKeys.UseVisualStyleBackColor = true;
            buttonGenerateKeys.Click += buttonGenerateKeys_Click;
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Location = new Point(119, 622);
            buttonEncrypt.Margin = new Padding(4, 3, 4, 3);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new Size(350, 27);
            buttonEncrypt.TabIndex = 10;
            buttonEncrypt.Text = "Encrypt";
            buttonEncrypt.UseVisualStyleBackColor = true;
            buttonEncrypt.Click += buttonEncrypt_Click;
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.Location = new Point(119, 655);
            buttonDecrypt.Margin = new Padding(4, 3, 4, 3);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new Size(350, 27);
            buttonDecrypt.TabIndex = 11;
            buttonDecrypt.Text = "Decrypt";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 398);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 12;
            label1.Text = "Decrypted HEX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 329);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 13;
            label2.Text = "Decrypted ASCII";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 248);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 14;
            label3.Text = "Encrypted HEX";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 201);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 15;
            label4.Text = "Encrypted ASCII";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 77);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 16;
            label5.Text = "Text";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 110);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 17;
            label6.Text = "Text in HEX";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 473);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(26, 15);
            label7.TabIndex = 18;
            label7.Text = "Key";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 502);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(17, 15);
            label8.TabIndex = 19;
            label8.Text = "IV";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 21);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 20;
            label9.Text = "Algoritm";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 715);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(76, 15);
            label10.TabIndex = 21;
            label10.Text = "Encrypt Time";
            // 
            // textBoxEncryptTime
            // 
            textBoxEncryptTime.Location = new Point(119, 710);
            textBoxEncryptTime.Margin = new Padding(4, 3, 4, 3);
            textBoxEncryptTime.Name = "textBoxEncryptTime";
            textBoxEncryptTime.ReadOnly = true;
            textBoxEncryptTime.Size = new Size(349, 23);
            textBoxEncryptTime.TabIndex = 22;
            // 
            // textBoxDecryptTime
            // 
            textBoxDecryptTime.Location = new Point(119, 741);
            textBoxDecryptTime.Margin = new Padding(4, 3, 4, 3);
            textBoxDecryptTime.Name = "textBoxDecryptTime";
            textBoxDecryptTime.ReadOnly = true;
            textBoxDecryptTime.Size = new Size(349, 23);
            textBoxDecryptTime.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 745);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 24;
            label11.Text = "Decrypt Time";
            // 
            // buttonmanualKeys
            // 
            buttonmanualKeys.Location = new Point(119, 575);
            buttonmanualKeys.Margin = new Padding(4, 3, 4, 3);
            buttonmanualKeys.Name = "buttonmanualKeys";
            buttonmanualKeys.Size = new Size(350, 27);
            buttonmanualKeys.TabIndex = 25;
            buttonmanualKeys.Text = "Confirm Manually Entered Keys";
            buttonmanualKeys.UseVisualStyleBackColor = true;
            buttonmanualKeys.Click += buttonmanualKeys_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(119, 441);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(207, 15);
            label12.TabIndex = 26;
            label12.Text = "Generate Keys or Enter Them Manualy";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 823);
            Controls.Add(label12);
            Controls.Add(buttonmanualKeys);
            Controls.Add(label11);
            Controls.Add(textBoxDecryptTime);
            Controls.Add(textBoxEncryptTime);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDecrypt);
            Controls.Add(buttonEncrypt);
            Controls.Add(buttonGenerateKeys);
            Controls.Add(textBoxIV);
            Controls.Add(textBoxKey);
            Controls.Add(textBoxDecryptedTextHex);
            Controls.Add(textBoxDecryptedTextAscii);
            Controls.Add(textBoxEncryptedTextHex);
            Controls.Add(textBoxEncryptedTextAscii);
            Controls.Add(textBoxPlainTextHex);
            Controls.Add(textBoxPlainText);
            Controls.Add(comboBoxAlgorithm);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Encryption Tool";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxAlgorithm;
        private System.Windows.Forms.TextBox textBoxPlainText;
        private System.Windows.Forms.TextBox textBoxPlainTextHex;
        private System.Windows.Forms.TextBox textBoxEncryptedTextAscii;
        private System.Windows.Forms.TextBox textBoxEncryptedTextHex;
        private System.Windows.Forms.TextBox textBoxDecryptedTextHex;
        private System.Windows.Forms.TextBox textBoxDecryptedTextAscii;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxIV;
        private System.Windows.Forms.Button buttonGenerateKeys;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEncryptTime;
        private System.Windows.Forms.TextBox textBoxDecryptTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonmanualKeys;
        private System.Windows.Forms.Label label12;
    }
}
