﻿using Blog.SqlServer.EntityFrameworkCore.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities.Concrete
{
    public class MenuLanguage : IEntityFramework
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        public Menu Menu { get; set; }
        public int MenuId { get; set; }

        public Language Language { get; set; }
        public int LanguageId { get; set; }

    }
}
