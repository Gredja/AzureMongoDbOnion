using System.Collections.Generic;
using System.Threading.Tasks;

namespace AzureMongoDbOnion.Domain.Services.DbServices
{
    public interface IDbService<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
    }
}
