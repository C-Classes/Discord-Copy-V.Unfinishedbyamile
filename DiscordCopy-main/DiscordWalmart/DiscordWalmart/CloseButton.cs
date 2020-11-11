using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiscordWalmart
{
    public class CloseButton : Button
    {
        private Color _defaultBackColor;

        public void ThisClick(object sender, EventArgs e, Form form)
        {
            form.Close();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = _defaultBackColor;
        }

        public CloseButton(Panel panel)
        {
            string closeIcon = Char.ConvertFromUtf32(0xE8BB);
            this.Font = new Font("Segoe MDL2 Assets", 10);
            this.AutoSize = false;

            this.Width = HeaderPanel.ButtonWidth;
            this.Text = closeIcon;
            this.Height = panel.Height;

            this._defaultBackColor = panel.BackColor;
            this.BackColor = this._defaultBackColor;
            this.ForeColor = Color.White;

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;

            this.Location = new Point(panel.Width - this.Width, 0);
            panel.Controls.Add(this);

            this.MouseEnter += new EventHandler(CloseButton_MouseEnter);
            this.MouseLeave += new EventHandler(CloseButton_MouseLeave);
        }
    }
}
