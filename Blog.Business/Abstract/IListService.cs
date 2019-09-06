using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Business.Abstract
{
    public interface IListService
    {
        List<ListEntity> GetAll();
        ListEntity Get(Expression<Func<ListEntity, bool>> filter = null);
        void Add(ListEntity listEntity);
        void Update(ListEntity listEntity);
        void Delete(int listId);
    }
}
