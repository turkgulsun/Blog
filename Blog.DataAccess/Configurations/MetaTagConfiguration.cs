using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Configurations
{
    public class MetaTagConfiguration : IEntityTypeConfiguration<MetaTag>
    {
        public void Configure(EntityTypeBuilder<MetaTag> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Page).HasColumnType("nvarchar(50)").IsRequired(false);
            builder.Property(x => x.CreationDate).HasColumnType("datetime").IsRequired();


        }
    }
}
