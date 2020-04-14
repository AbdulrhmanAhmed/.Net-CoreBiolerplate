using System;
using System.Collections.Generic;
using System.Text;

namespace Abdelrahman_task.Core.Models
{
  public  class Fucalty
    {
        public int Id { get; set; }
        public string   Name    { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
