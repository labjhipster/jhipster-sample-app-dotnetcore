using lab.Configuration;
using lab.Infrastructure.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace lab.Configuration {
    public static class NhipsterSettingsConfiguration {
        public static IServiceCollection AddNhipsterModule(this IServiceCollection @this, IConfiguration configuration)
        {
            @this.Configure<JHipsterSettings>(configuration.GetSection("jhipster"));
            return @this;
        }
    }
}
