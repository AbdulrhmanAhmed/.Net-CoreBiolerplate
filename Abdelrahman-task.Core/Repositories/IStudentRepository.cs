using Abdelrahman_task.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Abdelrahman_task.Core.Repositories
{
  public  interface IStudentRepository:IRepository<Student>
    {
        Task<IEnumerable<Student>> GetStudents();
        Task<Student> GetStudentByIdAsync(int id);
    }

}
