using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities.Concrete
{
    public class ListLanguage : IEntity
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public ListEntity ListEntity { get; set; }
        public int ListId { get; set; }

        public Language Language { get; set; }
        public int LanguageId { get; set; }
    }
}
