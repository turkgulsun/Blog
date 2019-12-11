using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;
using Blog.SqlServer.EntityFrameworkCore;
using Blog.SqlServer.EntityFrameworkCore.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Concrete.EntityFramework
{
    public class ClassLanguageRepository : EntityFrameworkCoreRepository<ClassLanguage>, IClassLanguageRepository
    {
        public ClassLanguageRepository(IEntityFrameworkCoreContextFactory dbContextFactory) : base(dbContextFactory)
        {
        }
    }
}
