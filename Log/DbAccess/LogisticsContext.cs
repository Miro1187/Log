using DbAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Logistics
{
    public class LogisticsContext : DbContext
    {
        public LogisticsContext(DbContextOptions<LogisticsContext> options) : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Rout> Routes { get; set; }
        public DbSet<LogisticsCenter> LogisticsCenters { get; set; }
    }
}