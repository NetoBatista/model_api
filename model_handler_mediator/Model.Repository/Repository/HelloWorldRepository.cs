using Model.Domain.Interfaces.Repository;

namespace Model.Infra.Repository
{
    public class HelloWorldRepository : BaseRepository, IHelloWorldRepository
    {
        public string Execute(string name)
        {
            return $"Hello world {name}";
        }
    }
}
