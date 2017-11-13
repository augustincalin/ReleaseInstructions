namespace ReleaseInstructions.Model {
    public class Server {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Description { get; set; }
        public Environment ParentEnvironment { get; set; }

        public Server() {

        }
    }
}