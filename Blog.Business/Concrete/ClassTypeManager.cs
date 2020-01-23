using Blog.Business.Abstract;
using Blog.Business.DTOs;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Business.Concrete
{
    public class ClassTypeManager : IClassTypeService
    {
        private readonly IClassTypeRepository _classTypeRepository;
        public ClassTypeManager(IClassTypeRepository classTypeRepository)
        {
            _classTypeRepository = classTypeRepository;
        }

        public List<ClassTypeDTO> GetAll()
        {
            var all = _classTypeRepository.Read().ToList().Select(x => new ClassTypeDTO(x));
            return all.ToList();
        }
    }
}
