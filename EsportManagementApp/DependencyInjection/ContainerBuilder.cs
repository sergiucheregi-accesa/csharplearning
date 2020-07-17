using EsportManagementApp.BusinessLogic;
using EsportManagementApp.Models;
using EsportManagementApp.Services;
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
            container.AddSingleton<IOperations, PlayerOperations>();
            container.AddSingleton<IDataService<Player>>();
            container.AddSingleton<ProgramManager>();

            return container.BuildServiceProvider();
        }
    }
}
