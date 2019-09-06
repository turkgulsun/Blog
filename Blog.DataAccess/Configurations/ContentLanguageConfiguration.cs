using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Configurations
{
    public class ContentLanguageConfiguration : IEntityTypeConfiguration<ContentLanguage>
    {
        public void Configure(EntityTypeBuilder<ContentLanguage> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.Summary).HasColumnType("nvarchar(250)").IsRequired(false);
            builder.Property(x => x.Detail).HasColumnType("ntext").IsRequired();
            builder.Property(x => x.Image).HasColumnType("nvarchar(100)").IsRequired();

            builder
                .HasOne(x => x.Language)
                .WithMany(x => x.ContentLanguages)
                .HasForeignKey(x => x.LanguageId);

            builder
                .HasOne(x => x.Content)
                .WithMany(x => x.Languages)
                .HasForeignKey(x => x.ContentId);
                

        }
    }
}
