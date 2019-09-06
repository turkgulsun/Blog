using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;

namespace Blog.Business.Concrete
{
    public class BannerManager : IBannerService
    {

        public IBannerDal _bannerDal;

        public BannerManager(IBannerDal bannerDal)
        {
            _bannerDal = bannerDal;
        }

        public void Add(Banner banner)
        {
            _bannerDal.Add(banner);
        }

        public void Delete(int bannerId)
        {
            _bannerDal.Delete(new Banner { Id = bannerId });
        }

        public Banner Get(Expression<Func<Banner, bool>> filter = null)
        {
            return _bannerDal.Get(filter);

        }

        public List<Banner> GetAll()
        {
            return _bannerDal.GetList();
        }

        public void Update(Banner banner)
        {
            _bannerDal.Update(banner);
        }
    }
}
