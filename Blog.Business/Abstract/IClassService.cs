using Blog.Business.DTOs;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Business.Abstract
{
    public interface IClassService
    {
        List<ClassDTO> GetAll();
        ClassDTO Get(int classId);
        void Add(ClassEntity classEntity, ClassLanguage classLanguage);
        void Update(ClassEntity classEntity, ClassLanguage classLanguage);
        void Delete(ClassEntity classEntity, ClassLanguage classLanguage);
    }
}
