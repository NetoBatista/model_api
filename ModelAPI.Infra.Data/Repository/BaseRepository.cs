using ModelAPI.Domain.Interfaces;
using ModelAPI.Domain.Interfaces.Repository;

namespace ModelAPI.Infra.Data.Repository
{
    public abstract class BaseRepository : IBaseRepository
    {
        protected readonly IUnitOfWork _unitOfWork;

        public BaseRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
