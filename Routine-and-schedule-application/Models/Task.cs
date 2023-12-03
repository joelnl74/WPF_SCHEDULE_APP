using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Routine_and_schedule_application.Models
{
    public class Task
    {
        public int Id { get; set; }
        public long CompletedTimeStamp { get; set; }
        public long RoutineTimeStamps { get; set; }
        public bool Completed { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; }
        public string Url { get; set; }

        public Task()
        {
            Name = "default";
        }
    }
}
