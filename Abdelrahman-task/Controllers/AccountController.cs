using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abdelrahman_task.Core.Models;
using Abdelrahman_task.Dto.UserDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Abdelrahman_task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private SignInManager<user> _signManager;
        private UserManager<user> _userManager;
        public AccountController(UserManager<user> userManager, SignInManager<user> signManager)
        {
            _signManager = signManager;
            _userManager = userManager;
        }
        [HttpPost("Register")]
        public IActionResult Register(UserDto  userdto)
        {
            var user = new user
            {
                FirstName = userdto.firstName,
                LastName = userdto.lastName,
                Email = userdto.email,
                UserName = userdto.UserName
            };
          var result= _userManager.CreateAsync(user,userdto.password);
            if (!result.Result.Succeeded)
            {
                return BadRequest(result.Result);
            }
            return Ok(result.Result);
        }
        [HttpPost("Login")]

        public async Task< IActionResult> Login(LoginDto userdto) 
        {
            var user =await _userManager.FindByEmailAsync(userdto.Email);
            if (user==null &&  
             ! await _userManager.CheckPasswordAsync(user,userdto.Password))
            {


            }
              return Ok();

        }
        

    }
}