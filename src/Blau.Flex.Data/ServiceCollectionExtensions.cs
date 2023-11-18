using Blau.Flex.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationDatabaseContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDatabaseContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("ApplicationDatabaseContext"));
        });

        services.AddDatabaseDeveloperPageExceptionFilter();

        return services;
    }
}
