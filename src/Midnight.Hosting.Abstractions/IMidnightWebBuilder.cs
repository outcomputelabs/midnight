using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Midnight.Hosting
{
    public interface IMidnightWebBuilder
    {
        IMidnightWebBuilder ConfigureServices(Action<HostBuilderContext, IServiceCollection> configure);
    }
}
