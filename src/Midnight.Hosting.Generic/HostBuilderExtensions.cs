using Microsoft.Extensions.Hosting;

namespace Midnight.Hosting
{
    public static class HostBuilderExtensions
    {
        public static IHostBuilder UseMidnight(this IHostBuilder builder)
        {
            return builder;
        }
    }
}