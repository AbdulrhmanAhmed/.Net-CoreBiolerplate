using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abdelrahman_task.Core.Models
{
   public class user:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
