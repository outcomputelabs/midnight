using Microsoft.AspNetCore.Hosting;

namespace Midnight.Server
{
    public static class WebHostBuilderExtensions
    {
        public static IWebHostBuilder UseMidnight(this IWebHostBuilder builder)
        {
            return builder;
        }
    }
}
