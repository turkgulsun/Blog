using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebUI.Areas.Admin.Models.ClassViewModel
{
    public class ClassVM
    {
        public ClassEntity ClassEntity { get; set; }
        public ClassLanguage ClassLanguage { get; set; }

        public ClassVM()
        {
            ClassEntity = new ClassEntity();
            ClassLanguage = new ClassLanguage();
            ClassEntity.Sort = 1;
            ClassLanguage.LanguageId = 1;
            ClassEntity.Active = true;
            ClassEntity.CreationDate = DateTime.Now;
        }
    }
}
