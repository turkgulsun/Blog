using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Business.Abstract
{
    public interface ILanguageService
    {
        List<Language> GetAll();
        Language Get(Expression<Func<Language, bool>> filter = null);
        Language GetById(int languageId);
        void Add(Language language);
        void Update(Language language);
        void Delete(int languageId);
    }
}
