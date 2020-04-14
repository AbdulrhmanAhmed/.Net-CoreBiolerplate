using Abdelrahman_task.Core.Models;
using Abdelrahman_task.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abdelrahman_task.Data.Repositories
{
   public class FucaltyRepository:Repository<Fucalty>,IFucaltyRepository
    {
        public FucaltyRepository(MyDbContext context) : base(context)
        {

        }
    }
}
