using Abdelrahman_task.Core;
using Abdelrahman_task.Core.Models;
using Abdelrahman_task.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Abdelrahman_task.Services.Services
{
   public class FucaltyService:IFucaltyService
    {
        private readonly IUnitOfWork _unitOfWork;
        public FucaltyService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

      

      

        public Task<IEnumerable<Fucalty>> GetAll()
        {
           return _unitOfWork.Fucalty.GetAllAsync();
        }
    }
}
