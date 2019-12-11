using Blog.Entities.Concrete;
using Blog.SqlServer.EntityFrameworkCore.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Abstract
{
    public interface IClassLanguageRepository : IEntityFrameworkCoreRepository<ClassLanguage>
    {
    }
}
