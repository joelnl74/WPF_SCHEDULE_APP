using Microsoft.Extensions.DependencyInjection;
using Routine_and_schedule_application.Presenters;
using Routine_and_schedule_application.ViewController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Routine_and_schedule_application.Pages
{
    /// <summary>
    /// Interaction logic for CreateTaskWindow.xaml
    /// </summary>
    public partial class CreateTaskWindow : Window
    {
        private ITaskPresenter _presenter;

        public CreateTaskWindow()
        {
            _presenter = DependencyContainer.AppHost.Services.GetService<ITaskPresenter>();
            InitializeComponent();

            var create_button = FindName("create_button") as Button;
            create_button.Click += CreateTask;
        }

        private void CreateTask(object sender, RoutedEventArgs e)
        {
            _presenter.Serialize();
            Window.GetWindow(this).Hide();
        }
    }
}
