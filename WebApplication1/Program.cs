
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddHostedService<StartupBackgroundService>();

builder.Services.AddHealthChecks();

var app = builder.Build();

app.MapHealthChecks("/healthz");

app.Run();

public class StartupBackgroundService : BackgroundService
{ 
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // Simulate the effect of a long-running task.
        //await Task.Delay(TimeSpan.FromSeconds(15), stoppingToken);
        //_healthCheck.StartupCompleted = true;
        
        Console.WriteLine("executing background task!!!");
    }
}
