namespace DevLearningPlannerAndTracker.Entities
{
    public class Topics
    {
        int TopicId { get; set; }
        string ModuleCode { get; set; }
        List<Modules> topicModules { get; set; }
        string TopicName { get; set; }

        public Topics()
        {

        }

        public Topics(int topicId, string moduleCode, string topicName)
        {
            TopicId = topicId;
            ModuleCode = moduleCode;
            TopicName = topicName;
        }

    }
}
