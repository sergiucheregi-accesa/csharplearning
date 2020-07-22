using EntityFrameworkLibrary.Services;
using EntityFrameworkLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using EntityFrameworkLibrary.DB;

namespace EntityFrameworkLibrary.Services
{
    public class PlayerDataService : GenericDataService<Player>
    {

        public PlayerDataService(EsportMgmtDatabaseContextFactory dbContext) : base(dbContext)
        {

        }
    }
}
