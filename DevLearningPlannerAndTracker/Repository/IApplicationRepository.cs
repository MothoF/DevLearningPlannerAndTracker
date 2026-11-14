namespace DevLearningPlannerAndTracker.Repository
{
    using Entities;
    public interface IApplicationRepository
    {
        public Task<ICollection<UserTasks>> getAllTasks(String username);

        public Task<UserTasks> getTask(String username, String conceptId);

        public Task<bool> updateTask(UserTasks updatedTask);

        public Task<bool> deleteTask(String username, String conceptId);

        public Task<UserTasks> addTask(UserTasks task);

        //public Task<bool> deleteTasksEnMasse(String username);
    }
}
