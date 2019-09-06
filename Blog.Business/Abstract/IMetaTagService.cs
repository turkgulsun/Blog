using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Blog.Business.Abstract
{
    public interface IMetaTagService
    {
        List<MetaTag> GetAll();
        MetaTag Get(Expression<Func<MetaTag, bool>> filter = null);
        void Add(MetaTag metaTag);
        void Update(MetaTag metaTag);
        void Delete(int metaTagId);
    }
}
