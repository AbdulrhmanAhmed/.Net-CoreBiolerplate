using Abdelrahman_task.Core.Models;
using Abdelrahman_task.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Abdelrahman_task.Data.Repositories
{
   public  class StudentRepository:Repository<Student>,IStudentRepository
    {
        public StudentRepository(MyDbContext context) : base(context)
        {

        }
        private MyDbContext MyStudentDbContext
        {
            get { return Context as MyDbContext; }
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            return await MyStudentDbContext.Students
                                      .Include(m => m.Fucalty)
                                      .SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await MyStudentDbContext.Students.Include(c => c.Fucalty).ToListAsync();
        }
    }
}
