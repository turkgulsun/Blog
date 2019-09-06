using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Configurations
{
    public class MetaTagLanguageConfiguration : IEntityTypeConfiguration<MetaTagLanguage>
    {
        public void Configure(EntityTypeBuilder<MetaTagLanguage> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).HasColumnType("nvarchar(100)").IsRequired(false);
            builder.Property(x => x.Keywords).HasColumnType("nvarchar(250)").IsRequired(false);
            builder.Property(x => x.Descriptions).HasColumnType("nvarchar(250)").IsRequired(false);

            builder
                .HasOne(x => x.MetaTag)
                .WithMany(x => x.Languages)
                .HasForeignKey(x => x.MetaTagId);


            builder
                .HasOne(x => x.Language)
                .WithMany(x => x.MetaTagLanguages)
                .HasForeignKey(x => x.LanguageId);

        }
    }
}
