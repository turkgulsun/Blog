using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Configurations
{
    public class ParameterConfiguration : IEntityTypeConfiguration<Parameter>
    {
        public void Configure(EntityTypeBuilder<Parameter> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).HasColumnType("nvarchar(50)").IsRequired(false);
            builder.Property(x => x.Value).HasColumnType("nvarchar(250)").IsRequired(false);
        }
    }
}
