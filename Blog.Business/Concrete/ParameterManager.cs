using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;

namespace Blog.Business.Concrete
{
    public class ParameterManager : IParameterService
    {
        public IParameterDal _parameterDal;
        public void Add(Parameter parameter)
        {
            _parameterDal.Add(parameter);
        }

        public void Delete(int parameterId)
        {
            _parameterDal.Delete(new Parameter { Id = parameterId });
        }

        public Parameter Get(Expression<Func<Parameter, bool>> filter = null)
        {
            return _parameterDal.Get(filter);
        }

        public List<Parameter> GetAll()
        {
            return _parameterDal.GetList();
        }

        public void Update(Parameter parameter)
        {
            _parameterDal.Update(parameter);
        }
    }
}
