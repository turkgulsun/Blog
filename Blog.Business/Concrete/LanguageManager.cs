using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;

namespace Blog.Business.Concrete
{
    public class LanguageManager : IListLanguageService
    {
        public IListLanguageDal _listLanguageDal;

        public LanguageManager(IListLanguageDal listLanguage)
        {
            _listLanguageDal = listLanguage;
        }

        public void Add(ListLanguage listLanguage)
        {
            _listLanguageDal.Add(listLanguage);
        }

        public void Delete(int listLanguageId)
        {
            _listLanguageDal.Delete(new ListLanguage { Id = listLanguageId });
        }

        public ListLanguage Get(Expression<Func<ListLanguage, bool>> filter = null)
        {
            return _listLanguageDal.Get(filter);
        }

        public List<ListLanguage> GetAll()
        {
            return _listLanguageDal.GetList();
        }

        public void Update(ListLanguage listLanguage)
        {
            _listLanguageDal.Update(listLanguage);
        }
    }
}
