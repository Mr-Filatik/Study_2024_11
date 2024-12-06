using Microsoft.Extensions.DependencyInjection;
using Shared.Database.MainDatabase.Repositories;

namespace Shared.Database.MainDatabase.Configuration;

public static class MainDatabaseServiceCollectionExtension
{
    public static void AddMainDatabase(this IServiceCollection services)
    {
        services.AddSingleton<MainDbContext>();

        services.AddScoped<UserRepository>();
    }
}
