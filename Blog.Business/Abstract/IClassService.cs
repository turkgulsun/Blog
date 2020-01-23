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
        ClassDTO GetById(int classId);
        void Add(ClassDTO classDTO);
        void Update(ClassDTO classDTO);
        void Delete(ClassDTO classDTO);
    }
}
