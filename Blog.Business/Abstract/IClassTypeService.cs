using Blog.Business.DTOs;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Business.Abstract
{
    public interface IClassTypeService
    {
        List<ClassTypeDTO> GetAll();
    }
}
