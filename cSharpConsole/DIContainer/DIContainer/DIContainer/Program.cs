using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace DIContainer
{
    class Program
    {

        public IInterface concreate { get; set; }

        public Program(IInterface concreate)
        {
            this.concreate = concreate;
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddTransient<Program>();
                    services.AddSingleton<IInterface, ConcreteA>();
                });
        }

        static void Main(string[] args)
        {

            var host = CreateHostBuilder(args).Build();
            host.Services.GetRequiredService<Program>().Run();


        }

        public void Run()
        {
            concreate.methodFromInterface();
            concreate.MethodToOverride();

        }


    }
}
