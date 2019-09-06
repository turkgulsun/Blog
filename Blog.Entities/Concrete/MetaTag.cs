using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities.Concrete
{
    public class MetaTag : IEntity
    {
        public int Id { get; set; }
        public string Page { get; set; }
        public DateTime CreationDate { get; set; }
        public ICollection<MetaTagLanguage> Languages { get; set; }
    }
}
