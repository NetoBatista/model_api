using System;
using System.Data;
using ModelAPI.Domain.Interfaces.Repository;

namespace ModelAPI.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IHelloWorldRepository HelloWorldRepository { get; }
        IAuthRepository AuthRepository { get; }
    }
}