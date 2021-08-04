using System;
using System.Data;
using ModelAPI.Domain.Interfaces.Repository;
using MongoDB.Driver;

namespace ModelAPI.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDbConnection Connection { get; }
        IHelloWorldRepository ModelRepository { get; }
        IAuthRepository AuthRepository { get; }
    }
}