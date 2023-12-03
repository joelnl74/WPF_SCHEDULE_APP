using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Routine_and_schedule_application.Presenters
{
    public interface ITaskPresenter
    {
        void Deserialize();
        void Serialize();
    }
}
