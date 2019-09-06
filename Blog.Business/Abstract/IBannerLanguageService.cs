using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Business.Abstract
{
    public interface IBannerLanguageService
    {
        List<BannerLanguage> GetAll();
        BannerLanguage Get(Expression<Func<BannerLanguage, bool>> filter = null);
        void Add(BannerLanguage bannerLanguage);
        void Update(BannerLanguage bannerLanguage);
        void Delete(int bannerLanguageId);
    }
}
