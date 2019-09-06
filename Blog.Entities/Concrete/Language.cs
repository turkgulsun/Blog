using Blog.Core.Entities;
using System.Collections.Generic;

namespace Blog.Entities.Concrete
{
    public class Language : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Culture { get; set; }

        public ICollection<ClassLanguage> ClassLanguages { get; set; }
        public ICollection<ContentLanguage> ContentLanguages { get; set; }
        public ICollection<BannerLanguage> BannerLanguages { get; set; }
        public ICollection<MenuLanguage> MenuLanguages { get; set; }
        public ICollection<MetaTagLanguage> MetaTagLanguages { get; set; }
        public ICollection<ListLanguage> ListLanguages { get; set; }

    }
}
