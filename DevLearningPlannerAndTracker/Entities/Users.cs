namespace DevLearningPlannerAndTracker.Entities
{
    public class Users
    {
        string Username { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

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
