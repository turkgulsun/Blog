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
    }
}
