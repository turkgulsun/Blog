using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Blog.Business.Abstract
{
    public interface IMenuService
    {
        List<Menu> GetAll();
        Menu Get(Expression<Func<Menu, bool>> filter = null);
        void Add(Menu menu);
        void Update(Menu menu);
        void Delete(int menuId);
    }
}
