using Abdelrahman_task.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Abdelrahman_task.Core.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> GetStudentById(int id);
        Task<Student> CreateStudent(Student newStudent);
        Task UpdateStudent(Student StudentToBeUpdated, Student Student);
        Task DeleteStudent(Student Student);
    }

}
