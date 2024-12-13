
using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;
using EvApp.Server.Data.Models;

namespace EvApp.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Default constructor
        public ApplicationDbContext() : base()
        {
        }

        // Constructor with DbContext options
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets
        public DbSet<Model> Models => Set<Model>();
        public DbSet<Brand> Brands => Set<Brand>();

        // OnModelCreating method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Model entity
            modelBuilder.Entity<Model>().ToTable("Models");
            modelBuilder.Entity<Model>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Model>()
                .Property(x => x.Id).IsRequired();
            modelBuilder.Entity<Model>()
                .Property(x => x.TopSpeed).HasColumnType("decimal(7,4)");
            modelBuilder.Entity<Model>()
                .Property(x => x.MileRange).HasColumnType("decimal(7,4)");

            // Configure Brand entity
            modelBuilder.Entity<Brand>().ToTable("Brands");
            modelBuilder.Entity<Brand>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Brand>()
                .Property(x => x.Id).IsRequired();

            // Configure relationship between Model and Brand
            modelBuilder.Entity<Model>()
                .HasOne(x => x.brand)
                .WithMany(y => y.models)
                .HasForeignKey(x => x.BrandId);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
