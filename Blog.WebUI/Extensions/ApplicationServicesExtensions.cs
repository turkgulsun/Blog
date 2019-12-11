using Blog.DataAccess.Concrete.EntityFramework;
using Blog.DataAccess.Infrastructure;
using Blog.SqlServer.EntityFrameworkCore;
using Blog.SqlServer.EntityFrameworkCore.Abstractions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Blog.WebUI.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static void AddBlogServices(this IServiceCollection services)
        {
            var connectionStringBlog = "Server = sqlserver-2.database.windows.net; Initial Catalog = BlogContext; Persist Security Info = False; User ID = SqlServerUser; Password = P@ssword1; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30";


            services.AddDbContext<BlogContext>(options => options.UseSqlServer(connectionStringBlog));

            #region EFCore

            services.AddTransient<IEntityFrameworkCoreUnitOfWork, EntityFrameworkCoreUnitOfWork>();
            services.AddTransient(typeof(IEntityFrameworkCoreRepository<>), typeof(EntityFrameworkCoreRepository<>));
            services.AddTransient<IEntityFrameworkCoreContextFactory, DbContextFactory>();

            #endregion
        }
    }
}
