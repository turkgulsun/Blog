using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities.Concrete
{
    public class Content:IEntity
    {
        public int Id { get; set; }
        public int Sort { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletionDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public int ClassId { get; set; }
        public ClassEntity ClassEntity { get; set; }

        public ICollection<ContentLanguage> Languages { get; set; }
    }
}
