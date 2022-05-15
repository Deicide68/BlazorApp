global using BlazorServer.Interfaces;
global using BlazorServer.Services;
using Context;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Configuration
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductService, ProductService>();

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}
