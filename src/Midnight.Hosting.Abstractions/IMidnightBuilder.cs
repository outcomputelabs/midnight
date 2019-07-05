using Microsoft.Extensions.DependencyInjection;

namespace Midnight.Hosting
{
    public interface IMidnightBuilder
    {
        IServiceCollection Services { get; }
    }
}
