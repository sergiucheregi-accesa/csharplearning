using EsportManagementApp.BusinessLogic;
using EsportManagementApp.Database;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace EsportManagementApp.DependencyInjection
{
    public class ContainerBuilder
    {
        public IServiceProvider Build()
        {
            var container = new ServiceCollection();
            container.AddSingleton<IDatabaseRepository, DatabaseRepository>();
            container.AddSingleton<IOperations, Operations>();
            container.AddSingleton<ProgramManager>();

            return container.BuildServiceProvider();
        }
    }
}
