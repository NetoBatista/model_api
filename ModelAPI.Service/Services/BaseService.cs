using ModelAPI.Domain.Interfaces;
using ModelAPI.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelAPI.Service.Services
{
    public abstract class BaseService : IBaseService
    {
        protected readonly IUnitOfWork _unitOfWork;

        public BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
