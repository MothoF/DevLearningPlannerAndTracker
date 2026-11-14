using DevLearningPlannerAndTracker.Entities;

namespace DevLearningPlannerAndTracker.Repository
{
    public class AppRepository : IApplicationRepository
    {
        public Task<bool> deleteTask(String username, String conceptId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<UserTasks>> getAllTasks(String username)
        {
            throw new NotImplementedException();
        }

        public Task<UserTasks> getTask(String username, String conceptId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> updateTask(UserTasks task)
        {
            throw new NotImplementedException();
        }

        public Task<UserTasks> addTask(UserTasks task)
        {
            throw new NotImplementedException();
        }
    }
}
