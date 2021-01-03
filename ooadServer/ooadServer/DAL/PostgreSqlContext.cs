using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ooadServer.DTO;

namespace ooadServer.DAL
{
    public class PostgreSqlContext : DbContext
    {
        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options) : base(options)
        {
        }

        public DbSet<KHDT> kHDT { get; set; }
        public DbSet<KHOA> khoa { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<KHDT>()
                .HasKey("idkhdt");
            builder.Entity<KHOA>()
                .HasKey("idkhoa");
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
