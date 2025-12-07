namespace ConsoleApp;

using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

class Program
{
    static async Task Main(string[] args)
    {
        var builder = Host.CreateDefaultBuilder(args)
            .UseEnvironment("Development")
            .ConfigureServices((hostContext, services) =>
            {
                // Register UI Component
                services.AddTransient<PostboyConsole.UI.ViewModels.MainMenu>();
                services.AddTransient<PostboyConsole.UI.ConsoleApp>();

                // Register Hosted Service
                services.AddHostedService<PostBoyConsole.AppHostedService>();
            })
            .Build();
        
        await builder.RunAsync();
    }
}
