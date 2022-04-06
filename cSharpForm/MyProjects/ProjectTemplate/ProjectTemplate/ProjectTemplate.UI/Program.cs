using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjectTemplate.DATA.Context;
using ProjectTemplate.SERVİCE;
using ProjectTemplate.SERVİCE.Abstract;
using ProjectTemplate.SERVİCE.Concrete;
using ProjectTemplate.UI.Controller;
using ProjectTemplate.UI.View;
using System;
using System.Windows.Forms;

namespace ProjectTemplate
{
    static class Program
    {

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddSingleton<Context>();
                    services.AddSingleton<IService, Service>();
                    services.AddSingleton<ServiceController>();
                    services.AddSingleton<LoginForm>();
                });
        }



        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(host.Services.GetRequiredService<LoginForm>());
        }
    }
}
