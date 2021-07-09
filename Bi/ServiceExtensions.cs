using Da.Interfaces;
using Da.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Bi
{
    public static class ServiceExtensions
    {
        public static void AddDaServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IAsyncRepository<>), typeof(AsyncRepository<>));
        }
    }
}
