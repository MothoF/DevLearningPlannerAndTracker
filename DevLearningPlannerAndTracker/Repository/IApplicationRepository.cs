namespace DevLearningPlannerAndTracker.Repository
{
    using Entities;
    public interface IApplicationRepository
    {
        public Task<ICollection<UserTasks>> getAll();

        public Task<UserTasks> getTaskById(int id);

        public Task<bool> updateTask(UserTasks task);

        public Task<bool> deleteTask(int id);

        public Task<UserTasks> addTask(UserTasks task);
    }
}
