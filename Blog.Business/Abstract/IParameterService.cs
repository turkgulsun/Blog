using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Blog.Business.Abstract
{
    public interface IParameterService
    {
        List<Parameter> GetAll();
        Parameter Get(Expression<Func<Parameter, bool>> filter = null);
        void Add(Parameter parameter);
        void Update(Parameter parameter);
        void Delete(int parameterId);
    }
}
