using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DiscordWalmart
{
    public class HeaderPanel : Panel
    {
        public static int ButtonWidth = 30;
        public static int HeaderHeight = 25;

        private bool _mouseDown = false;
        private Form _parentForm;
        private Point _lastLocation;

        public Form ParentForm;
        CloseButton closeButton;
        MaximizeButton maximizeButton;
        MinimizeButton minimizeButton;

        public HeaderPanel(Form form)
        {
            _parentForm = form;
            this.Location = new Point(0, 0);
            this.Width = form.Width;
            this.Height = HeaderHeight;

            this.BackColor = Color.FromArgb(45, 48, 71); //Space Cadet 

            ParentForm = form;

            form.Controls.Add(this);

            minimizeButton = new MinimizeButton(this);

            minimizeButton.Click += delegate (object sender, EventArgs e)
            {
                minimizeButton.ThisClick(sender, e, ParentForm);
            };

            maximizeButton = new MaximizeButton(this);

            maximizeButton.Click += delegate (object sender, EventArgs e)
            {
                maximizeButton.ThisClick(sender, e, ParentForm);
            };

            closeButton = new CloseButton(this);
            
            closeButton.Click += delegate (object sender, EventArgs e)
            {
                closeButton.ThisClick(sender, e, ParentForm);
            };

            this.MouseDown += HeaderPanel_MouseDown;
            this.MouseMove += HeaderPanel_MouseMove;
            this.MouseUp += HeaderPanel_MouseUp;
            this.Resize += HeaderPanel_Resize;
        }

        private void HeaderPanel_Resize(object sender, EventArgs e)
        {
            closeButton.Location = new Point(this.Width - HeaderPanel.ButtonWidth, 0);
            maximizeButton.Location = new Point(this.Width - 2 * HeaderPanel.ButtonWidth, 0);
            minimizeButton.Location = new Point(this.Width - 3 * HeaderPanel.ButtonWidth, 0);
        }

        private void HeaderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false; 
        }

        private void HeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                _parentForm.Location = new Point(
                    (_parentForm.Location.X - _lastLocation.X + e.X),
                    (_parentForm.Location.Y - _lastLocation.Y + e.Y)
                    );
            }
        }

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }
    }
}
