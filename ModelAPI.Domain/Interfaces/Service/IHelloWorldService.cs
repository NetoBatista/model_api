using ModelAPI.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ModelAPI.Domain.Interfaces.Service
{
    public interface IHelloWorldService
    {
        Task<ResponseAPI> HelloWorld();
    }
}
