using EntityFrameworkLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkLibrary.DB
{
    public class EsportMgmtDatabaseContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        public EsportMgmtDatabaseContext(DbContextOptions options) : base(options)
        {
        }
    }    
}
