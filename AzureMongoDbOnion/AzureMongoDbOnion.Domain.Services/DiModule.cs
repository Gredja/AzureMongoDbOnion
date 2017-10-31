using AzureMongoDbOnion.Infrastructure;
using AzureMongoDbOnion.Infrastructure.Data;
using Dto = AzureMongoDbOnion.Infrastructure.Dto;
using Ninject;

namespace AzureMongoDbOnion.Domain.Services
{
    public class DiModule
    {
        private readonly StandardKernel _kernel;

        DiModule()
        {
            _kernel = new StandardKernel();
            _kernel.Bind<IRepository<Dto.Debtor>>().To<Repository<Dto.Debtor>>().InSingletonScope();
        }
    }
}
