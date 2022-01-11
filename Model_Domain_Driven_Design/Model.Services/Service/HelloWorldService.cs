

using Model.Domain.Interfaces.Repository;
using Model.Domain.Interfaces.Service;

namespace Model.Services
{
    public class HelloWorldService : BaseService, IHelloWorldService
    {
        IHelloWorldRepository _helloWorldRepository;

        public HelloWorldService(IHelloWorldRepository helloWorldRepository) : base()
        {
            _helloWorldRepository = helloWorldRepository;
        }

        public string Execute()
        {
            return _helloWorldRepository.Execute();
        }
    }
}
