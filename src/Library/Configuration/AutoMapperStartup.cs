using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace lab.Configuration {
    public static class AutoMapperStartup {
        public static IServiceCollection AddAutoMapperModule(this IServiceCollection @this)
        {
            @this.AddAutoMapper(typeof(Startup));
            return @this;
        }
    }
}
