
using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace EvApp.Server.Data.Models
{
    public class CountryEntityTypeConfiguration
        : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands");
            builder.HasKey(x => x.Efficeincy);
            builder.Property(x => x.PowerTrain).IsRequired();
        }
    }
}
