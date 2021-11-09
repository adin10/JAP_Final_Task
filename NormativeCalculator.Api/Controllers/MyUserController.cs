using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Infrastructure.Dto;
using NormativeCalculator.Infrastructure.Requests;
using NormativeCalculator.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormativeCalculator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyUserController : ControllerBase
    {
        private readonly IMyUserService _service;

        public MyUserController(IMyUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<MyUserDto>>>get([FromQuery]UserSearchRequest request)
        {
            return Ok(await _service.get(request));
        }
    }
}
