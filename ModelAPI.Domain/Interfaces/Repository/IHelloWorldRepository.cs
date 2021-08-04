using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ModelAPI.Domain.Interfaces.Repository
{
    public interface IHelloWorldRepository
    {
        Task<string> HelloWorld();
    }
}