using System.Windows.Forms;
using System.Drawing;
using System;

namespace DiscordWalmart
{
    public class MinimizeButton : Button
    { 
        private Color _defaultBackColor;

        public void ThisClick(object sender, EventArgs e, Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        private void MinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = _defaultBackColor;
        }

        private void MinimizeButton_MouseHover(object sender, EventArgs e)
        {
            FormStart.messageLabel1.Enabled = true;
            FormStart.messageLabel1.Text = "Minimize";
            FormStart.messageLabel1.AutoSize = true;
            FormStart.messageLabel1.Font = new Font("Calibri", 12);
            FormStart.messageLabel1.Location = new Point(ClientRectangle.X + MousePosition.X, MousePosition.Y + HeaderPanel.HeaderHeight + 10);
        }   

        public MinimizeButton(Panel panel)
        {
            string minimizeIcon = Char.ConvertFromUtf32(0xE921);
            this.Font = new Font("Segoe MDL2 Assets", 10);
            this.AutoSize = false;

            this.Width = HeaderPanel.ButtonWidth;
            this.Text = minimizeIcon;
            this.Height = panel.Height;

            this._defaultBackColor = panel.BackColor;
            this.BackColor = this._defaultBackColor;
            this.ForeColor = Color.White;

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;

            this.Location = new Point(panel.Width - 3 * this.Width, 0);
            panel.Controls.Add(this);

            this.MouseEnter += new EventHandler(MinimizeButton_MouseEnter);
            this.MouseLeave += new EventHandler(MinimizeButton_MouseLeave);
            this.MouseHover += new EventHandler(MinimizeButton_MouseHover);
        }
    }
}
