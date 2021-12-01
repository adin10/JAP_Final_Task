using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Infrastructure.Dto;
using NormativeCalculator.Infrastructure.Interfaces;
using NormativeCalculator.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormativeCalculator.Api.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeCategoriesController : ControllerBase
    {
        private readonly IRecipeCategoryService _recipeCategoryService;

        public RecipeCategoriesController(IRecipeCategoryService service)
        {
            _recipeCategoryService = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<RecipeCategoryDto>>> Get(int number)
        {
            return Ok(await _recipeCategoryService.Get(number));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RecipeCategoryDto>> GetById(int id)
        {
            return Ok(await _recipeCategoryService.GetById(id));
        }
    }
}
