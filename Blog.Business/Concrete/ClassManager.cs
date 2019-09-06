using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Business.Concrete
{
    public class ClassManager : IClassService
    {
        public IClassesDal _classesDal;

        public ClassManager(IClassesDal classesDal)
        {
            _classesDal = classesDal;
        }

        public void Add(ClassEntity classEntity)
        {
            _classesDal.Add(classEntity);
        }

        public void Delete(int classId)
        {
            _classesDal.Delete(new ClassEntity { Id = classId });
        }

        public ClassEntity Get(Expression<Func<ClassEntity, bool>> filter = null)
        {
            return _classesDal.Get(filter);
        }

        public List<ClassEntity> GetAll()
        {
            return _classesDal.GetList();
        }


        public ClassEntity GetById(int classId)
        {
            return _classesDal.Get(x => x.Id == classId);
        }

        public void Update(ClassEntity classEntity)
        {
            _classesDal.Update(classEntity);
        }
    }
}
