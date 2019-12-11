using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Business.DTOs
{
    public class ClassDTO
    {
        public ClassDTO(ClassEntity classEntity)
        {
            Id = classEntity.Id;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Active { get; set; }
        public int ClassTypeId { get; set; }
    }
}
