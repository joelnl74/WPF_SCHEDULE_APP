using Newtonsoft.Json;
using Routine_and_schedule_application.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Routine_and_schedule_application.Presenters
{
    public class TaskPresenter : ITaskPresenter
    {
        private List<TaskViewModel> _tasks = new List<TaskViewModel>();

        public TaskPresenter()
        {
            Deserialize();
        }

        public async void Serialize()
        {
            var serializer = Newtonsoft.Json.JsonSerializer.Create();

            AddTask(new TaskViewModel { Name = "Wanikani" });
            AddTask(new TaskViewModel { Name = "Renshuu" });
            
            var result = JsonConvert.SerializeObject(_tasks, Formatting.Indented);
            var path = "";

            if (File.Exists("../Resources/task.json") == false)
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog1.FileName;
                }
            }
            
            StreamWriter outputFile = new(path);
            outputFile.WriteLine(result);
            outputFile.Close();
        }

        public void Deserialize()
        {
            var serializer = Newtonsoft.Json.JsonSerializer.Create();
            var result = JsonConvert.SerializeObject(_tasks);
            var path = "";

            if (File.Exists("../Resources/task.json") == false)
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog1.FileName;
                }
            }

            StreamReader sr = new StreamReader(path);
            string json = sr.ReadToEnd();
            sr.Close();

            if (string.IsNullOrEmpty(json))
            {
                _tasks = new List<TaskViewModel>();

                return;
            }

            _tasks = JsonConvert.DeserializeObject<List<TaskViewModel>>(json);
        }

        public void AddTask(TaskViewModel taskViewModel)
        {
            _tasks.Add(taskViewModel);
        }
    }
}
