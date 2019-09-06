using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Business.Abstract
{
    public interface IClassTypeService
    {
        List<ClassType> GetAll();
        ClassType Get(Expression<Func<ClassType, bool>> filter = null);
    }
}
