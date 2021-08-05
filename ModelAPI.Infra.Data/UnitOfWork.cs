using ModelAPI.Domain.Interfaces;
using ModelAPI.Domain.Interfaces.Repository;
using ModelAPI.Infra.Data.Repository;
using Microsoft.Extensions.Configuration;

namespace ModelAPI.Infra.Data
{
    public class UnitOfWork : IUnitOfWork
    {

        private IHelloWorldRepository _modelRepository;
        private IAuthRepository _authRepository;

        public UnitOfWork(IConfiguration configuration)
        {
        }

        public void Dispose()
        {
        }

        public IHelloWorldRepository ModelRepository => _modelRepository ?? new HelloWorldRepository(this);
        public IAuthRepository AuthRepository => _authRepository ?? new AuthRepository(this);
    }
}