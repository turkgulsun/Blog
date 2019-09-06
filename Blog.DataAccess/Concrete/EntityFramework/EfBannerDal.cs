using Blog.Core.DataAccess.EntityFramework;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Concrete.EntityFramework
{
    public class EfBannerDal:EfEntityRepositoryBase<Banner,BlogContext>,IBannerDal
    {
    }
}
