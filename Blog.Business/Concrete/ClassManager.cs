using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Blog.Business.Abstract;
using Blog.Business.DTOs;
using Blog.DataAccess.Abstract;

using Blog.Entities.Concrete;
using Blog.SqlServer.EntityFrameworkCore.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Blog.Business.Concrete
{
    public class ClassManager : IClassService
    {
        private readonly IEntityFrameworkCoreUnitOfWork _unitOfWork;
        private readonly IClassRepository _classRepository;
        private readonly IClassLanguageRepository _classLanguageRepository;

        public ClassManager(IClassRepository classRepository,IClassLanguageRepository classLanguageRepository, IEntityFrameworkCoreUnitOfWork unitOfWork)
        {
            _classRepository = classRepository;
            _classLanguageRepository = classLanguageRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(ClassEntity classEntity, ClassLanguage classLanguage)
        {
            _unitOfWork.BeginTransaction();
            _classRepository.Create(classEntity);
            _classLanguageRepository.Create(classLanguage);
            _unitOfWork.SaveChanges();
            _unitOfWork.Commit();
        }

        public void Delete(ClassEntity classEntity, ClassLanguage classLanguage)
        {
            _unitOfWork.BeginTransaction();
            _classRepository.Delete(classEntity);
            _unitOfWork.SaveChanges();
            _unitOfWork.Commit();
        }

        public ClassDTO Get(int classId)
        {

            var model = _classRepository.Read().Include(x => x.Languages).FirstOrDefault(x => x.Id == classId);
            ClassDTO classDTO = new ClassDTO(model);
            
            return classDTO;
        }

        public List<ClassDTO> GetAll()
        {
            var all = _classRepository.Read().Include(x => x.Languages).ToList().Select(x => new ClassDTO(x));
            //{
            //    Id = x.Id,
            //    Name = x.Languages.FirstOrDefault(y => y.LanguageId == 1).Language.Name,
            //    Summary = x.Languages.FirstOrDefault(y => y.LanguageId == 1).Summary,
            //    CreationDate = x.CreationDate,
            //    Active = x.Active,
            //    ClassTypeId = x.ClassTypeId
            //});
            return all.ToList();
        }

        public void Update(ClassEntity classEntity, ClassLanguage classLanguage)
        {
            _unitOfWork.BeginTransaction();
            _classRepository.Update(classEntity,classEntity.Id);
            _classLanguageRepository.Update(classLanguage, classLanguage.Id);
            _unitOfWork.SaveChanges();
            _unitOfWork.Commit();
        }
    }
}
