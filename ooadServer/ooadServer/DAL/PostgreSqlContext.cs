using Microsoft.EntityFrameworkCore;
using ooadServer.DTO;

namespace ooadServer.DAL
{
    public class PostgreSqlContext : DbContext
    {
        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options) : base(options)
        {
        }

        public DbSet<KHDT> kHDT { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<KHDT>()
                .HasKey("idkhdt");

        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
