namespace DevLearningPlannerAndTracker.Entities
{
    public class Modules
    {
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public List<Topics> moduleTopics { get; set; }

        public Modules() {
            
        }

        public Modules(string moduleCode, string moduleName)
        {
            ModuleCode = moduleCode;
            ModuleName = moduleName;
        }

    }
}
