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
    public partial class ReleaseTaskControl : UserControl {
        private ReleaseTask _releaseTask;
        private Point mouseDownLocation;
        public ReleaseTask ReleaseTask {
            get {
                return _releaseTask;
            }
            set {
                _releaseTask = value;
                SetControl();
            }
        }

        private void SetControl() {
            lblName.Text = _releaseTask.Title;
            dgvTargetEnvironments.DataSource = _releaseTask.TargetEnvironments;
        }

        public ReleaseTaskControl() {
            InitializeComponent();
        }

        public void AddTargetEnvironment(TargetEnvironment targetEnvironment) {
            _releaseTask.TargetEnvironments.Add(targetEnvironment);
        }

        private void ReleaseTaskControl_DragEnter(object sender, DragEventArgs e) {
            if(e.Data.GetDataPresent(typeof(ComponentControl))) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ReleaseTaskControl_DragDrop(object sender, DragEventArgs e) {
            ComponentControl componentControl = e.Data.GetData(typeof(ComponentControl)) as ComponentControl;
            componentControl.AddReleaseTask(_releaseTask);
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
