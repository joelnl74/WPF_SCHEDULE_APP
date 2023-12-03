using Routine_and_schedule_application.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Routine_and_schedule_application.ViewController
{
    public class CreateTaskViewController
    {
        private ITaskPresenter _taskPresenter;
        
        CreateTaskViewController(ITaskPresenter taskPresenter) 
        {
            _taskPresenter = taskPresenter;
        }
    }
}
