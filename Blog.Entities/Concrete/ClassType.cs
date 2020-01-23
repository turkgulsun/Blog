using Blog.SqlServer.EntityFrameworkCore.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities.Concrete
{
    public class ClassType: IEntityFramework
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public ICollection<ClassEntity> Classes { get; set; }

        public ClassType()
        {
            Classes = new List<ClassEntity>();
        }
    }
}
