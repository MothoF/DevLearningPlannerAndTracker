namespace DevLearningPlannerAndTracker.Entities
{
    public class Modules
    {
        string ModuleCode { get; set; }
        string ModuleName { get; set; }

        public Modules() {
            
        }

        public Modules(string moduleCode, string moduleName)
        {
            ModuleCode = moduleCode;
            ModuleName = moduleName;
        }

    }
}
