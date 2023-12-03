using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.DotNet.PlatformAbstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Routine_and_schedule_application.Pages;
using Routine_and_schedule_application.Presenters;

namespace Routine_and_schedule_application
{

    public class DependencyContainer
    {
        public static IHost? AppHost { get; private set; }

        public DependencyContainer()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddSingleton<MainWindow>();
                    services.AddScoped<CreateTaskWindow, CreateTaskWindow>();
                    services.AddTransient<ITaskPresenter, TaskPresenter>();
                })
                .Build();
        }

        public async Task StartUp()
        {
            await AppHost?.StartAsync();
        }
    }
}
