using System.Collections.Generic;
using System.Threading.Tasks;

namespace AzureMongoDbOnion.Domain.Services.DbServices
{
    public interface IDbService
    {
        Task<IEnumerable<Debtor>> GetAllDebtors();
    }
}
