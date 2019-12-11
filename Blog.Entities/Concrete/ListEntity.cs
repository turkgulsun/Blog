using Blog.SqlServer.EntityFrameworkCore.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities.Concrete
{
    public class ListEntity : IEntityFramework
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Sort { get; set; }

        public ICollection<ListLanguage> Languages { get; set; }
        public ICollection<Banner> Banners { get; set; }
        public ICollection<Menu> Menus { get; set; }
    }
}
