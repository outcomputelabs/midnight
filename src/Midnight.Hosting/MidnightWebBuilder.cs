using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;

namespace Midnight.Hosting
{
    public class MidnightWebBuilder : IMidnightWebBuilder
    {
        private readonly List<Action<HostBuilderContext, IServiceCollection>> delegates = new List<Action<HostBuilderContext, IServiceCollection>>();

        public IMidnightWebBuilder ConfigureServices(Action<HostBuilderContext, IServiceCollection> configure)
        {
            delegates.Add(configure ?? throw new ArgumentNullException(nameof(configure)));
            return this;
        }
    }
}
