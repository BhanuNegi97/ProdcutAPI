using Microsoft.Extensions.DependencyInjection;
using ProductAPI.Repository;

namespace ProductAPI.Extention
{
    public static class ServicesConfiguration  
    {
        public static void AddRepoServices(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
