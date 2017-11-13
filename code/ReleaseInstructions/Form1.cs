using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReleaseInstructions.Model;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Json;

namespace ReleaseInstructions {
    public partial class Form1 : Form {
        ReleaseInstructions.Model.ReleaseInstructions ri = new ReleaseInstructions.Model.ReleaseInstructions();
        Universe universe = new Universe();
        Dictionary<string, Point> positions = new Dictionary<string, Point>();
        public Form1() {
            InitializeComponent();
            SetupUniverse();
        }

        private void SetupUniverse() {
            universe = new Universe();
            universe.Name = "Configuration";
            universe.Components = new BindingList<Model.Component>();
            universe.Environments = new BindingList<Model.Environment>();
            universe.ReleaseTasks = new BindingList<ReleaseTask>();
            universe.Servers = new BindingList<Server>();
            universeBindingSource.Add(universe);
        }


        private void Form1_Load(object sender, EventArgs e) {



        }





        private void btSaveUniverse_Click(object sender, EventArgs e) {
            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Universe));
            ser.WriteObject(stream1, universe);
            stream1.Flush();
            string s = Encoding.Default.GetString(stream1.ToArray());
            using(var sfd = new SaveFileDialog()) {
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 1;

                if(sfd.ShowDialog() == DialogResult.OK) {
                    File.WriteAllText(sfd.FileName, s);
                    SaveControlsPositions();
                }
            }

        }

        private void btLoadUniverse_Click(object sender, EventArgs e) {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK) {
                try {
                    if((myStream = openFileDialog1.OpenFile()) != null) {
                        using(myStream) {
                            var reader = new StreamReader(myStream);
                            var s = reader.ReadToEnd();
                            //
                            using(MemoryStream stream = new MemoryStream(Encoding.Unicode.GetBytes(s))) {
                                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Universe));
                                universe = serializer.ReadObject(stream) as Universe;
                                universeBindingSource.Clear();
                                universeBindingSource.Add(universe);
                                LoadControlsPositions();
                            }

                        }
                    }
                } catch(Exception ex) {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void DrawControls() {
            tpConfigurationRelationships.Controls.Clear();
            int index = 0;
            foreach(Model.Environment environment in universe.Environments) {
                EnvironmentControl control = new EnvironmentControl();
                control.Environment = environment;
                control.Location = positions.ContainsKey(environment.Name) ? positions[environment.Name] : new Point(10, (control.Height + 10) * index++);
                tpConfigurationRelationships.Controls.Add(control);
                positions[environment.Name] = control.Location;
            }
            index = 0;
            foreach(Server server in universe.Servers) {
                ServerControl control = new ServerControl();
                control.Server = server;
                control.Location = positions.ContainsKey(server.Name) ? positions[server.Name] : new Point(350, (control.Height + 10) * index++);
                tpConfigurationRelationships.Controls.Add(control);
                positions[server.Name] = control.Location;
            }
            index = 0;
            foreach(ReleaseTask releaseTask in universe.ReleaseTasks) {
                ReleaseTaskControl control = new ReleaseTaskControl();
                control.ReleaseTask = releaseTask;
                control.Location = positions.ContainsKey(releaseTask.Title) ? positions[releaseTask.Title] : new Point(700, (control.Height + 10) * index++);
                tpConfigurationRelationships.Controls.Add(control);
                positions[releaseTask.Title] = control.Location;
            }
            index = 0;
            foreach(Model.Component component in universe.Components) {
                ComponentControl control = new ComponentControl();
                control.Component = component;
                control.Location = positions.ContainsKey(component.Name) ? positions[component.Name] : new Point(1050, (control.Height + 10) * index++);
                tpConfigurationRelationships.Controls.Add(control);
                positions[component.Name] = control.Location;
            }
            SaveControlsPositions();
        }

        private void SaveControlsPositions() {
            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Dictionary<string, Point>));
            ser.WriteObject(stream1, positions);
            stream1.Flush();
            string s = Encoding.Default.GetString(stream1.ToArray());
            File.WriteAllText("positions.json", s);
        }

        private void LoadControlsPositions() {
            var s = File.ReadAllText("positions.json");
            using(MemoryStream stream = new MemoryStream(Encoding.Unicode.GetBytes(s))) {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Dictionary<string, Point>));
                positions = serializer.ReadObject(stream) as Dictionary<string, Point>;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            if(tabControl1.SelectedTab == tpConfigurationRelationships) {
                DrawControls();
            }
        }

        private void tpConfigurationRelationships_MouseMove(object sender, MouseEventArgs e) {
            Debug.WriteLine(e.Y);
            if(e.Location.Y - tpConfigurationRelationships.Top > tpConfigurationRelationships.Height - 100 && e.Button == MouseButtons.Left) {
                Control c = GetChildAtPoint(e.Location);
                tpConfigurationRelationships.ScrollControlIntoView(c);
            }
        }
    }
}
