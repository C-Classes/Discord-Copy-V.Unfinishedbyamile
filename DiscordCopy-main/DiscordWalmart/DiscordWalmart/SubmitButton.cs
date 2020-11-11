using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace DiscordWalmart
{
    public class SubmitButton : Button
    {
        public static Label submitText;
        public SubmitButton(Control control)
        { 
            this.Width = 100;
            this.Height = control.Height / 10;
            this.BackColor = Color.White;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;

            submitText = new Label();
            submitText.Text = "Submit";
            submitText.Enabled = true;
            submitText.Location = new Point(0, 10);

            this.Controls.Add(submitText);

            control.Controls.Add(this);
        }
    }
}
