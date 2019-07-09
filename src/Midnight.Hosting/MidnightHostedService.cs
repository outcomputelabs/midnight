using Microsoft.Extensions.Hosting;
using Orleans.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Midnight.Hosting
{
    public class MidnightHostedService : IHostedService
    {
        private readonly IHost host;

        public MidnightHostedService(IMidnightWebBuilder builder)
        {
            host = new HostBuilder()
                .UseOrleans(orleans =>
                {
                    orleans.
                })
                .Build();
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
