using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;

namespace Blog.Business.Concrete
{
    public class MetaTagManager : IMetaTagService
    {
        public IMetaTagDal _metaTagDal;
        public void Add(MetaTag metaTag)
        {
            _metaTagDal.Add(metaTag);
        }

        public void Delete(int metaTagId)
        {
            _metaTagDal.Delete(new MetaTag { Id = metaTagId });
        }

        public MetaTag Get(Expression<Func<MetaTag, bool>> filter = null)
        {
            return _metaTagDal.Get(filter);
        }

        public List<MetaTag> GetAll()
        {
            return _metaTagDal.GetList();
        }

        public void Update(MetaTag metaTag)
        {
            _metaTagDal.Update(metaTag);
        }
    }
}
