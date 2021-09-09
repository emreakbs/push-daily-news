using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PushDailyNews.Infrastructure.Settings;

namespace PushDailyNews.Infrastructure
{
    public class Startup
    {
        public void Configure(IApplicationBuilder application)
        {
        }

        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MediaServiceSettings>(configuration.GetSection("MediaServiceSettings"));
        }
    }
}
