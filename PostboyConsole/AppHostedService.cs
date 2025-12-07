using System;
using Microsoft.Extensions.Hosting;

namespace PostBoyConsole;

public class AppHostedService : IHostedService
{
    private readonly PostboyConsole.UI.ConsoleApp _consoleApp;

    public AppHostedService(PostboyConsole.UI.ConsoleApp consoleApp)
    {
        _consoleApp = consoleApp;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        await _consoleApp.RunAsync(cancellationToken);
    }

    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}
