using Blog.Core.Entities;
using System;
using System.Text;

namespace Blog.Entities.Concrete
{
    public class ClassLanguage:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }

        public ClassEntity ClassEntity { get; set; }
        public int ClassId { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
