using Model.Domain.Interfaces.Repository;

namespace Model.Infra.Repository
{
    public class HelloWorldRepository : BaseRepository, IHelloWorldRepository
    {
        public string Execute()
        {
            return "Hello world";
        }
    }
}
