using Microsoft.Extensions.DependencyInjection;
using System;
using EsportManagementApp.DependencyInjection;

namespace EsportManagementApp
{
    class Program
    {
        //with IServiceProvider
        public static readonly IServiceProvider ContainerProvider = new ContainerBuilder().Build();

        static void Main(string[] args)
        {
            ////Without IServiceProvider
            //var container = new DependencyContainer();
            //container.AddSingleton<DatabaseRepository>();
            //container.AddSingleton<ProgramManager>();
            //var resolver = new DependencyResolver(container);
            //var programManager = resolver.GetService<ProgramManager>();

            ////With IServiceProvider
            var programManager = ContainerProvider.GetService<ProgramManager>();

            programManager.Run();
        }
    }
}
