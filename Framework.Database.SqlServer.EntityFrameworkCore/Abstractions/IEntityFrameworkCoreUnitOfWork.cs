using System;
using System.Threading.Tasks;

namespace Framework.Database.SqlServer.EntityFrameworkCore
{
    public interface IEntityFrameworkCoreUnitOfWork : IDisposable
    {
        //int ExecuteSqlCommand(string sql, params object[] parameters);
        IEntityFrameworkCoreRepository<TEntity> Repository<TEntity>() where TEntity : class, IEntityFramework;
        void BeginTransaction();
        Task BeginTransactionAsync();
        int SaveChanges();
        Task<int> SaveChangesAsync();
        void Commit();
        void Rollback();
    }
}