using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;

namespace Blog.Business.Concrete
{
    public class MenuLanguageManager : IMenuLanguageService
    {
        public IMenuLanguageDal _menuLanguageDal;
        public void Add(MenuLanguage menuLanguage)
        {
            _menuLanguageDal.Add(menuLanguage);
        }

        public void Delete(int menulanguageId)
        {
            _menuLanguageDal.Delete(new MenuLanguage { Id = menulanguageId });
        }

        public MenuLanguage Get(Expression<Func<MenuLanguage, bool>> filter = null)
        {
            return _menuLanguageDal.Get(filter);
        }

        public List<MenuLanguage> GetAll()
        {
            return _menuLanguageDal.GetList();
        }

        public void Update(MenuLanguage menuLanguage)
        {
            _menuLanguageDal.Update(menuLanguage);
        }
    }
}
