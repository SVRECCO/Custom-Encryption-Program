using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Custom_encryption
{
    public partial class Form1 : Form
    {
        private string encryptionKey; // The encryption key
        public string GBKey { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            string originalText = tb1.Text;

            // Convert the encryptionKey to bytes (UTF-8 encoding)
            byte[] keyBytes = Encoding.UTF8.GetBytes(encryptionKey);

            // Convert the keyBytes back to a string
            string key = Encoding.UTF8.GetString(keyBytes);

            string encryptedText = EncryptText(originalText, key);
            tb2.Text = encryptedText;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            string encryptedText = tb1.Text;

            // Convert the encryptionKey to bytes (UTF-8 encoding)
            byte[] keyBytes = Encoding.UTF8.GetBytes(encryptionKey);

            // Convert the keyBytes back to a string
            string key = Encoding.UTF8.GetString(keyBytes);

            string decryptedText = DecryptText(encryptedText, key);
            tb2.Text = decryptedText;
        }

        public static string EncryptText(string plainText, string key)
        {
            using Aes aesAlg = Aes.Create();
            aesAlg.Key = Encoding.UTF8.GetBytes(key);
            aesAlg.IV = GenerateFixedIV(); // Use a fixed 128-bit IV

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using var msEncrypt = new MemoryStream();
            using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
            {
                using (StreamWriter swEncrypt = new StreamWriter(csEncrypt, Encoding.UTF8))
                {
                    swEncrypt.Write(plainText);
                }
            }

            return Convert.ToBase64String(msEncrypt.ToArray());
        }

        public static string DecryptText(string cipherText, string key)
        {
            using Aes aesAlg = Aes.Create();
            aesAlg.Key = Encoding.UTF8.GetBytes(key);
            aesAlg.IV = GenerateFixedIV(); // Use a fixed 128-bit IV

            byte[] data = Convert.FromBase64String(cipherText);

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using var msDecrypt = new MemoryStream(data);
            using CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
            using StreamReader srDecrypt = new StreamReader(csDecrypt, Encoding.UTF8);

            return srDecrypt.ReadToEnd();
        }

        private static byte[] GenerateFixedIV()
        {
            // Use a fixed 128-bit IV, adjust as needed
            byte[] fixedIV = new byte[16];
            return fixedIV;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            // Prompt the user to enter a 16-digit key
            string inputKey = PromptFor16DigitKey();

            if (IsValid16DigitKey(inputKey))
            {
                GBKey = inputKey;
                encryptionKey = GBKey; // Assign the user's input to encryptionKey
                bt3.Text = GBKey;
            }
            else
            {
                MessageBox.Show("Invalid key. Please enter a 16-digit key.", "Invalid Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string PromptFor16DigitKey()
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter a 16-digit key:", "Input Key", "");

            // Add debugging output
            Console.WriteLine("Input Key: " + input);
            Console.WriteLine("Input Key Length: " + input.Length);

            return input;
        }

        private bool IsValid16DigitKey(string key)
        {
            if (key.Length == 16)
            {
                foreach (char c in key)
                {
                    if (!char.IsDigit(c))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
