using EntityFrameworkLibrary.DB;
using EsportManagementApp.BusinessLogic;
using EntityFrameworkLibrary.Services;
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
            container.AddSingleton<IPlayerOperations, PlayerOperations>();
            container.AddSingleton<EsportMgmtDatabaseContextFactory>();
            container.AddSingleton<PlayerDataService>();
            container.AddSingleton<ProgramManager>();

            return container.BuildServiceProvider();
        }
    }
}
