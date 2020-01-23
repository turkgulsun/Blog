using AutoMapper;
using Blog.Business.DTOs;
using Blog.Entities.Concrete;
using Blog.WebUI.Areas.Admin.Models.ClassViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebUI.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Class
            CreateMap<ClassCreateVM, ClassDTO>();
            CreateMap<ClassDTO, ClassCreateVM>();
            CreateMap<ClassDTO, ClassEntity>();
            CreateMap<ClassEntity, ClassDTO>();

            CreateMap<ClassDTO, ClassLanguage>();
            CreateMap<ClassDTO, ClassLanguage>()
           .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ClassLanguageId));
            CreateMap<ClassLanguage, ClassDTO>();

            CreateMap<ClassEditVM, ClassDTO>();
            CreateMap<ClassDTO, ClassEditVM>();




        }
    }
}
