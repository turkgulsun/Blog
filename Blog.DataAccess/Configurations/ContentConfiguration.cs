using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Configurations
{
    public class ContentConfiguration : IEntityTypeConfiguration<Content>
    {
        public void Configure(EntityTypeBuilder<Content> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Sort).IsRequired();
            builder.Property(x => x.Active).IsRequired();
            builder.Property(x => x.CreationDate).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.DeletionDate).HasColumnType("datetime").IsRequired(false);
            builder.Property(x => x.UpdateDate).HasColumnType("datetime").IsRequired(false);

            builder
                .HasOne(x => x.ClassEntity)
                .WithMany(x => x.Contents)
                .HasForeignKey(x => x.ClassId);

        }
    }
}
