using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseInstructions.Model {

    public class Universe {
        public Universe() {

        }

        public string Name { get; set; }

        public BindingList<Environment> Environments { get; set; }

        public BindingList<ReleaseTask> ReleaseTasks { get; set; }
    }
}
