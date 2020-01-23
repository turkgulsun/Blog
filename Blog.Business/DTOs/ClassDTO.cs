using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Business.DTOs
{
    public class ClassDTO
    {
        public ClassDTO(ClassEntity classEntity)
        {
            Id = classEntity.Id;
            Sort = classEntity.Sort;
            Active = classEntity.Active;
            CreationDate = classEntity.CreationDate;
            IsDeleted = classEntity.IsDeleted;
            DeletionDate = classEntity.DeletionDate;
            ClassTypeId = classEntity.ClassTypeId;
            Image = classEntity.Image;
            ParentId = classEntity.ParentId;

            ClassLanguageId = classEntity.Languages.FirstOrDefault(y => y.LanguageId == 1).Id;
            ClassId = classEntity.Languages.FirstOrDefault(y => y.LanguageId == 1).ClassId;
            Title = classEntity.Languages.FirstOrDefault(y => y.LanguageId == 1).Title;
            Summary = classEntity.Languages.FirstOrDefault(y => y.LanguageId == 1).Summary;
            LanguageId = classEntity.Languages.FirstOrDefault(y => y.LanguageId == 1).LanguageId;
            MetaDescription = classEntity.Languages.FirstOrDefault(y => y.LanguageId == 1).MetaDescription;
            MetaKeywords = classEntity.Languages.FirstOrDefault(y => y.LanguageId == 1).MetaKeywords;
            MetaTitle = classEntity.Languages.FirstOrDefault(y => y.LanguageId == 1).MetaTitle;
        }
        public ClassDTO()
        { }


        //ClassEntity Properties
        public int Id { get; set; }
        public int Sort { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletionDate { get; set; }
        public int ClassTypeId { get; set; }
        public string Image { get; set; }
        public int ParentId { get; set; }


        //ClassLanguage Properties
        public int ClassLanguageId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public int ClassId { get; set; }
        public int LanguageId { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaTitle { get; set; }
    }
}
