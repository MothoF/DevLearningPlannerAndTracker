namespace DevLearningPlannerAndTracker.Entities
{
    public class UserTasks
    {
        public string Username { get; set; }
        //public List<Users> users { get; set; }
        public Users user;
        public string ConceptId { get; set; }
        //public List<Concepts> concepts { get; set; }
        public Concepts concept;
        public DateTime Deadline { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }

        public UserTasks()
        {

        }

        public UserTasks(string username, string conceptId, DateTime deadline, string status, string priority)
        {
            Username = username;
            ConceptId = conceptId;
            Deadline = deadline;
            Status = status;
            Priority = priority;
        }
    }
}
