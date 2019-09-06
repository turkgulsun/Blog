using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Configurations
{
    public class ClassTypeConfiguration : IEntityTypeConfiguration<ClassType>
    {
        public void Configure(EntityTypeBuilder<ClassType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Type).HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(x => x.Description).HasColumnType("nvarchar(100)").IsRequired(false);
        }
    }
}
