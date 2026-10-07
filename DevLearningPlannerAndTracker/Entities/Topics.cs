namespace DevLearningPlannerAndTracker.Entities
{
    public class Topics
    {
        public int TopicId { get; set; }
        public string ModuleCode { get; set; }
        //public List<Modules> topicModules { get; set; }
        public Modules topicModule { get; set; }
        public List<Concepts> topicConcepts { get; set; }
        public string TopicName { get; set; }

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
