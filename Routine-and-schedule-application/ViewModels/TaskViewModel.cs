namespace Routine_and_schedule_application.ViewModels
{
    public class TaskViewModel
    {
        public long CompletedTimeStamp { get; set; }
        public long RoutineTimeStamps { get; set; }
        public bool Completed { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }

        public TaskViewModel(string name = "", string description = "", string url = "") 
        {
            Name = name;
            Description = description;
            Url = url;
        }
    }
}
