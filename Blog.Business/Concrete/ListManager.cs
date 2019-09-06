using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;

namespace Blog.Business.Concrete
{
    public class ListManager : IListService
    {
        public IListDal _listDal;
        public void Add(ListEntity listEntity)
        {
            _listDal.Add(listEntity);
        }

        public void Delete(int listId)
        {
            _listDal.Delete(new ListEntity { Id = listId });
        }

        public ListEntity Get(Expression<Func<ListEntity, bool>> filter = null)
        {
            return _listDal.Get(filter);
        }

        public List<ListEntity> GetAll()
        {
            return _listDal.GetList();
        }

        public void Update(ListEntity listEntity)
        {
            _listDal.Update(listEntity);
        }
    }
}
