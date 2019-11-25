using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.DataAccess.Configurations
{
    public class ClassConfiguraion : IEntityTypeConfiguration<ClassEntity>
    {
        public void Configure(EntityTypeBuilder<ClassEntity> builder)
        {
            builder.ToTable("Class");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ParentId).IsRequired();
            builder.Property(x => x.Sort).IsRequired();
            builder.Property(x => x.Active).IsRequired();
            builder.Property(x => x.Image).IsRequired(false);
            builder.Property(x => x.CreationDate).HasColumnType("datetime").IsRequired();

            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.DeletionDate).HasColumnType("datetime").IsRequired(false);

            builder
                .HasOne(x => x.ClassType)
                .WithMany(x => x.Classes)
                .HasForeignKey(x => x.ClassTypeId);
        }
    }
}
