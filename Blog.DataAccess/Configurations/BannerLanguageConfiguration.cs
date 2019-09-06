using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Configurations
{
    public class BannerLanguageConfiguration : IEntityTypeConfiguration<BannerLanguage>
    {
        public void Configure(EntityTypeBuilder<BannerLanguage> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.Summary).HasColumnType("nvarchar(150)").IsRequired(false);
            builder.Property(x => x.Url).HasColumnType("nvarchar(100)").IsRequired(false);


            builder
                .HasOne(x => x.Banner)
                .WithMany(x => x.Languages)
                .HasForeignKey(x => x.BannerId);

            builder
                .HasOne(x => x.Language)
                .WithMany(x => x.BannerLanguages)
                .HasForeignKey(x => x.LanguageId);
        }
    }
}
