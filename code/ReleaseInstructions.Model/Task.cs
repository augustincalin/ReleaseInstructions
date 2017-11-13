namespace ReleaseInstructions.Model {
    public class Task {
        public int Id { get; set; }
        public string Detail { get; set; }
        public bool IsBusinessTask { get; set; }
        public string Developer { get; set; }

        public Task() {

        }
    }
}