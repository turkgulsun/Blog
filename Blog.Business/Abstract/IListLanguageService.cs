using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Business.Abstract
{
    public interface IListLanguageService
    {
        List<ListLanguage> GetAll();
        ListLanguage Get(Expression<Func<ListLanguage, bool>> filter = null);
        void Add(ListLanguage listLanguage);
        void Update(ListLanguage listLanguage);
        void Delete(int listLanguageId);
    }
}
