using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;

namespace Blog.Business.Concrete
{
    public class ClassTypeManager : IClassTypeService
    {
        public IClassTypeDal _classTypeDal;

        public ClassType Get(Expression<Func<ClassType, bool>> filter = null)
        {
            return _classTypeDal.Get(filter);
        }

        public List<ClassType> GetAll()
        {
            return _classTypeDal.GetList();
        }
    }
}
