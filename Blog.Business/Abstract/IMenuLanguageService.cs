using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Blog.Business.Abstract
{
    public interface IMenuLanguageService
    {
        List<MenuLanguage> GetAll();
        MenuLanguage Get(Expression<Func<MenuLanguage, bool>> filter = null);
        void Add(MenuLanguage menuLanguage);
        void Update(MenuLanguage menuLanguage);
        void Delete(int menulanguageId);
    }
}
