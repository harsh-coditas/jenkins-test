using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace ConnectAndSellSupport.API.Configuration
{
    public static class AutomapperConfiguration
    {
        public static void ConfigureAutomapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
                    mc.AddMaps(new[] {
                        "ConnectAndSellSupport.API",
                        "ConnectAndSellSupport.Services"
                    })
                );

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
