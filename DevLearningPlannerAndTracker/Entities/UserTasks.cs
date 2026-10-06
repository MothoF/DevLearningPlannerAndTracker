namespace DevLearningPlannerAndTracker.Entities
{
    public class UserTasks
    {
        public string Username { get; set; }
        public List<Users> user { get; set; }
        public string ConceptId { get; set; }
        public List<Concepts> concept { get; set; }
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
