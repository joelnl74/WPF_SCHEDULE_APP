using Routine_and_schedule_application.Pages;
using Routine_and_schedule_application.ViewController;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Routine_and_schedule_application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CreateTaskWindow _createTaskWindow;

        public MainWindow(CreateTaskWindow createTaskWindow)
        {
            InitializeComponent();
            _createTaskWindow = createTaskWindow;
            
            var width = Window.GetWindow(this).Width;
            var heigth = Window.GetWindow(this).Width;

            var grid = FindName("task_overview") as Grid;
            var create = FindName("create_button") as Button;

            var taskOverviewController = new TaskViewController();
            taskOverviewController.Configure(grid, (int)width, (int)heigth);

            create_button.Click += OpenCreateWindow;
        }

        private void OpenCreateWindow(object sender, RoutedEventArgs e)
        {
            _createTaskWindow.Show();
        }
    }
}
