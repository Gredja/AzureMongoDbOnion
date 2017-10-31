using System.Collections.Generic;
using System.Threading.Tasks;
using AzureMongoDbOnion.Infrastructure.Data.Helpers;
using AzureMongoDbOnion.Infrastructure.Data.Models;
using AzureMongoDbOnion.Infrastructure;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace AzureMongoDbOnion.Infrastructure.Data
{
   public class Repository : IRepository
    {
        private readonly MongoDbContex _context;

        public Repository (IOptions<Settings> settings)
        {
            _context = new MongoDbContex(settings);
        }

        public async Task<IEnumerable<Dto.Debtor>> GetAllDebtors()
        {
            return await _context.Debtors.Find(_ => true).ToListAsync();
        }

        public Task AddOneDebtor(Dto.Debtor debtor)
        {
            throw new System.NotImplementedException();
        }

        public Task<DeleteResult> DeleteDebtor(Dto.Debtor debtor)
        {
            throw new System.NotImplementedException();
        }

        public Task<UpdateResult> UpdateDebtor(Dto.Debtor debtor)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Dto.Credit>> GetAllCredits(bool active)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Dto.Credit>> GetCreditsByDebtor(Dto.Debtor debtor)
        {
            throw new System.NotImplementedException();
        }

        public Task<DeleteResult> DeleteCredit(Dto.Credit credit)
        {
            throw new System.NotImplementedException();
        }

        public Task AddCredit(Dto.Credit credit)
        {
            throw new System.NotImplementedException();
        }

        public Task<UpdateResult> UpdateCredit(Dto.Credit credit)
        {
            throw new System.NotImplementedException();
        }

        public Task<UpdateResult> RepayCredit(Dto.Credit credit)
        {
            throw new System.NotImplementedException();
        }
    }
}
