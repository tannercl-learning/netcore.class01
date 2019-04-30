using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tanner.OneDrinkAndHome.Core.Entities;
using Tanner.OneDrinkAndHome.Core.Model;
using Tanner.OneDrinkAndHome.Core.Repositories;

namespace Tanner.OneDrinkAndHome.Api
{
    public static class OneDrinkAndHomeServiceCollection
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryBase<Customer>, RepositoryBase<Customer>>();
        }

        public static void AddDB(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OneDrikAndHomeContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
            );
        }

        public static void UsingDB(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<OneDrikAndHomeContext>();
                context.Database.Migrate();
            }
        }
    }
}
