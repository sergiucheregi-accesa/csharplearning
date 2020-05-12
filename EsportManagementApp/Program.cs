using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace EsportManagementApp
{
    class Program 
    {
        static void Main(string[] args)
        {
            var services = ConfigureServices();

            var serviceProvider = services.BuildServiceProvider();

            serviceProvider.GetService<EsportManagementConsoleApp>().Run();

        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddLogging();
            services.AddTransient<EsportManagementConsoleApp>();
            services.AddTransient<ITestService, TestService>();
            services.BuildServiceProvider();
            return services;
        }
    }
}
