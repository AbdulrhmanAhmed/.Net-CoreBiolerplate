using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abdelrahman_task.Dto
{
    public class UpdateStudentDto:CreateStudentDto
    {
        [Required]
        public int Id { get; set; }
        
    }
}
