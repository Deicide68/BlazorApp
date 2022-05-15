global using BlazorClient.Interfaces;
global using BlazorClient.Services;

namespace BlazorClient.Configuration
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
