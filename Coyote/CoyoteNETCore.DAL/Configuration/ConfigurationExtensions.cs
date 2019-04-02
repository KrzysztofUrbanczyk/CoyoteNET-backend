using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoyoteNETCore.DAL.Configuration
{
    public static class ConfigurationExtensions
    {
        private const string InMemoryDb = "InMemoryDb";
        private const string DatabaseName = "Default";

        public static void ConfigureDataBase(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>(InMemoryDb))
            {
                services.AddDbContext<Context>(opt => opt.UseInMemoryDatabase(DatabaseName), ServiceLifetime.Transient);
            }
            else
            {
                services.AddDbContext<Context>(options =>
                        options.UseSqlServer(configuration.GetConnectionString(DatabaseName)),
                    ServiceLifetime.Transient);
            }
        }
    }
}