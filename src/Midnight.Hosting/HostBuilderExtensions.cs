﻿using Microsoft.Extensions.Hosting;
using System;

namespace Midnight.Hosting
{
    public static class HostBuilderExtensions
    {
        public static IHostBuilder UseMidnight(this IHostBuilder hostBuilder, Action<HostBuilderContext, IMidnightBuilder> configureDelegate)
        {
            if (configureDelegate == null) throw new ArgumentNullException(nameof(configureDelegate));
            return hostBuilder;
        }

        public static IHostBuilder UseMidnight(this IHostBuilder webHostBuilder, Action<IMidnightBuilder> configureDelegate)
        {
            if (configureDelegate == null) throw new ArgumentNullException(nameof(configureDelegate));
            return webHostBuilder.UseMidnight((ctx, midnightBuilder) => configureDelegate(midnightBuilder));
        }
    }
}