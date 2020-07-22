using Microsoft.Extensions.DependencyInjection;
using System;
using EsportManagementApp.DependencyInjection;

namespace EsportManagementApp
{
    class Program
    {
        public static readonly IServiceProvider ContainerProvider = new ContainerBuilder().Build();

        static void Main()
        {
            var programManager = ContainerProvider.GetService<ProgramManager>();

            programManager.Run();
        }
    }
}
