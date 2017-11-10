namespace ReleaseInstructions.Model {
    public class Server {
        public string Name { get; set; }
        public string Role { get; set; }
        public string Description { get; set; }
        public Environment Environment { get; set; }

        public Server() {

        }
    }
}