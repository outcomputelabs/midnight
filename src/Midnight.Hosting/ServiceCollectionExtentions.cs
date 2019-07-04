using Microsoft.Extensions.DependencyInjection;

namespace Midnight.Hosting
{
    public static class ServiceCollectionExtentions
    {
        public static IMidnightBuilder AddMidnight(this IServiceCollection services)
        {
            services.AddHostedService<MidnightHostedService>();
            return new MidnightBuilder(services);
        }
    }
}
