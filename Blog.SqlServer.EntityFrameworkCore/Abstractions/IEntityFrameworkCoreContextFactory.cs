using Microsoft.EntityFrameworkCore;

namespace Blog.SqlServer.EntityFrameworkCore.Abstractions
{
    public interface IEntityFrameworkCoreContextFactory
    {
        DbContext GetDbContext();
    }
}
