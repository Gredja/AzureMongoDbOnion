
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AzureMongoDbOnion.Infrastructure;
using Dto = AzureMongoDbOnion.Infrastructure.Dto;

namespace AzureMongoDbOnion.Domain.Services.DbServices
{
    public class DebtorService : IDebtorService
    {
        private readonly IRepository<Dto.Debtor> _repository;
        private readonly IMapper _mapper;

        public DebtorService(IRepository<Dto.Debtor> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Debtor>> GetAll()
        {
            var debtors = await _repository.GetAll();
            return _mapper.Map<IEnumerable<Dto.Debtor>, IEnumerable<Debtor>>(debtors);
        }
    }
}
