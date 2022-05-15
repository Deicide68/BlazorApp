global using BlazorServerApp.Interfaces;
global using BlazorServerApp.Services;
using BlazorServerApp.Context;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerApp.Configurations
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
