﻿// <auto-generated />
using System;
using Blog.DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blog.DataAccess.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blog.Entities.Concrete.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("Height");

                    b.Property<int>("ListId");

                    b.Property<int>("Sort");

                    b.Property<string>("Target")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Width");

                    b.HasKey("Id");

                    b.HasIndex("ListId");

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.BannerLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BannerId");

                    b.Property<string>("Image");

                    b.Property<int>("LanguageId");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("BannerId");

                    b.HasIndex("LanguageId");

                    b.ToTable("BannerLanguages");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.ClassEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<int>("ClassTypeId");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("Sort");

                    b.HasKey("Id");

                    b.HasIndex("ClassTypeId");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.ClassLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassId");

                    b.Property<int>("LanguageId");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("LanguageId");

                    b.ToTable("ClassLanguages");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.ClassType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("ClassTypes");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<int>("ClassId");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("Sort");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.ContentLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContentId");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("LanguageId");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ContentId");

                    b.HasIndex("LanguageId");

                    b.ToTable("ContentLanguages");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Culture")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.ListEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Sort");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("List");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.ListLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LanguageId");

                    b.Property<int>("ListId");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("ListId");

                    b.ToTable("ListLanguages");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ListId");

                    b.Property<int?>("ParentId");

                    b.Property<int>("Sort");

                    b.Property<string>("Target")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ListId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.MenuLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LanguageId");

                    b.Property<int>("MenuId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("MenuId");

                    b.ToTable("MenuLanguages");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.MetaTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Page")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("MetaTags");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.MetaTagLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descriptions")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Keywords")
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("LanguageId");

                    b.Property<int>("MetaTagId");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("MetaTagId");

                    b.ToTable("MetaTagLanguages");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.Parameter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Parameters");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.Banner", b =>
                {
                    b.HasOne("Blog.Entities.Concrete.ListEntity", "ListEntity")
                        .WithMany("Banners")
                        .HasForeignKey("ListId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blog.Entities.Concrete.BannerLanguage", b =>
                {
                    b.HasOne("Blog.Entities.Concrete.Banner", "Banner")
                        .WithMany("Languages")
                        .HasForeignKey("BannerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blog.Entities.Concrete.Language", "Language")
                        .WithMany("BannerLanguages")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blog.Entities.Concrete.ClassEntity", b =>
                {
                    b.HasOne("Blog.Entities.Concrete.ClassType", "ClassType")
                        .WithMany("Classes")
                        .HasForeignKey("ClassTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blog.Entities.Concrete.ClassLanguage", b =>
                {
                    b.HasOne("Blog.Entities.Concrete.ClassEntity", "ClassEntity")
                        .WithMany("Languages")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blog.Entities.Concrete.Language", "Language")
                        .WithMany("ClassLanguages")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blog.Entities.Concrete.Content", b =>
                {
                    b.HasOne("Blog.Entities.Concrete.ClassEntity", "ClassEntity")
                        .WithMany("Contents")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blog.Entities.Concrete.ContentLanguage", b =>
                {
                    b.HasOne("Blog.Entities.Concrete.Content", "Content")
                        .WithMany("Languages")
                        .HasForeignKey("ContentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blog.Entities.Concrete.Language", "Language")
                        .WithMany("ContentLanguages")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blog.Entities.Concrete.ListLanguage", b =>
                {
                    b.HasOne("Blog.Entities.Concrete.Language", "Language")
                        .WithMany("ListLanguages")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blog.Entities.Concrete.ListEntity", "ListEntity")
                        .WithMany("Languages")
                        .HasForeignKey("ListId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blog.Entities.Concrete.Menu", b =>
                {
                    b.HasOne("Blog.Entities.Concrete.ListEntity", "ListEntity")
                        .WithMany("Menus")
                        .HasForeignKey("ListId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blog.Entities.Concrete.MenuLanguage", b =>
                {
                    b.HasOne("Blog.Entities.Concrete.Language", "Language")
                        .WithMany("MenuLanguages")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blog.Entities.Concrete.Menu", "Menu")
                        .WithMany("Languages")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Blog.Entities.Concrete.MetaTagLanguage", b =>
                {
                    b.HasOne("Blog.Entities.Concrete.Language", "Language")
                        .WithMany("MetaTagLanguages")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Blog.Entities.Concrete.MetaTag", "MetaTag")
                        .WithMany("Languages")
                        .HasForeignKey("MetaTagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}