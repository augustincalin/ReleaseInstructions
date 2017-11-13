using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseInstructions.Model {
    public class Component {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// ReleaseTasks that deploy this Component
        /// </summary>
        public BindingList<ReleaseTask> ReleaseTasks { get; set; }

        public Component() {
            this.ReleaseTasks = new BindingList<ReleaseTask>();
        }
    }
}
