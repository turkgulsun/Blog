using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities.Concrete
{
    public class ClassType:IEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public ICollection<ClassEntity> Classes { get; set; }
    }
}
