using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReleaseInstructions.Model;

namespace ReleaseInstructions {
    public partial class ServerControl : UserControl {
        private Server _server;
        private Point mouseDownLocation;

        public Server Server {
            get { return _server; }
            set {
                _server = value;
                SetControl();
            }
        }

        private void SetControl() {
            lblName.Text = $"{_server.Name}({_server.Role})";
            lblEnvironment.Text = $"Env.:{_server.ParentEnvironment?.Name}";
            lblDescription.Text = _server.Description;
        }

        public ServerControl() {
            InitializeComponent();
        }

        public void SetEnvironment(Model.Environment environment) {
            _server.ParentEnvironment = environment;
        }

        private void lblName_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                mouseDownLocation = e.Location;
            }
        }

        private void lblName_MouseMove(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                this.Left = e.X + this.Left - mouseDownLocation.X;
                this.Top = e.Y + this.Top - mouseDownLocation.Y;
                if(this.Top > this.Parent.Height - 50 || this.Top < 50) {
                    ((TabPage)this.Parent).ScrollControlIntoView(this);
                }
            }
        }
    }
}
