using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Blog.Business.Abstract
{
    public interface IMetaTagLanguageService
    {
        List<MetaTagLanguage> GetAll();
        MetaTagLanguage Get(Expression<Func<MetaTagLanguage, bool>> filter = null);
        void Add(MetaTagLanguage metaTagLanguage);
        void Update(MetaTagLanguage metaTagLanguage);
        void Delete(int metaTagLanguageId);
    }
}
