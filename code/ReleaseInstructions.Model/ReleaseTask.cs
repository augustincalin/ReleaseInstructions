using System.Collections.Generic;
using System.ComponentModel;

namespace ReleaseInstructions.Model {
    public class ReleaseTask {
        public string Id { get; set; }
        public string Title { get; set; }
        public BindingList<ReleaseTaskEnvironment> TargetEnvironments { get; set; }
        public string RazorTemplate { get; set; }

        public ReleaseTask() {

        }
    }
}