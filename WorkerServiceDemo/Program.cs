using WorkerServiceDemo;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddHostedService<TimerWorker>();
    })
    .Build();

await host.RunAsync();
