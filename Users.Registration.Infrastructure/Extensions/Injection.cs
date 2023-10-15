using Microsoft.Extensions.DependencyInjection;
using Users.Registration.Domain.Abstractions.Users;
using Users.Registration.Infrastructure.Repositories.Users;

namespace Users.Registration.Infrastructure.Extensions
{
    public static class Injection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            // services.AddTransient<IUserRepository, UserFromInMemoryRepositoryImpl>();
            services.AddTransient<IUserRepository, UserFromJsonRepositoryImpl>();
            return services;
        }
    }
}