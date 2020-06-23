using EsportManagementApp.BusinessLogic;
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
            container.AddSingleton<IOperations, Operations>();
            container.AddSingleton<ProgramManager>();

            return container.BuildServiceProvider();
        }
    }
}
