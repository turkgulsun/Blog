using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Configurations
{
    public class MenuLanguageConfiguration : IEntityTypeConfiguration<MenuLanguage>
    {
        public void Configure(EntityTypeBuilder<MenuLanguage> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.Url).HasColumnType("nvarchar(100)").IsRequired(false);

            builder
                .HasOne(x => x.Menu)
                .WithMany(x => x.Languages)
                .HasForeignKey(x => x.MenuId);

            builder
                .HasOne(x => x.Language)
                .WithMany(x => x.MenuLanguages)
                .HasForeignKey(x => x.LanguageId);
        }
    }
}
