using System;
using System.Collections.Generic;

namespace Blog.SqlServer.EntityFrameworkCore.Abstractions
{
    public interface ICultureBase : IEntityFramework
    {
        string Culture { get; set; }
        Guid CultureBaseUniqueId { get; set; }
    }

    public interface ICultureBase<T> where T : class, IEntityFramework
    {
        T CultureBase { get; set; }
    }

    public interface ICultureCollection<T> where T : class, IEntityFramework
    {
        ICollection<T> Cultures { get; set; }
    }
}
