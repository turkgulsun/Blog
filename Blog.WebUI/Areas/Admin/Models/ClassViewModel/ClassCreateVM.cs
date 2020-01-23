using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebUI.Areas.Admin.Models.ClassViewModel
{
    public class ClassCreateVM
    {
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
        [Required(ErrorMessage ="Required Field")]
        public string Title { get; set; }
        public string Summary { get; set; }
        public int ClassId { get; set; }
        public int LanguageId { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaTitle { get; set; }

        public ClassCreateVM()
        {
            Sort = 1;
            LanguageId = 1;
            Active = true;
            CreationDate = DateTime.Now;
            ClassTypeId = 1;
        }
    }
}
