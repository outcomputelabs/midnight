using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Midnight.Hosting
{
    public class MidnightHostedService : IHostedService
    {
        private readonly IHost host;

        public MidnightHostedService(IServiceProvider provider)
        {
            var hostBuilder = new HostBuilder();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            return host.StartAsync(cancellationToken);
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return host.StopAsync(cancellationToken);
        }
    }
}
