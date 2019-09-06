using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Business.Abstract
{
    public interface IClassLanguageService
    {
        List<ClassLanguage> GetAll();
        ClassLanguage Get(Expression<Func<ClassLanguage, bool>> filter = null);
        void Add(ClassLanguage classLanguage);
        void Update(ClassLanguage classLanguage);
        void Delete(int classLanguageId);
    }
}
