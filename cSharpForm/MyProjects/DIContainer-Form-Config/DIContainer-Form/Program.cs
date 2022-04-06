
using DIContainer_Form.Classes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

using System.Windows.Forms;

namespace DIContainer_Form
{
    static class Program
    {


        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                  
                    services.AddSingleton<IInterface, Concrete>();
                    services.AddSingleton<ATemplate, Template>();
                    services.AddSingleton<Form1>();
                });
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var host = CreateHostBuilder().Build();
            Application.Run(host.Services.GetRequiredService<Form1>());
        }
    }
}
