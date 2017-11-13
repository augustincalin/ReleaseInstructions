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

        /// <summary>
        /// Environments in the Universe.
        /// </summary>
        public BindingList<Environment> Environments { get; set; }

        /// <summary>
        /// ReleaseTasks in the Universe.
        /// </summary>
        public BindingList<ReleaseTask> ReleaseTasks { get; set; }
        /// <summary>
        /// Components in the Universe.
        /// </summary>
        public BindingList<Component> Components { get; set; }

        public BindingList<Server> Servers { get; set; }
    }
}
