using System.Windows.Forms;
using System.Drawing;
using System;

namespace DiscordWalmart
{
    public class MaximizeButton : Button
    {
        private Color _defaultBackColor;

        public void ThisClick(object sender, EventArgs e, Form form)
        {
            if (form.WindowState == FormWindowState.Normal)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            else if (form.WindowState == FormWindowState.Maximized)
                form.WindowState = FormWindowState.Normal;
        }

        private void MaximizeButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void MaximizeButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = _defaultBackColor;
        }

        private void MaximizeButton_MouseHover(object sender, EventArgs e)
        {

        }

        public MaximizeButton(Panel panel)
        {
            string minimizeIcon = Char.ConvertFromUtf32(0xE923);
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

            this.Location = new Point(panel.Width - 2 * this.Width, 0);
            panel.Controls.Add(this);

            this.MouseEnter += new EventHandler(MaximizeButton_MouseEnter);
            this.MouseLeave += new EventHandler(MaximizeButton_MouseLeave);
            this.MouseHover += new EventHandler(MaximizeButton_MouseHover);
        }
    }
}
