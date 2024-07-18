using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MediatR_Console_Implementation
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddMediatR(cfg=>cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            
            services.AddTransient<IRequestHandler<Ping, string>, PingHandler>();

            var serviceProvider = services.BuildServiceProvider();

            var mediator = serviceProvider.GetRequiredService<IMediator>();

            var response = await mediator.Send(new Ping());

            Console.WriteLine(response);
            Console.ReadLine();
        }
    }
}
