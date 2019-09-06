using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Business.Abstract
{
    public interface IClassService
    {
        List<ClassEntity> GetAll();
        ClassEntity Get(Expression<Func<ClassEntity, bool>> filter = null);
        ClassEntity GetById(int classId);
        void Add(ClassEntity classEntity);
        void Update(ClassEntity classEntity);
        void Delete(int classId);
        
    }
}
