using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Configurations
{
    public class BannerConfiguration : IEntityTypeConfiguration<Banner>
    {
        public void Configure(EntityTypeBuilder<Banner> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Active).IsRequired();
            builder.Property(x => x.Target).HasColumnType("nvarchar(50)").IsRequired(false);
            builder.Property(x => x.Height).IsRequired(false);
            builder.Property(x => x.Width).IsRequired(false);
            builder.Property(x => x.CreationDate).HasColumnType("datetime").IsRequired();

            builder
                .HasOne(x => x.ListEntity)
                .WithMany(x => x.Banners)
                .HasForeignKey(x => x.ListId);

        }
    }
}
