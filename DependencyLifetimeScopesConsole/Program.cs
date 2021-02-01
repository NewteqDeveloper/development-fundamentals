using DependencyLifetimeScopesConsole.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyLifetimeScopesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create service collection and configure our services
            var services = ConfigureServices();
            // Generate a provider
            var serviceProvider = services.BuildServiceProvider();

            // Kick off our actual code
            serviceProvider.GetService<ConsoleApplication>().Run();
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddTransient<ITransient, TransientService>();
            services.AddTransient<IScoped, ScopedService>();

            // IMPORTANT! Register our application entry point
            services.AddTransient<ConsoleApplication>();
            services.AddTransient<AnotherApp>();
            return services;
        }
    }
}
