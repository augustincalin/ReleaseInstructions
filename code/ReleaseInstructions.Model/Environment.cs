using System.ComponentModel;

namespace ReleaseInstructions.Model { 
    public class Environment {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        public BindingList<Server> Servers { get; set; }

        public Environment() {

        }
    }
}