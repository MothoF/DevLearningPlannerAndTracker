namespace DevLearningPlannerAndTracker.Entities
{
    public class Users
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<UserTasks> userTasks { get; set; }

        public Users()
        {

        }

        public Users(string username, string firstName, string lastName)
        {
            Username = username;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
