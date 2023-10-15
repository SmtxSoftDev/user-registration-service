using Microsoft.Extensions.DependencyInjection;
using Users.Registration.Application.Extensions;
using Users.Registration.Application.Services.Users;
using Users.Registration.Infrastructure.Extensions;

namespace User.Registration.Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddApplicationServices();
            services.AddInfrastructureServices();
            services
                .AddSingleton<Executor, Executor>()
                .BuildServiceProvider()
                .GetService<Executor>()
                .Execute();
        }
    }

    public class Executor
    {
        private readonly IUserService userService;

        public Executor(IUserService userService)
        {
            this.userService = userService;
        }

        public void Execute()
        {
            var results = userService.GetAll();

            results.Entity.ForEach(x =>
            {
                Console.WriteLine($"{x.Id} {x.FirstName} {x.LastName} {x.MiddleName}");
            });

            var result = userService.GetById(1).Entity;
            Console.WriteLine($"{result?.Id} {result?.FirstName} {result?.LastName} {result?.MiddleName}");
        }
    }
}