using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF_lab3_zad1_v2
{
    public partial class Form1 : Form
    {
        private SymmetricAlgorithm algorithm;

        private Stopwatch stopwatchEncrypt = new Stopwatch();

        private byte[] manualKey;
        private byte[] manualIV;
        private byte[] manualOrGenearatedKey;
        private byte[] manualOrGenearatedIV;

        public Form1()
        {
            InitializeComponent();
            comboBoxAlgorithm.Items.AddRange(new string[] { "AES", "DES" });
            comboBoxAlgorithm.SelectedIndex = 0;
        }

        private void buttonGenerateKeys_Click(object sender, EventArgs e)
        {
            algorithm = GetAlgorithm();
            algorithm.GenerateKey();
            algorithm.GenerateIV();

            textBoxKey.Text = BitConverter.ToString(algorithm.Key).Replace("-", "");//---ok
            textBoxIV.Text = BitConverter.ToString(algorithm.IV).Replace("-", "");//---ok

            manualOrGenearatedKey = algorithm.Key;
            manualOrGenearatedIV = algorithm.IV;


        }

        private void buttonmanualKeys_Click(object sender, EventArgs e)
        {
            algorithm = GetAlgorithm();

            manualOrGenearatedKey = StringToByteArray(textBoxKey.Text);
            manualOrGenearatedIV = StringToByteArray(textBoxIV.Text);

        }

        private SymmetricAlgorithm GetAlgorithm()
        {
            switch (comboBoxAlgorithm.SelectedItem.ToString())
            {
                case "AES":
                    return Aes.Create();
                case "DES":
                    return DES.Create();
                default:
                    throw new NotImplementedException();
            }
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {


            //if (algorithm == null)
            if (textBoxKey.Text == "" && textBoxIV.Text == "")
            {
                MessageBox.Show("Prosz� wygeneruj Klucze.");
                return;
            }

            string plainText = textBoxPlainText.Text;

            byte[] plainBytes = Encoding.ASCII.GetBytes(plainText);//---ok
            textBoxPlainTextHex.Text = BitConverter.ToString(plainBytes).Replace("-", "");

            stopwatchEncrypt.Start();

            byte[] encryptedBytes = EncryptStringToBytes(plainText, manualOrGenearatedKey, manualOrGenearatedIV); 

            stopwatchEncrypt.Stop();
            textBoxEncryptTime.Text = stopwatchEncrypt.ElapsedMilliseconds.ToString() + " ms";

            textBoxEncryptedTextAscii.Text = Encoding.ASCII.GetString(encryptedBytes);
            textBoxEncryptedTextHex.Text = BitConverter.ToString(encryptedBytes).Replace("-", "");
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (textBoxKey.Text == "" && textBoxIV.Text == "")
            {
                MessageBox.Show("Wprowad� klucze.");
                return;
            }

            try
            {
                byte[] encryptedBytes = StringToByteArray(textBoxEncryptedTextHex.Text);
                string decryptedText = DecryptStringFromBytes(encryptedBytes, manualOrGenearatedKey, manualOrGenearatedIV); 


                //---

                textBoxDecryptedTextAscii.Text = decryptedText;
                byte[] decryptedBytes = Encoding.ASCII.GetBytes(decryptedText);
                textBoxDecryptedTextHex.Text = BitConverter.ToString(decryptedBytes).Replace("-", "");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Odszyfrowanie nie powiod�o si�: {ex.Message}");
            }
        }

        private byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            using (var encryptor = algorithm.CreateEncryptor(Key, IV))
            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                using (var sw = new StreamWriter(cs))
                {
                    sw.Write(plainText);
                }
                return ms.ToArray();
            }
        }

        private string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            using (var decryptor = algorithm.CreateDecryptor(Key, IV))
            using (var ms = new MemoryStream(cipherText))
            using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
            using (var sr = new StreamReader(cs))
            {
                return sr.ReadToEnd();
            }
        }

        private byte[] StringToByteArray(string hex)
        {
            int numberChars = hex.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
    }
}