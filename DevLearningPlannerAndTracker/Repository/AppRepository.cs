using DevLearningPlannerAndTracker.Entities;

namespace DevLearningPlannerAndTracker.Repository
{
    public class AppRepository : IApplicationRepository
    {
        public Task<bool> deleteTask(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserTasks>> getAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserTasks> getTaskById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> updateTask(UserTasks task)
        {
            throw new NotImplementedException();
        }
    }
}
