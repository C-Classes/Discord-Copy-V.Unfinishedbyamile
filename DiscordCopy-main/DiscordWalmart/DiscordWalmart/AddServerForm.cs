using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordWalmart
{
    public class AddServerForm : Form
    {
        public static Label messageLabel1;
        public static Label headerLabel1;
        public TextBox textBox;
        private HeaderPanel header;
        public AddServerForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            header = new HeaderPanel(this);

            TextBox textBox = new TextBox();
            textBox.Location = new Point(this.Width / 2, this.Height / 2);
            messageLabel1 = new Label();
            messageLabel1.Enabled = false;
            headerLabel1 = new Label();
            headerLabel1.Text = "Add a server";
            headerLabel1.Enabled = true;
            headerLabel1.Location = new Point(1, 1);

            this.Controls.Add(messageLabel1);
            this.Controls.Add(headerLabel1);

            this.Controls.Add(textBox);

            this.Resize += FormStart_Resize;
            this.Activated += AddServerForm_Activated;

            SubmitButton submitButton = new SubmitButton(this);
            submitButton.Location = new Point(0, 20);
        }

        private void AddServerForm_Activated(object sender, EventArgs e)
        {
            
        }

        private void FormStart_Resize(object sender, EventArgs e)
        {
            header.Width = this.Width;
        }
    }
}
