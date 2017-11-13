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
    public partial class ComponentControl : UserControl {
        public Model.Component Component {
            get {
                return _component;
            }
            set {
                _component = value;
                SetControl();
            }
        }
        private Point mouseDownLocation;
        private void SetControl() {
            lblName.Text = _component?.Name;
            if(null == _component.ReleaseTasks) {
                _component.ReleaseTasks = new BindingList<ReleaseTask>();
            }
            dgvReleaseTasks.DataSource = _component?.ReleaseTasks;

        }

        private Model.Component _component;
        public ComponentControl() {
            InitializeComponent();
            dgvReleaseTasks.AutoGenerateColumns = false;
        }
        public void AddReleaseTask(ReleaseTask releaseTask) {
            _component.ReleaseTasks.Add(releaseTask);
        }

        private void ComponentControl_MouseDown(object sender, MouseEventArgs e) {

        }

        private void ComponentControl_MouseMove(object sender, MouseEventArgs e) {
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) {
            this.DoDragDrop(this, DragDropEffects.Copy | DragDropEffects.Move);
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
