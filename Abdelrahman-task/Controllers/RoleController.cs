using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abdelrahman_task.Core.Models;
using Abdelrahman_task.Core.Services;
using Abdelrahman_task.Dto.FucaltyDto;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Abdelrahman_task.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
        [ApiController]
        public class FucaltyController : ControllerBase
        {
            private readonly IFucaltyService _FucaltyService;
            private readonly IMapper _mapper;

            public FucaltyController(IFucaltyService FucaltyService, IMapper mapper)
            {
               _FucaltyService = FucaltyService;
               _mapper = mapper;
            }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<FuclatyDto>>> GetAll()
        {
            var Fucaltys = await _FucaltyService.GetAll();
            var result = _mapper.Map<IEnumerable<Fucalty>, IEnumerable<FuclatyDto>>(Fucaltys);
            return Ok(result);
        }

       
    }
}