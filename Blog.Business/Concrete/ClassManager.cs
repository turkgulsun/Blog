using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
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
        private readonly IMapper _mapper;


        public ClassManager(IClassRepository classRepository, IClassLanguageRepository classLanguageRepository, IEntityFrameworkCoreUnitOfWork unitOfWork, IMapper mapper)
        {
            _classRepository = classRepository;
            _classLanguageRepository = classLanguageRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(ClassDTO classDTO)
        {

            ClassEntity classEntity = new ClassEntity();
            ClassLanguage classLanguage = new ClassLanguage();

            classEntity = _mapper.Map<ClassEntity>(classDTO);
            classLanguage = _mapper.Map<ClassLanguage>(classDTO);

            classEntity.Languages.Add(classLanguage);

            _unitOfWork.BeginTransaction();
            _classRepository.Create(classEntity);

            _unitOfWork.SaveChanges();
            _unitOfWork.Commit();
        }

        public void Delete(ClassDTO classDTO)
        {
            ClassEntity classEntity = _classRepository.Read().Include(x => x.Languages).FirstOrDefault(x => x.Id == classDTO.Id);
            classEntity.IsDeleted = true;
            classEntity.DeletionDate = DateTime.Now;
            _unitOfWork.BeginTransaction();
            _classRepository.Update(classEntity, classEntity.Id);
            _unitOfWork.SaveChanges();
            _unitOfWork.Commit();
        }

        public ClassDTO GetById(int classId)
        {

            var model = _classRepository.Read().Include(x => x.Languages).FirstOrDefault(x => x.Id == classId && x.IsDeleted == false);
            ClassDTO classDTO = new ClassDTO(model);

            return classDTO;
        }
       
        public List<ClassDTO> GetAll()
        {
            var all = _classRepository.Read().Include(x => x.Languages).Where(x => x.IsDeleted == false).ToList().Select(x => new ClassDTO(x));
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

        public void Update(ClassDTO classDTO)
        {
            ClassEntity classEntity = _classRepository.Read().Include(x => x.Languages).FirstOrDefault(x => x.Id == classDTO.Id);
            ClassLanguage classLanguage = _classLanguageRepository.Read().FirstOrDefault(x => x.ClassId == classDTO.Id);


            classEntity = _mapper.Map<ClassEntity>(classDTO);
            classLanguage = _mapper.Map<ClassLanguage>(classDTO);

            _unitOfWork.BeginTransaction();
            _classRepository.Update(classEntity, classEntity.Id);
            _classLanguageRepository.Update(classLanguage, classLanguage.Id);
            _unitOfWork.SaveChanges();
            _unitOfWork.Commit();
        }
    }
}
