using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Configurations
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ParentId).IsRequired(false);
            builder.Property(x => x.Target).HasColumnType("nvarchar(50)").IsRequired(false);
            builder.Property(x => x.Image).HasColumnType("nvarchar(100)").IsRequired(false);
            builder.Property(x => x.Sort).IsRequired();
            builder.Property(x => x.Active).IsRequired();
            builder.Property(x => x.CreationDate).HasColumnType("datetime").IsRequired();

            builder
                .HasOne(x => x.ListEntity)
                .WithMany(x => x.Menus)
                .HasForeignKey(x => x.ListId);
        }
    }
}
