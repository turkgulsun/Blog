using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;

namespace Blog.Business.Concrete
{
    public class MetaTagLanguageManager : IMetaTagLanguageService
    {
        public IMetaTagLanguageDal _metaTagLanguageDal;
        public void Add(MetaTagLanguage metaTagLanguage)
        {
            _metaTagLanguageDal.Add(metaTagLanguage);
        }

        public void Delete(int metaTagLanguageId)
        {
            _metaTagLanguageDal.Delete(new MetaTagLanguage { Id = metaTagLanguageId });
        }

        public MetaTagLanguage Get(Expression<Func<MetaTagLanguage, bool>> filter = null)
        {
            return _metaTagLanguageDal.Get(filter);
        }

        public List<MetaTagLanguage> GetAll()
        {
            return _metaTagLanguageDal.GetList();
        }

        public void Update(MetaTagLanguage metaTagLanguage)
        {
            _metaTagLanguageDal.Update(metaTagLanguage);
        }
    }
}
