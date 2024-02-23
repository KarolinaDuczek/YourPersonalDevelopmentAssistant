using Microsoft.Extensions.DependencyInjection;

namespace eCommerceApp.Application.Extensions
{
    public static class ApplicationExtension
    {
        public static IServiceCollection AddApplication (this IServiceCollection services)
        {
            return services;
        }
    }
}
