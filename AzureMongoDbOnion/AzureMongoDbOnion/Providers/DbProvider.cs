using AzureMongoDbOnion.Domain.Services.DbServices;
using Microsoft.Extensions.DependencyInjection;

namespace AzureMongoDbOnion.Providers
{
    public static class DbProvider
    {
        public static void AddDbService(this IServiceCollection services)
        {
            services.AddTransient<IDbService, DbService>();
        }
    }
}
