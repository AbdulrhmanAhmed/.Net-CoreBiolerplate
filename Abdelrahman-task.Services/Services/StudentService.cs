using Abdelrahman_task.Core;
using Abdelrahman_task.Core.Models;
using Abdelrahman_task.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Abdelrahman_task.Services.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

  

        public async Task<Student> CreateStudent(Student newStudent)
        {
            await _unitOfWork.Student
               .AddAsync(newStudent);
            await _unitOfWork.CommitAsync();

            return newStudent;
        }

        public async Task DeleteStudent(Student Student)
        {
            _unitOfWork.Student.Remove(Student);

            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
           return await _unitOfWork.Student.GetStudents();
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await _unitOfWork.Student.GetStudentByIdAsync(id);
        }

        public async Task UpdateStudent(Student StudentToBeUpdated, Student Student)
        {
            StudentToBeUpdated.FucaltyId = Student.FucaltyId;
            StudentToBeUpdated.BirthDate = Student.BirthDate;
            StudentToBeUpdated.ImagePath = Student.ImagePath;
            StudentToBeUpdated.Name = Student.Name;
            StudentToBeUpdated.Phone = Student.Phone;
            StudentToBeUpdated.Address = Student.Address;

            await _unitOfWork.CommitAsync();
        }
    }
}
