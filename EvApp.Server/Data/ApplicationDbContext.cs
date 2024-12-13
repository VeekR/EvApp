
using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;
using EvApp.Server.Data.Models;
namespace EvApp.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base()
        {
        }
        public ApplicationDbContext(DbContextOptions options)
         : base(options)
        {
        }
        public DbSet<Model> models => Set<Model>();
        public DbSet<Brand> brands=> Set<Brand>();
    }
}
