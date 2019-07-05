using Microsoft.Extensions.DependencyInjection;

namespace Midnight.Hosting
{
    public static class ServiceCollectionExtensions
    {
        public static IMidnightBuilder AddMidnight(this IServiceCollection services)
        {
            return new MidnightBuilder(services);
        }
    }
}
