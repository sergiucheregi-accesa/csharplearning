using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkLibrary.DB
{
    public class EsportMgmtDatabaseContextFactory : IDesignTimeDbContextFactory<EsportMgmtDatabaseContext>
    {
        public EsportMgmtDatabaseContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<EsportMgmtDatabaseContext>();
            options.UseSqlite(@"Data Source=C:\ReposLearning\csharplearning\EF\DB\EsportMgmtDatabase.db");

            return new EsportMgmtDatabaseContext(options.Options);
        }
    }
}
