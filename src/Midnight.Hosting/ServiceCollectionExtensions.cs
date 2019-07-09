using Microsoft.Extensions.DependencyInjection;

namespace Midnight.Hosting
{
    public static class ServiceCollectionExtensions
    {
        public static IMidnightWebBuilder AddMidnight(this IServiceCollection services)
        {
            services.AddHostedService<MidnightHostedService>();

            var builder = new MidnightWebBuilder(services);
            services.AddSingleton(builder);
            return builder;
        }
    }
}
