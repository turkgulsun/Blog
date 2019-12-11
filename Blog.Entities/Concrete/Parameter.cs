using Blog.SqlServer.EntityFrameworkCore.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities.Concrete
{
    public class Parameter : IEntityFramework
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
    }
}
