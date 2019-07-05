using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace Midnight.Hosting
{
    public class MidnightHostedService : IHostedService
    {
        private readonly IHost host;

        public MidnightHostedService()
        {
            host = new HostBuilder()
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
