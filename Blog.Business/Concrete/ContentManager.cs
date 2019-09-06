using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;

namespace Blog.Business.Concrete
{
    public class ContentManager : IContentService
    {
        public IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void Add(Content content)
        {
            _contentDal.Add(content);
        }

        public void Delete(int contentId)
        {
            _contentDal.Delete(new Content { Id = contentId });
        }

        public Content Get(Expression<Func<Content, bool>> filter = null)
        {
            return _contentDal.Get(filter);
        }

        public List<Content> GetAll()
        {
            return _contentDal.GetList();
        }

        public void Update(Content content)
        {
            _contentDal.Update(content);
        }
    }
}
