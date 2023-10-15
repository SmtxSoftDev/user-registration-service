using Microsoft.Extensions.DependencyInjection;
using Users.Registration.Application.Mapper;
using Users.Registration.Application.Services.Users;

namespace Users.Registration.Application.Extensions
{
    public static class Injection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddAutoMapper(typeof(UserMappingProfile));
            return services;
        }
    }
}