using Blog.DataAccess.Concrete.EntityFramework;
using Blog.SqlServer.EntityFrameworkCore.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Infrastructure
{
    public class DbContextFactory : IEntityFrameworkCoreContextFactory
    {
        private readonly BlogContext _blogContext;

        public DbContextFactory(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public DbContext GetDbContext()
        {
            return _blogContext;
        }
    }
}
