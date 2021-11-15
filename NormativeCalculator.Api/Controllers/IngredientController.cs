using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Database;
using NormativeCalculator.Infrastructure.Dto;
using NormativeCalculator.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormativeCalculator.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientService _service;
        public IngredientController(IIngredientService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<List<IngredientDto>>> get()
        {
            return Ok(await _service.get());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IngredientDto>>getById(int id)
        {
            return Ok(await _service.getById(id));
        }
     

    }
}
