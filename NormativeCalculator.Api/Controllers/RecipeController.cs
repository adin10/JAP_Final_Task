using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Database;
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
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _service;

        public RecipeController(IRecipeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<RecipeDto>>> get([FromQuery] RecipeSearchRequest request,int categoryId,int number)
        {
            return Ok(await _service.get(request,categoryId));
        }
        [HttpGet("getRecipesByCategoryId")]
        public async Task<ActionResult<List<RecipeDto>>> getRecipesByCategoryId(int categoryId)
        {
            return Ok(await _service.getRecipesByCategoryId(categoryId));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<RecipeDto>>getById(int id){
            return Ok(await _service.getById(id));
        }

        [HttpPost]
        public async Task<ActionResult<Recipe>>Insert(RecipeInsertRequest insert)
        {
            return Ok(await _service.Insert(insert));
        }
    }
}
