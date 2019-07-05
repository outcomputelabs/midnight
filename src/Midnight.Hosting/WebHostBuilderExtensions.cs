using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Midnight.Hosting
{
    public static class WebHostBuilderExtensions
    {
        public static IWebHostBuilder UseMidnight(this IWebHostBuilder webHostBuilder, Action<WebHostBuilderContext, IMidnightBuilder> configureDelegate)
        {
            if (configureDelegate == null) throw new ArgumentNullException(nameof(configureDelegate));

            webHostBuilder.ConfigureServices(services =>
            {
                services.AddHostedService<MidnightHostedService>();
            });

            return webHostBuilder;
        }

        public static IWebHostBuilder UseMidnight(this IWebHostBuilder webHostBuilder, Action<IMidnightBuilder> configureDelegate)
        {
            if (configureDelegate == null) throw new ArgumentNullException(nameof(configureDelegate));
            return webHostBuilder.UseMidnight((ctx, midnightBuilder) => configureDelegate(midnightBuilder));
        }
    }
}
