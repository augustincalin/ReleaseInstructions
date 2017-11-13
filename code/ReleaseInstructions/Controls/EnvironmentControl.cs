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
    public partial class EnvironmentControl : UserControl {
        private Model.Environment _environment;
        private Point mouseDownLocation;
        public Model.Environment Environment{ get {
                return _environment;
            } set {
                _environment = value;
                SetControl();
            } }

        private void SetControl() {
            lblName.Text = $"{_environment.Name}({_environment.Abbreviation})";
            dgvServers.DataSource = _environment.Servers;
        }

        public EnvironmentControl() {
            InitializeComponent();
        }

        public void AddServer(Server server) {
            _environment.Servers.Add(server);
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
