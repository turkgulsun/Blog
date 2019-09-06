using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities.Concrete
{
    public class Menu : IEntity
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Target { get; set; }
        public string Image { get; set; }
        public int Sort { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }

        public ICollection<MenuLanguage> Languages { get; set; }

        public int ListId { get; set; }
        public ListEntity ListEntity { get; set; }
    }
}
