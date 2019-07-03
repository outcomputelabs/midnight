using Microsoft.Extensions.Hosting;

namespace Midnight.Server
{
    public static class HostBuilderExtensions
    {
        public static IHostBuilder UseMidnight(this IHostBuilder builder)
        {
            return builder;
        }
    }
}