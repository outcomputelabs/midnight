﻿using Microsoft.Extensions.DependencyInjection;
using System;

namespace Midnight.Hosting
{
    public class MidnightBuilder : IMidnightBuilder
    {
        public MidnightBuilder(IServiceCollection services)
        {
            Services = services ?? throw new ArgumentNullException(nameof(services));
        }

        public IServiceCollection Services { get; }
    }
}
