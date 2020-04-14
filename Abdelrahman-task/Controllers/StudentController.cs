using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abdelrahman_task.Core.Models;
using Abdelrahman_task.Core.Services;
using Abdelrahman_task.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Abdelrahman_task.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _StudentService;
        private readonly IMapper _mapper;

        public StudentController(IStudentService StudentService, IMapper mapper)
        {
            this._StudentService = StudentService;
            this._mapper = mapper;
        }
        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<StudentDto>>> GetAll()
        {
                var Students=await _StudentService.GetAll();
            var result = _mapper.Map<IEnumerable<Student>,IEnumerable<StudentDto>>(Students);
            return Ok(result);
        }
        [HttpPost("")]
        public async Task<ActionResult<StudentDto>> Create([FromBody] CreateStudentDto createStudent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var CreateStudent = _mapper.Map<CreateStudentDto, Student>(createStudent);
            var newStudent = await _StudentService.CreateStudent(CreateStudent);

            var Student = await _StudentService.GetStudentById(newStudent.Id);

            var result = _mapper.Map<Student, StudentDto>(Student);

            return Ok(result);
        }

        [HttpPut("")]
        public async Task<ActionResult<StudentDto>> Update([FromBody] UpdateStudentDto updateStudent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var UpdateStudent = _mapper.Map<UpdateStudentDto, Student>(updateStudent);
            var StudentToUpdate = await _StudentService.GetStudentById(updateStudent.Id);

            if (StudentToUpdate == null)
                return NotFound();

           await  _StudentService.UpdateStudent(StudentToUpdate,UpdateStudent);

            var updatedStudent = await _StudentService.GetStudentById(updateStudent.Id);
            var result = _mapper.Map<Student, StudentDto>(updatedStudent);

            return Ok(result);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
                return BadRequest();

            var Student = await _StudentService.GetStudentById(id);

            if (Student == null)
                return NotFound();

            await _StudentService.DeleteStudent(Student);

            return NoContent();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDto>> GetById(int id)
        {
            if (id == 0)
                return BadRequest();

            var Student = await _StudentService.GetStudentById(id);

            if (Student == null)
                return NotFound();
            var result = _mapper.Map<Student, StudentDto>(Student);
            return Ok(result);
        }




    }
}