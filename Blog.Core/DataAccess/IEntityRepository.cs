using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blog.Core.DataAccess
{
    //Generic olacak o zaman T kullanacağız.
    //T için generic kısıtları koyabiliriz. Onun için where koşulundan yararlanırız. Reference tip olacak. Genel olarak class olacak
    //IEntity'en implement edilmiş olmalı. Ancak veri tabanı nesnesi yazabilirsin. Ek olarak new()'lenebilir, yani IEntity T ye yazamayız. Interface yazamayız. Abstract ve Interface dışında class'ları yazabiliriz.
    //IentityRepository herkesin kullanablieceği bir interface
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter = null);

        List<T> GetList(Expression<Func<T, bool>> filter = null);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
