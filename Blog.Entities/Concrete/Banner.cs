using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities.Concrete
{
    public class Banner : IEntity
    {
        public int Id { get; set; }
        public int Sort { get; set; }
        public bool Active { get; set; }
        public string Target { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
        public DateTime CreationDate { get; set; }

        public ICollection<BannerLanguage> Languages { get; set; }

        public int ListId { get; set; }
        public ListEntity ListEntity { get; set; }

    }
}
