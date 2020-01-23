using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebUI.Areas.Admin.Models.ClassViewModel
{
    public class ClassListVM
    {
        public int Id { get; set; }
        public int ClassTypeId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Active { get; set; }
    }
}
