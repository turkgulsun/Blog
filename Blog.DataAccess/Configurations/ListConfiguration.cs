using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Configurations
{
    public class ListConfiguration : IEntityTypeConfiguration<ListEntity>
    {
        public void Configure(EntityTypeBuilder<ListEntity> builder)
        {
            builder.ToTable("List");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Type).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.Sort).IsRequired();

        }
    }
}
