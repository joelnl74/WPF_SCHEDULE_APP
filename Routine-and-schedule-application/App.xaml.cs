using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Routine_and_schedule_application
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        DependencyContainer _container;

        protected override async void OnStartup(StartupEventArgs e)
        {
            _container = new DependencyContainer();
            await _container.StartUp();

            var mainWindow = DependencyContainer.AppHost.Services.GetRequiredService<MainWindow>();
            mainWindow.Show();

            base.OnStartup(e);
        }
    }
}
