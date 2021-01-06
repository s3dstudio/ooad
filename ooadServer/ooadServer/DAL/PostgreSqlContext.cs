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

        public DbSet<KHDT> khdt { get; set; }
        public DbSet<KHOA> khoa { get; set; }
        public DbSet<CHUYENNGANH> chuyennganh { get; set; }
        public DbSet<GIANGVIEN> giangvien { get; set; }
        public DbSet<CHUCNANG> chucnang { get; set; }
        public DbSet<HEDAOTAO> hedaotao { get; set; }
        public DbSet<HOCPHAN> hocphan { get; set; }
        public DbSet<HOPDONG> hopdong { get; set; }
        public DbSet<LOAIHINHDT> loaihinhdt { get; set; }
        public DbSet<NHOMLOP> nhomlop { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<KHDT>()
                .HasKey("idkhdt");
            builder.Entity<KHOA>()
                .HasKey("idkhoa");
            builder.Entity<CHUYENNGANH>()
                .HasKey("idchuyennganh");
            builder.Entity<GIANGVIEN>()
                .HasKey("idgiangvien");
            builder.Entity<CHUCNANG>()
                .HasKey("idchucnang");
            builder.Entity<HEDAOTAO>()
                .HasKey("idhedaotao");
            builder.Entity<HOCPHAN>()
                .HasKey("idhocphan");
            builder.Entity<HOPDONG>()
                .HasKey("idhopdong");
            builder.Entity<LOAIHINHDT>()
                .HasKey("idlhdt");
            builder.Entity<NHOMLOP>()
                .HasKey("idnhomlop");
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
