using ModelAPI.Domain.Interfaces;
using ModelAPI.Domain.Interfaces.Repository;
using System.Threading.Tasks;

namespace ModelAPI.Infra.Data.Repository
{
    public class HelloWorldRepository : BaseRepository, IHelloWorldRepository
    {
        public HelloWorldRepository(IUnitOfWork uow) : base(uow) { }

        public async Task<string> HelloWorld()
        {
            return "Hello world";
        }
    }
}
