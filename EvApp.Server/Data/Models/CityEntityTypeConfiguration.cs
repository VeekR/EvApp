

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    namespace EvApp.Server.Data.Models
    {
        public class CityEntityTypeConfiguration
            : IEntityTypeConfiguration<Model>
        {
            public void Configure(EntityTypeBuilder<Model> builder)
            {
                builder.ToTable("models");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id).IsRequired();
                builder
                    .HasOne(x => x.brand)
                    .WithMany(x => x.models)
                    .HasForeignKey(x => x.BrandId);
                builder.Property(x => x.TopSpeed).HasColumnType("decimal(7,4)");
                builder.Property(x => x.MileRange).HasColumnType("decimal(7,4)");
            }
        }
    }
