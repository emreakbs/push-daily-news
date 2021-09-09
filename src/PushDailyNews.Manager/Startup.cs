using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PushDailyNews.Manager.Abstraction;

namespace PushDailyNews.Manager
{
    public class Startup
    {
        public void Configure(IApplicationBuilder application)
        {
            // Method intentionally left empty.
        }

        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserManager, UserManager>();
            services.AddScoped<IBrandManager, BrandManager>();
            services.AddScoped<IStateManager, StateManager>();
        }
    }
}
