using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.DataAccess.Configurations
{
    public class ClassLanguageConfiguration : IEntityTypeConfiguration<ClassLanguage>
    {
        public void Configure(EntityTypeBuilder<ClassLanguage> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.Summary).HasColumnType("nvarchar(250)").IsRequired(false);
            builder.Property(x => x.MetaTitle).HasColumnType("nvarchar(250)").IsRequired(false);
            builder.Property(x => x.MetaKeywords).HasColumnType("nvarchar(Max)").IsRequired(false);
            builder.Property(x => x.MetaDescription).HasColumnType("nvarchar(Max)").IsRequired(false);

            builder
                .HasOne(x => x.ClassEntity)
                .WithMany(x => x.Languages)
                .HasForeignKey(x => x.ClassId);

            builder
                .HasOne(x => x.Language)
                .WithMany(x => x.ClassLanguages)
                .HasForeignKey(x => x.LanguageId);
        }
    }
}
