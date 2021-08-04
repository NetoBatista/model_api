using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ModelAPI.Domain.DTO;
using ModelAPI.Domain.Interfaces;
using ModelAPI.Domain.Interfaces.Service;

namespace ModelAPI.Service.Services
{
    public class HelloWorldService : BaseService, IHelloWorldService 
    {
        public HelloWorldService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<ResponseAPI> HelloWorld()
        {
            var response = await _unitOfWork.ModelRepository.HelloWorld();
            return new ResponseAPI
            {
                Object = response
            };
        }
    }
}