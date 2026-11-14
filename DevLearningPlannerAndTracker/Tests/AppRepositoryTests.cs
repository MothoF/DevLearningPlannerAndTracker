using DevLearningPlannerAndTracker.Entities;
using DevLearningPlannerAndTracker.Repository;
using Xunit;

namespace DevLearningPlannerAndTracker.Tests
{
    public class AppRepositoryTests
    {
        private IApplicationRepository repository;

        public AppRepositoryTests(IApplicationRepository _repository)
        {
            repository = _repository;
        }


        [Fact]
        public async Task AddTask_OneTask_SuccessfulSave()
        {
            UserTasks userTask = new UserTasks("johnDoe001", "Algo-Lin", new DateTime(new DateOnly(2027, 01, 01), 
                new TimeOnly(23, 59)), "inprogress", "low");

            UserTasks createdTask = await repository.addTask(userTask);

            Assert.NotNull(createdTask);
            Assert.Equal("johnDoe101", createdTask.Username);
        }

        [Fact]
        public async Task UpdateTask_TaskStatus_SucceessfulUpdate()
        {
            UserTasks userTask = new UserTasks("johnDoe001", "Algo-Lin", new DateTime(new DateOnly(2026, 11, 30),
                new TimeOnly(23, 59)), "complete", "medium");

            bool didUpdateSucceed = await repository.updateTask(userTask);

            Assert.True(didUpdateSucceed);
        }
    }
}
