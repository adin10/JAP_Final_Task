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
    public class IngredientRecipeController : ControllerBase
    {
        private readonly IIngredientRecipeService _service;

        public IngredientRecipeController(IIngredientRecipeService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<List<RecipeDetailsDto>>> getIngredientRecipe(int recipeId)
        {
            return Ok(await _service.getIngredientRecipes(recipeId));
        }
    }
}
