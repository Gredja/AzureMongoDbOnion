using System.Collections.Generic;
using System.Threading.Tasks;
using AzureMongoDbOnion.Infrastructure.Data;

namespace AzureMongoDbOnion.Domain.Services.DbServices
{
    public class DbService : IDbService
    {
        private readonly IRepository _repository;

        public DbService(Repository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Debtor>> GetAllDebtors()
        {
            await _repository.GetAllDebtors();
            return null;
        }
    }
}
