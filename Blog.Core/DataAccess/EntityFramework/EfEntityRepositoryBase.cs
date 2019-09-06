using Blog.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Core.DataAccess.EntityFramework
{
    //IentityRepository herkesin kullanablieceği bir interface
    //EntityFramework kullanmak istediğim için klasörleme yapıyorum. İleride farklı bir teknoloji kullabilirim.

    //IEntityRepository implementasyonu olacak.
    //Nesne generic olacak. 2 tane göndereceğimiz için TEntity diyoruz. T demiyoruz.

    //EntityFramework'te sorgu yazabilmemiz için 2 şeye ihtiyacımız var. 1. nesne (TEntity), 2.  Context. 
    //EfEntityRepositoryBase<TEntity, TContext>: Hangi nesne ile çalışacağız. Hangi Context ile çalışacağız. Bu bilgileri veriyoruz.
    //where TEntity : class, IEntity, new(): Kısıtlarımızı veriyoruz. Tentity class olacak. IEntity'den türemeli(Implemente olmalı). New'lenebilir bir nesne olmalı.
    //where TContext : DbContext, new(): Bir DBContext.EF DbContext'den türeyen bir nesne olmalı. Yani context nesnesi olmalı ve new'lenebilir olmalı.
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
          where TEntity : class, IEntity, new()
          where TContext : DbContext, new()
    {
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
