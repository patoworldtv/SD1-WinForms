using System;
using System.Windows.Forms;

namespace SD1App
{
    public class KeyInputForm : Form
    {
        private TextBox keyTextBox;
        private Button okButton;
        private Button cancelButton;

        public string KeyValue => keyTextBox.Text;

        public KeyInputForm(string currentKey)
        {
            InitializeComponents();
            keyTextBox.Text = currentKey;
        }

        private void InitializeComponents()
        {
            this.Text = "Set Encryption Key";
            this.Width = 400;
            this.Height = 150;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            keyTextBox = new TextBox();
            keyTextBox.Dock = DockStyle.Top;
            keyTextBox.Margin = new Padding(10);

            okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Dock = DockStyle.Left;
            okButton.Width = 100;

            cancelButton = new Button();
            cancelButton.Text = "Cancel";
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Dock = DockStyle.Right;
            cancelButton.Width = 100;

            var panel = new Panel();
            panel.Dock = DockStyle.Bottom;
            panel.Height = 40;
            panel.Controls.Add(okButton);
            panel.Controls.Add(cancelButton);

            this.Controls.Add(keyTextBox);
            this.Controls.Add(panel);

            this.AcceptButton = okButton;
            this.CancelButton = cancelButton;
        }
    }
}
