using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Digital_Diary
{
    public partial class WritePad : Form
    {
        private String strPassword;

        public WritePad()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Prompt the user for consent to save
            DialogResult dr = MessageBox.Show("Do you wish to savw this entry?","Save entry",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                // Step 1: Open a file to write this entry into.
                String strFileName = ".\\Entries\\" + dtpDate.Value.ToShortDateString() + ".txt";
                if (!Directory.Exists(".\\Entries"))
                {
                    Directory.CreateDirectory(".\\Entries");
                }
                StreamWriter fileWriter = new StreamWriter(strFileName,true);
                
                // Step 2: Encrypt the text in the text field
                String strEntry = Encrypt(txtWriteArea.Text);
                
                // Step 3: Write the encrypted text to the file
                fileWriter.Write(strEntry);

                fileWriter.Close();
            }
        }

        private void WritePad_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            txtWriteArea.Text = "";
            Initialize();
        }

        private String Encrypt(String str)
        {
            StringBuilder strEncryptedString = new StringBuilder();
            if (strPassword != null)
            {
                // Encryption logic:
                // Add the ascii values of the characters in password
                // Mod it by 17
                // Add the number to each character.
                
                int iKey = 0;
                char cEncrypted;
                foreach (char c in strPassword.ToCharArray())
                {
                    iKey = iKey + (int)(c);
                }
                iKey = iKey % 17;
                foreach(char c in str)
                {
                    cEncrypted = (char)(((int)c + iKey)); 
                    strEncryptedString.Append(cEncrypted);
                }
            }
            return strEncryptedString.ToString();
        }

        private String Decrypt(String str)
        {
            StringBuilder strDecryptedString = new StringBuilder();
            if (strPassword != null)
            {
                // Decryption logic:
                // Add the ascii values of the characters in password
                // Mod it by 17
                // Subtract the number to each character.
                
                int iKey = 0;
                char cEncrypted;
                foreach (char c in strPassword.ToCharArray())
                {
                    iKey = iKey + (int)(c);
                }
                iKey = iKey % 17;
                foreach (char c in str)
                {
                    cEncrypted = (char)(((int)c - iKey));
                    strDecryptedString.Append(cEncrypted);
                }
            }
            return strDecryptedString.ToString();
        }

        private void Initialize()
        {
            if (strPassword != null)
            {
                // Load the text for that date
                String strFileName = ".\\Entries\\" + dtpDate.Value.ToShortDateString() + ".txt";
                if (File.Exists(strFileName))
                {
                    StreamReader fileReader = new StreamReader(strFileName, true);
                    String strEntry = fileReader.ReadToEnd();
                    txtWriteArea.Text = Decrypt(strEntry);
                    fileReader.Close();
                }
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            strPassword = txtPassword.Text;
            Initialize();
        }
    }
}
