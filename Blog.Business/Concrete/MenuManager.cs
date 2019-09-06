using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;

namespace Blog.Business.Concrete
{
    public class MenuManager : IMenuService
    {
        public IMenuDal _menuDal;
        public void Add(Menu menu)
        {
            _menuDal.Add(menu);
        }

        public void Delete(int menuId)
        {
            _menuDal.Delete(new Menu { Id = menuId });
        }

        public Menu Get(Expression<Func<Menu, bool>> filter = null)
        {
            return _menuDal.Get(filter);
        }

        public List<Menu> GetAll()
        {
            return _menuDal.GetList();
        }

        public void Update(Menu menu)
        {
            _menuDal.Update(menu);
        }
    }
}
