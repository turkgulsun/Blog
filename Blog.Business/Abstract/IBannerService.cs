using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Business.Abstract
{
    public interface IBannerService
    {
        List<Banner> GetAll();
        Banner Get(Expression<Func<Banner, bool>> filter = null);
        void Add(Banner banner);
        void Update(Banner banner);
        void Delete(int bannerId);
    }
}
