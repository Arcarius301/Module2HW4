using System;
using Module2HW4.Providers;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Services;
using Module2HW4.Services.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Module2HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IPlantProvider, PlantProvider>()
                .AddSingleton<IFenceService, FenceService>()
                .AddTransient<Startup>()
                .BuildServiceProvider();

            var start = serviceProvider.GetService<Startup>();
            start.Run();
        }
    }
}
