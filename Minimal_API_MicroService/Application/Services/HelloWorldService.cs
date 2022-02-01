using Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class HelloWorldService : IHelloWorldService
    {
        public HelloWorldResponse HelloWorld(HelloWorldRequest request)
        {
            return new HelloWorldResponse
            {
                Response = $"Hello {request.Name ?? "world"}"
            };
        }
    }
}
