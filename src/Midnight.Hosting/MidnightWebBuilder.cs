using Microsoft.Extensions.DependencyInjection;
using System;

namespace Midnight.Hosting
{
    public class MidnightWebBuilder : IMidnightWebBuilder
    {
        public MidnightWebBuilder(IServiceCollection services)
        {
            Services = services ?? throw new ArgumentNullException(nameof(services));
        }

        public IServiceCollection Services { get; }
    }
}
