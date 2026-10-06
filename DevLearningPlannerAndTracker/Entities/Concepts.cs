namespace DevLearningPlannerAndTracker.Entities
{
    public class Concepts
    {
        public string ConceptId { get; set; }
        public string ModuleCode { get; set; }
        public int TopicId { get; set; }

        public List<Topics> conceptTopics { get; set; }
        public string ConceptName { get; set; }

        public Concepts()
        {

        }

        public Concepts(string conceptId, string moduleCode, int topicId, string conceptName)
        {
            ConceptId = conceptId;
            ModuleCode = moduleCode;
            TopicId = topicId;
            ConceptName = conceptName;
        }
    }
}
