using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Infrastructure.Dto;
using NormativeCalculator.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormativeCalculator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeCategoryController : ControllerBase
    {
        private readonly IRecipeCategoryService _service;

        public RecipeCategoryController(IRecipeCategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<RecipeCategoryDto>>> get()
        {
            return Ok(await _service.get());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<RecipeCategoryDto>>getById(int id)
        {
            return Ok(await _service.getById(id));
        }
    }
}
