using Microsoft.Extensions.DependencyInjection;

namespace Midnight.Hosting
{
    public static class ServiceCollectionExtensions
    {
        public static IMidnightBuilder AddMidnight(this IServiceCollection services)
        {
            services.AddHostedService<MidnightHostedService>();

            var builder = new MidnightBuilder(services);
            services.AddSingleton(builder);
            return builder;
        }
    }
}
