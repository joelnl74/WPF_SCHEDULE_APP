using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Routine_and_schedule_application.Mapper
{
    interface ITaskViewModelMapper
    {
        void Map(Task task);
        void MapMany(List<Task> tasks);
    }
}
