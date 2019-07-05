using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Midnight.Hosting;

namespace Midnight.Standalone
{
    public class Program
    {
        public static Task Main(string[] args)
        {
            var host = new HostBuilder()
                .ConfigureAppConfiguration(configuration =>
                {
                    configuration.AddCommandLine(args);
                    configuration.AddEnvironmentVariables(nameof(Midnight));
                })
                .ConfigureLogging(logging =>
                {
                    logging.AddConsole();
                })
                .ConfigureServices(services =>
                {
                    services.Configure<ConsoleLifetimeOptions>(options =>
                    {
                        options.SuppressStatusMessages = true;
                    });
                })
                .UseConsoleLifetime()
                .UseMidnight(builder =>
                {

                })
                .Build();

            return host.RunAsync();
        }
    }
}