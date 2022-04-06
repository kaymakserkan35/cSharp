using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DIContainerB
{
    class Program
    {

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddSingleton<IInterface, ConcreteA>();
                    services.AddSingleton<Context>();
                });
        }




        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var context = host.Services.GetRequiredService<Context>();
            context.Do();
        }
    }
}
