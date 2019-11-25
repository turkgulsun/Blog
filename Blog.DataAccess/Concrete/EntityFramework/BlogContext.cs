﻿using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Concrete.EntityFramework
{
    public class BlogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=DMGM0341311;Initial Catalog=BlogContext;User ID=sa;Password=dm8862.");
            optionsBuilder.UseSqlServer("Server = constant-system-237714:us-central1:sqlserver01; Initial Catalog = Blog; Persist Security Info = False; User ID = BlogUser; Password = tt8862.; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
        }

        public DbSet<ClassEntity> Classes { get; set; }
        public DbSet<ClassLanguage> ClassLanguages { get; set; }
        public DbSet<ClassType> ClassTypes { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<ContentLanguage> ContentLanguages{ get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<BannerLanguage> BannerLanguages { get; set; }
        public DbSet<ListEntity> Lists { get; set; }
        public DbSet<ListLanguage> ListLanguages { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuLanguage> MenuLanguages { get; set; }
        public DbSet<MetaTag> MetaTags { get; set; }
        public DbSet<MetaTagLanguage> MetaTagLanguages { get; set; }
        public DbSet<Parameter> Parameters { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration<ClassTypeConfiguration>();

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
