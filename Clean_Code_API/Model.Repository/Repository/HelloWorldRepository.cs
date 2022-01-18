using Model.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
