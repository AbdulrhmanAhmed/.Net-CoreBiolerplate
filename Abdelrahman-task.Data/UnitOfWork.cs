using Abdelrahman_task.Core;
using Abdelrahman_task.Core.Repositories;
using Abdelrahman_task.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Abdelrahman_task.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDbContext _context;
        private StudentRepository _studentRepository;
        private FucaltyRepository _fucaltyRepository;
      
        public IStudentRepository Student => _studentRepository = _studentRepository ?? new StudentRepository(_context);
        public IFucaltyRepository Fucalty => _fucaltyRepository = _fucaltyRepository ?? new FucaltyRepository(_context);
       
        public UnitOfWork(MyDbContext context)
            {
                this._context = context;
            }
        
        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
