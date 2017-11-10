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
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

            ri.CMNumber = "144";
            ri.Tasks = new BindingList<Model.Task> { new Model.Task { Developer="AC", Detail="detail 1", Id="1", IsBusinessTask=true },
                new Model.Task { Developer="DV", Detail="detail 2", Id="2", IsBusinessTask=true }
            };

            CreateUniverse();

        }

        private void CreateUniverse() {
            universe.Name = "General configuration";
            universe.Environments = new BindingList<Model.Environment> {
                new Model.Environment{
                    Name ="UAT"
                    , Abbreviation="UAT"
                    , Servers = new BindingList<Server> {
                        new Server{Name="Server 1", Description="server 1", Role="WEB.UAT.STG"},
                        new Server{Name="Server 2", Description="server 2nd", Role="WEB.UAT.LIVE"}
                    }
                }
                , new Model.Environment{
                    Name ="Production"
                    , Abbreviation="PROD"
                    , Servers = new BindingList<Server> {
                        new Server{Name="Server 1", Description="server 1", Role="WEB.PROD.STG"},
                        new Server{Name="Server 2", Description="server 2nd", Role="WEB.PROD.LIVE"}
                    }
                }

            };

        }

        private void label1_MouseDown(object sender, MouseEventArgs e) {
            label1.DoDragDrop(label1.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void button2_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Copy;
        }

        private void button2_DragOver(object sender, DragEventArgs e) {

        }

        private void btSaveUniverse_Click(object sender, EventArgs e) {
            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Universe));
            ser.WriteObject(stream1, universe);
            stream1.Flush();
            string s = Encoding.Default.GetString(stream1.ToArray());
        }
    }
}
