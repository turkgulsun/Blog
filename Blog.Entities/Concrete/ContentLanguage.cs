using Blog.SqlServer.EntityFrameworkCore.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities.Concrete
{
    public class ContentLanguage: IEntityFramework
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }

        public Content Content { get; set; }
        public int ContentId { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }



    }
}
