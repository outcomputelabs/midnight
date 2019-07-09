using Microsoft.Extensions.DependencyInjection;

namespace Midnight.Hosting
{
    public interface IMidnightWebBuilder
    {
        IServiceCollection Services { get; }
    }
}
