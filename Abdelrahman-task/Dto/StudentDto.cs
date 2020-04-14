using Abdelrahman_task.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Abdelrahman_task.Dto
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
        public int FucaltyId { get; set; }
        public string FucaltyName { get; set; }
    }
}
