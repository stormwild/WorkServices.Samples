using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerServiceDemo
{
    public class TimerWorker : IHostedService, IDisposable
    {
        private readonly ILogger<TimerWorker> _logger;
        private Timer _timer;

        public TimerWorker(ILogger<TimerWorker> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(OnTimer, cancellationToken, TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(5));

            return Task.CompletedTask;
        }

        private void OnTimer(object? state)
        {
            _logger.LogInformation("OnTimer called at: {time}", DateTimeOffset.Now);
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer.Dispose();
        }
    }
}
