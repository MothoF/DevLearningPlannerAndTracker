namespace DevLearningPlannerAndTracker.Entities
{
    public class Topics
    {
        string TopicId { get; set; }
        string ModuleCode { get; set; }
        List<Modules> topicModules { get; set; }
        string TopicName { get; set; }

    }
}
