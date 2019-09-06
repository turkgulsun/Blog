using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;

namespace Blog.Business.Concrete
{
    public class ContentLanguageManager : IContentLanguageService
    {
        public IContentLanguageDal _contentLanguageDal;

        public ContentLanguageManager(IContentLanguageDal contentLanguageDal)
        {
            _contentLanguageDal = contentLanguageDal;
        }

        public void Add(ContentLanguage contentLanguage)
        {
            _contentLanguageDal.Add(contentLanguage);
        }

        public void Delete(int contentLanguageId)
        {
            _contentLanguageDal.Delete(new ContentLanguage { Id = contentLanguageId });
        }

        public ContentLanguage Get(Expression<Func<ContentLanguage, bool>> filter = null)
        {
            return _contentLanguageDal.Get(filter);
        }

        public List<ContentLanguage> GetAll()
        {
            return _contentLanguageDal.GetList();
        }

        public void Update(ContentLanguage contentLanguage)
        {
            _contentLanguageDal.Update(contentLanguage);
        }
    }
}
