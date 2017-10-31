using AzureMongoDbOnion.Infrastructure;
using AzureMongoDbOnion.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;

namespace AzureMongoDbOnion.Providers
{
    public static class DbProvider
    {
        public static void AddDbService(this IServiceCollection services)
        {
            services.AddTransient<IDbRepository, DbRepository>();
        }
    }
}
