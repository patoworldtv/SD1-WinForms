namespace SD1App
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;

        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem enterKeyToolStripMenuItem;
        private ToolStripMenuItem encryptToolStripMenuItem;
        private ToolStripMenuItem decryptToolStripMenuItem;

        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;

        private TextBox textBoxContent;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new MenuStrip();

            this.fileToolStripMenuItem = new ToolStripMenuItem();
            this.openToolStripMenuItem = new ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new ToolStripMenuItem();
            this.exitToolStripMenuItem = new ToolStripMenuItem();

            this.toolsToolStripMenuItem = new ToolStripMenuItem();
            this.enterKeyToolStripMenuItem = new ToolStripMenuItem();
            this.encryptToolStripMenuItem = new ToolStripMenuItem();
            this.decryptToolStripMenuItem = new ToolStripMenuItem();

            this.helpToolStripMenuItem = new ToolStripMenuItem();
            this.aboutToolStripMenuItem = new ToolStripMenuItem();

            this.textBoxContent = new TextBox();

            // MenuStrip
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
                this.fileToolStripMenuItem,
                this.toolsToolStripMenuItem,
                this.helpToolStripMenuItem
            });

            // File menu
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.openToolStripMenuItem,
                this.saveAsToolStripMenuItem,
                this.exitToolStripMenuItem
            });

            this.openToolStripMenuItem.Text = "Open...";
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.exitToolStripMenuItem.Text = "Exit";

            // Tools menu
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.enterKeyToolStripMenuItem,
                this.encryptToolStripMenuItem,
                this.decryptToolStripMenuItem
            });

            this.enterKeyToolStripMenuItem.Text = "Enter Key...";
            this.encryptToolStripMenuItem.Text = "Encrypt";
            this.decryptToolStripMenuItem.Text = "Decrypt";

            // Help menu
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.DropDownItems.Add(this.aboutToolStripMenuItem);
            this.aboutToolStripMenuItem.Text = "About";

            // TextBox
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Dock = DockStyle.Fill;
            this.textBoxContent.ScrollBars = ScrollBars.Both;

            // Form
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "SD1 Application v1.0";
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
