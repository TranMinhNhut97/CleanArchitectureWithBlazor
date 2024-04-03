using Microsoft.EntityFrameworkCore.SqlServer;
using CoffeeShop.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CoffeeShop.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CoffeeDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlServerDatabase"));
            });
            return services;
        }
    }
}
