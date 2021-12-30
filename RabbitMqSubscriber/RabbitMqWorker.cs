using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace RabbitMqSubscriber
{
    public class RabbitMqWorker : BackgroundService
    {
        private readonly ILogger<RabbitMqWorker> _logger;

        public RabbitMqWorker(ILogger<RabbitMqWorker> logger)
        {
            _logger = logger;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            throw new NotImplementedException();
        }
    }
}
