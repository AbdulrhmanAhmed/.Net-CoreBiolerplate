using System;
using System.Collections.Generic;
using System.Text;

namespace Abdelrahman_task.Core.Models
{
   public class Student
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string  Phone { get; set; }
        public string  Address { get; set; }
        public string  ImagePath { get; set; }
        public Fucalty Fucalty { get; set; }
        public  int FucaltyId { get; set; }
    }
}
