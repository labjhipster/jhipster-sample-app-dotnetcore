using Microsoft.Extensions.DependencyInjection;

namespace lab.Configuration {
    public static class ServiceStartup
    {
        public static IServiceCollection AddServiceModule(this IServiceCollection @this)
        {
            // services will be added here by the generator
            return @this;
        }
    }
}
