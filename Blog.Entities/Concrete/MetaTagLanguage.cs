using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities.Concrete
{
    public class MetaTagLanguage : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Keywords { get; set; }
        public string Descriptions { get; set; }

        public int MetaTagId { get; set; }
        public MetaTag MetaTag { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
