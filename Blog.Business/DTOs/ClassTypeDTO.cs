using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Business.DTOs
{
    public class ClassTypeDTO
    {
        public ClassTypeDTO(ClassType classType)
        {
            Id = classType.Id;
            Type = classType.Type;
            Description = classType.Description;
        }
        public ClassTypeDTO()
        {

        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
