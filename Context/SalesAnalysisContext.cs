using Microsoft.EntityFrameworkCore;
using sales_analysis.Entities;

namespace sales_analysis.Context
{
    public class SalesAnalysisContext : DbContext
    {
        public DbSet<Location> locations { get; set; }
        public DbSet<SalesRecord> sales_records { get; set; }
        public SalesAnalysisContext(DbContextOptions<SalesAnalysisContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.DataSeed();
        }
    }
}
