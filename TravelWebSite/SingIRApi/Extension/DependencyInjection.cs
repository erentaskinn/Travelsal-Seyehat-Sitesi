using Microsoft.EntityFrameworkCore;
using SingIRApi.DAL;

namespace SingIRApi.Extension
{
    public static class DependencyInjection
    {
      public static IServiceCollection AddService(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<Context>(options => {
                
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}
