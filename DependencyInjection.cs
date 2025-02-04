using CoffeeShop.Application;
using CoffeeShop.Infrastructure;

namespace coffee_shop
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMainDependency(this IServiceCollection services)
        {
            services.AddDependencyApplication();
            services.AddDependencyInsfrastructure();
            return services;
        }
    }
}
