using Abdelrahman_task.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Abdelrahman_task.Core.Services
{
   public interface IFucaltyService
    {
        Task<IEnumerable<Fucalty>> GetAll();
    }
}
