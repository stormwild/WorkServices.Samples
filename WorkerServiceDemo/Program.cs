using RabbitMqSubscriber;
using WorkerServiceDemo;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddHostedService<TimerWorker>();
        services.AddHostedService<RabbitMqWorker>();
    })
    .Build();

await host.RunAsync();
