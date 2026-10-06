namespace DevLearningPlannerAndTracker.Entities
{
    public class Concepts
    {
        string ConceptId { get; set; }
        string ModuleCode { get; set; }
        int TopicId { get; set; }

        List<Topics> conceptTopics { get; set; }
        string ConceptName { get; set; }

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
