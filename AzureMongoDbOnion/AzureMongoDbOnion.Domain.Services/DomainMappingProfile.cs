using System.Collections.Generic;
using AutoMapper;
using Dto = AzureMongoDbOnion.Infrastructure.Dto;

namespace AzureMongoDbOnion.Domain.Services
{
    public class DomainMappingProfile<T, K> : Profile where T : class where K : class
    {
        public DomainMappingProfile()
        {
            CreateMap<Debtor, Dto.Debtor>();
            CreateMap<Dto.Debtor, Debtor>();
            CreateMap<Credit, Dto.Credit>();
            CreateMap<Dto.Credit, Credit>();
            CreateMap<IEnumerable<T>, IEnumerable<K>>();
            CreateMap<IEnumerable<K>, IEnumerable<T>>();
        }
    }
}
