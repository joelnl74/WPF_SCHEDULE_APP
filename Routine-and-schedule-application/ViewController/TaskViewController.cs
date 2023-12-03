using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Routine_and_schedule_application.ViewController
{
    public class TaskViewController
    {
        public void Configure(Grid grid, int width, int heigth)
        {

            grid.ShowGridLines = true;

            for (var i = 0; i < 10 / 2; i++)
            {
                RowDefinition rowDefinition = new RowDefinition();
                grid.RowDefinitions.Add(rowDefinition);
            }

            var row = 0;

            for (var i = 0; i < 10; i++)
            {
                var column = i % 2;

                if (i % 2 == 0 && i > 1)
                {
                    row++;
                }

                var view = new TaskOverView(i, (int)width, row, column, grid);
            }
        }
    }
}
