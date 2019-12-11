using Microsoft.EntityFrameworkCore;

namespace Framework.Database.SqlServer.EntityFrameworkCore
{
    public interface IEntityFrameworkCoreContextFactory
    {
        DbContext GetDbContext();
    }
}
