using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Core.Dto;
using NormativeCalculator.Infrastructure.Interfaces;
using NormativeCalculator.Core.Requests;
using NormativeCalculator.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormativeCalculator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService service)
        {
            _userService = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<MyUserDto>>> Get([FromQuery]UserSearchRequest request)
        {
            return Ok(await _userService.Get(request));
        }
    }
}
