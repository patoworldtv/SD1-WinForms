using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SD1App
{
    public class MainForm : Form
    {
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem fileOpenMenuItem;
        private ToolStripMenuItem fileSaveMenuItem;
        private ToolStripMenuItem exitMenuItem;

        private ToolStripMenuItem cryptoMenu;
        private ToolStripMenuItem setKeyMenuItem;

        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem aboutMenuItem;

        private TextBox textBox;
        private string encryptionKey = string.Empty;

        public MainForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "SD1 v1.0";
            this.Width = 800;
            this.Height = 600;

            menuStrip = new MenuStrip();

            fileMenu = new ToolStripMenuItem("File");
            fileOpenMenuItem = new ToolStripMenuItem("Open...");
            fileSaveMenuItem = new ToolStripMenuItem("Save As...");
            exitMenuItem = new ToolStripMenuItem("Exit");

            fileOpenMenuItem.Click += FileOpenMenuItem_Click;
            fileSaveMenuItem.Click += FileSaveMenuItem_Click;
            exitMenuItem.Click += (s, e) => this.Close();

            fileMenu.DropDownItems.Add(fileOpenMenuItem);
            fileMenu.DropDownItems.Add(fileSaveMenuItem);
            fileMenu.DropDownItems.Add(new ToolStripSeparator());
            fileMenu.DropDownItems.Add(exitMenuItem);

            cryptoMenu = new ToolStripMenuItem("Crypto");
            setKeyMenuItem = new ToolStripMenuItem("Set Key...");
            setKeyMenuItem.Click += SetKeyMenuItem_Click;
            cryptoMenu.DropDownItems.Add(setKeyMenuItem);

            helpMenu = new ToolStripMenuItem("Help");
            aboutMenuItem = new ToolStripMenuItem("About...");
            aboutMenuItem.Click += AboutMenuItem_Click;
            helpMenu.DropDownItems.Add(aboutMenuItem);

            menuStrip.Items.Add(fileMenu);
            menuStrip.Items.Add(cryptoMenu);
            menuStrip.Items.Add(helpMenu);

            textBox = new TextBox();
            textBox.Multiline = true;
            textBox.ScrollBars = ScrollBars.Both;
            textBox.Dock = DockStyle.Fill;
            textBox.Font = new System.Drawing.Font("Consolas", 10);

            this.Controls.Add(textBox);
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }

        private void FileOpenMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Open data file";
                ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string content = File.ReadAllText(ofd.FileName, Encoding.UTF8);
                    textBox.Text = content;
                }
            }
        }

        private void FileSaveMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Save data file";
                sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, textBox.Text, Encoding.UTF8);
                }
            }
        }

        private void SetKeyMenuItem_Click(object sender, EventArgs e)
        {
            using (var keyForm = new KeyInputForm(encryptionKey))
            {
                if (keyForm.ShowDialog() == DialogResult.OK)
                {
                    encryptionKey = keyForm.KeyValue;
                }
            }
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "SD1 version 1.0\nCreator: Your_name Your_surname\nOrganization: VVK",
                "About SD1",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
