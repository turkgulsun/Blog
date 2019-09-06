using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Business.Abstract
{
    public interface IContentLanguageService
    {
        List<ContentLanguage> GetAll();
        ContentLanguage Get(Expression<Func<ContentLanguage, bool>> filter = null);
        void Add(ContentLanguage contentLanguage);
        void Update(ContentLanguage contentLanguage);
        void Delete(int contentLanguageId);
    }
}
