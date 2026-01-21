using System;
using System.IO;
using System.Windows.Forms;

namespace SD1App
{
    public partial class Form1 : Form
    {
        private string encryptionKey = "";

        public Form1()
        {
            InitializeComponent();

            openToolStripMenuItem.Click += OpenFile;
            saveAsToolStripMenuItem.Click += SaveFileAs;
            exitToolStripMenuItem.Click += (s, e) => Close();

            enterKeyToolStripMenuItem.Click += EnterKey;
            encryptToolStripMenuItem.Click += EncryptText;
            decryptToolStripMenuItem.Click += DecryptText;

            aboutToolStripMenuItem.Click += ShowAbout;
        }

        // ---------------- FILE MENU ----------------

        private void OpenFile(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
                textBoxContent.Text = File.ReadAllText(ofd.FileName);
        }

        private void SaveFileAs(object sender, EventArgs e)
        {
            using SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sfd.FileName, textBoxContent.Text);
        }

        // ---------------- TOOLS MENU ----------------

        private void EnterKey(object sender, EventArgs e)
        {
            string key = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter encryption key:",
                "Encryption Key",
                ""
            );

            if (!string.IsNullOrEmpty(key))
            {
                encryptionKey = key;
                MessageBox.Show("Key saved successfully.");
            }
        }

        private string XorCipher(string input, string key)
        {
            if (string.IsNullOrEmpty(key))
                return input;

            char[] buffer = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
                buffer[i] = (char)(input[i] ^ key[i % key.Length]);

            return new string(buffer);
        }

        private void EncryptText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(encryptionKey))
            {
                MessageBox.Show("Please enter a key first.");
                return;
            }

            textBoxContent.Text = XorCipher(textBoxContent.Text, encryptionKey);
        }

        private void DecryptText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(encryptionKey))
            {
                MessageBox.Show("Please enter a key first.");
                return;
            }

            textBoxContent.Text = XorCipher(textBoxContent.Text, encryptionKey);
        }

        // ---------------- HELP MENU ----------------

        private void ShowAbout(object sender, EventArgs e)
        {
            MessageBox.Show(
                "SD1 Application v1.0\nCreated by Patrick [Surname]\nOrganization: VVK",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
