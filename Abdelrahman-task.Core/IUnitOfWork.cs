using Abdelrahman_task.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Abdelrahman_task.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IFucaltyRepository Fucalty { get; }
        IStudentRepository Student { get; }
        Task<int> CommitAsync();
    }
}
