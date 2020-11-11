using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DiscordWalmart
{
    public class SidePanel: Panel
    {
        private List<ServerButton> serverButtons = new List<ServerButton>();

        private int AdjustedWith(Control control)
        {
            int relativeWidth = control.ClientSize.Width / 15;
            int absoluteWidth = 50;
            if (relativeWidth > absoluteWidth)
                return relativeWidth;
            else
                return absoluteWidth;
        }

        public SidePanel(Control control)
        {
            this.Location = new Point(0, HeaderPanel.HeaderHeight);
            this.Width = AdjustedWith(control);
            this.Height = control.Height;
            this.BackColor = Color.FromArgb(45, 48, 71);//Space Cadet

            for(int i = 0; i < 3; ++i)
            {
                ServerButton serverButton = new ServerButton(this);
                serverButton.Location = new Point(0, i * serverButton.Height);
                this.serverButtons.Add(serverButton);
            }
            ServerButton addServerButton = new ServerButton(this);
            addServerButton.Location = new Point(0, serverButtons.Count * addServerButton.Height);
            addServerButton.IsAddButton = true;

            control.Controls.Add(this);
        }
    }
}
