using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseInstructions.Model {
    public class ReleaseInstructions {
        public DateTime ReleaseDateUAT { get; set; }
        public DateTime ReleaseDatePROD { get; set; }
        public string ReleaseManager { get; set; }
        public string ReleaseFolder { get; set; }
        public string CMNumber { get; set; }
        public BindingList<string> Components { get; set; }
        public BindingList<Task> Tasks { get; set; }
        public BindingList<Bug> Bugs { get; set; }
        public BindingList<ReleaseTask> ReleaseTasks { get; set; }

        public ReleaseInstructions() {

        }
    }
}
