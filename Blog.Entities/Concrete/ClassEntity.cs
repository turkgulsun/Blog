using Blog.SqlServer.EntityFrameworkCore.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities.Concrete
{
    //Veri tabanı nesnesi olduğunu belirtmemiz lazım.
    
    public class ClassEntity : IEntityFramework
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int Sort { get; set; }
        public bool Active { get; set; }
        public string Image { get; set; }
        public DateTime CreationDate { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletionDate { get; set; }

        public ClassType ClassType { get; set; }
        public int ClassTypeId { get; set; }

        public ICollection<ClassLanguage> Languages { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
