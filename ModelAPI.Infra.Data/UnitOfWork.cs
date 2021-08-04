using System.Data;
using Amazon;
using Amazon.S3;
using ModelAPI.Domain.Interfaces;
using ModelAPI.Domain.Interfaces.Repository;
using ModelAPI.Infra.Data.Repository;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Npgsql;

namespace ModelAPI.Infra.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbConnection _connection;

        private IHelloWorldRepository _modelRepository;
        private IAuthRepository _authRepository;

        public UnitOfWork(IConfiguration configuration)
        {
            var connectionString = configuration.GetSection("DbInfo").GetValue<string>("ConnectionString");
            _connection = new NpgsqlConnection(connectionString);
        }

        public void Dispose()
        {
            _connection.Close();
        }

        IDbConnection IUnitOfWork.Connection => _connection;
        public IHelloWorldRepository ModelRepository => _modelRepository ?? new HelloWorldRepository(this);
        public IAuthRepository AuthRepository => _authRepository ?? new AuthRepository(this);
    }
}