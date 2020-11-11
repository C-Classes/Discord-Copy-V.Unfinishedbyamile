using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordWalmart
{
    public partial class FormStart : Form
    {
        public static Label messageLabel1;
        private HeaderPanel header;
        SidePanel sidepanel;
        public FormStart()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            header = new HeaderPanel(this);
            sidepanel = new SidePanel(this);

            messageLabel1 = new Label();
            messageLabel1.Enabled = false;


            this.Controls.Add(messageLabel1);

            this.Resize += FormStart_Resize;
        }

        private void FormStart_Resize(object sender, EventArgs e)
        {
            header.Width = this.Width;
            sidepanel.Height = this.Height;
        }
    }
}
