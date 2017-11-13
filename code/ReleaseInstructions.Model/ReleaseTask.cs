using System.Collections.Generic;
using System.ComponentModel;

namespace ReleaseInstructions.Model {
    public class ReleaseTask {
        public int Id { get; set; }
        public string Title { get; set; }
        public BindingList<TargetEnvironment> TargetEnvironments { get; set; }
        public BindingList<Component> DeploysComponents { get; set; }
        public string RazorTemplate { get; set; }

        public ReleaseTask() {

        }
    }
}