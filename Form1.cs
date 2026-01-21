using System;
using System.IO;
using System.Windows.Forms;

namespace SD1App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            openToolStripMenuItem.Click += OpenFile;
            saveAsToolStripMenuItem.Click += SaveFileAs;
            exitToolStripMenuItem.Click += (s, e) => Close();
            aboutToolStripMenuItem.Click += ShowAbout;
        }

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
