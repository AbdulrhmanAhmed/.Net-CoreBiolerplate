using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abdelrahman_task.Dto
{
    public class CreateStudentDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        public string ImagePath { get; set; }
        [Required]
        public int FucaltyId { get; set; }
    }
}
