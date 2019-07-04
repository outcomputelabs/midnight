using Microsoft.Extensions.DependencyInjection;
using System;

namespace Midnight.Hosting
{
    public class MidnightBuilder : IMidnightBuilder
    {
        private readonly IServiceCollection services;

        public MidnightBuilder(IServiceCollection services)
        {
            this.services = services ?? throw new ArgumentNullException(nameof(services));
        }
    }
}
