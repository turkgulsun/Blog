using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Business.Abstract
{
    public interface IContentService
    {
        List<Content> GetAll();
        Content Get(Expression<Func<Content, bool>> filter = null);
        void Add(Content content);
        void Update(Content content);
        void Delete(int contentId);
    }
}
