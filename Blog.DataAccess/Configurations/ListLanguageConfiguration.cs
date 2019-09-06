using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Configurations
{
    public class ListLanguageConfiguration : IEntityTypeConfiguration<ListLanguage>
    {
        public void Configure(EntityTypeBuilder<ListLanguage> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Value).HasColumnType("nvarchar(50)").IsRequired();

            builder
                .HasOne(x => x.Language)
                .WithMany(x => x.ListLanguages)
                .HasForeignKey(x => x.LanguageId);

            builder
                .HasOne(x => x.ListEntity)
                .WithMany(x => x.Languages)
                .HasForeignKey(x => x.ListId);
        }
    }
}
