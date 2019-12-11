using Blog.SqlServer.EntityFrameworkCore.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities.Concrete
{
    public class MetaTag : IEntityFramework
    {
        public int Id { get; set; }
        public string Page { get; set; }
        public DateTime CreationDate { get; set; }
        public ICollection<MetaTagLanguage> Languages { get; set; }
    }
}
