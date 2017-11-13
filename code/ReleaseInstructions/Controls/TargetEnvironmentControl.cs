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
    public partial class TargetEnvironmentControl : UserControl {
        private TargetEnvironment _targetEnvironment;
        public TargetEnvironment TargetEnviornoment { get {
                return _targetEnvironment;
            } set {
                _targetEnvironment = value;
                SetControl();
            } }

        private void SetControl() {
            lblName.Text = $"on {_targetEnvironment.Environment.Name}";
            dgvTargetServers.DataSource = _targetEnvironment.TargetServers;
            lblParentReleaseTask.Text = $"Task: {_targetEnvironment.ParentTask.Title}";
        }

        public TargetEnvironmentControl() {
            InitializeComponent();
        }

        public void SetParentReleaseTask(ReleaseTask releaseTask) {
            _targetEnvironment.ParentTask = releaseTask;
        }

        public void AddTargetServer(Server server) {
            _targetEnvironment.TargetServers.Add(server);
        }

        private void TargetEnvironmentControl_DragEnter(object sender, DragEventArgs e) {
            
        }
    }
}
