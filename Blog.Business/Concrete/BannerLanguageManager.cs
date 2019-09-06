using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Business.Concrete
{
    public class BannerLanguageManager : IBannerLanguageService
    {
        public IBannerLanguageDal _bannerLanguageDal;

        public BannerLanguageManager(IBannerLanguageDal bannerLanguageDal)
        {
            _bannerLanguageDal = bannerLanguageDal;
        }

        public void Add(BannerLanguage bannerLanguage)
        {
            _bannerLanguageDal.Add(bannerLanguage);
        }

        public void Delete(int bannerLanguageId)
        {
            _bannerLanguageDal.Delete(new BannerLanguage { Id = bannerLanguageId });
        }

        public BannerLanguage Get(Expression<Func<BannerLanguage, bool>> filter = null)
        {
            return _bannerLanguageDal.Get(filter);
        }

        public List<BannerLanguage> GetAll()
        {
            return _bannerLanguageDal.GetList();
        }
        public void Update(BannerLanguage bannerLanguage)
        {
            _bannerLanguageDal.Update(bannerLanguage);
        }
    }
}
