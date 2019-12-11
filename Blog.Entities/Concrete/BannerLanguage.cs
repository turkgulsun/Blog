using Blog.SqlServer.EntityFrameworkCore.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities.Concrete
{
    public class BannerLanguage: IEntityFramework
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }

        public Banner Banner { get; set; }
        public int BannerId { get; set; }

        public Language Language { get; set; }
        public int LanguageId { get; set; }
    }
}
