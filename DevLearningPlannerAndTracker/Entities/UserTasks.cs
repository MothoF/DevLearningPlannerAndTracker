namespace DevLearningPlannerAndTracker.Entities
{
    public class UserTasks
    {
        string Username { get; set; }
        List<Users> user;
        string ConceptId { get; set; }
        List<Concepts> concept;
        DateTime Deadline { get; set; }
        string Status { get; set; }
        string Priority { get; set; }

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
