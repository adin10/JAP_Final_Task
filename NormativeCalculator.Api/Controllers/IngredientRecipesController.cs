using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Infrastructure.Dto;
using NormativeCalculator.Infrastructure.Interfaces;
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
    public class IngredientRecipesController : ControllerBase
    {
        private readonly IIngredientRecipeService _ingredientRecipeService;

        public IngredientRecipesController(IIngredientRecipeService service)
        {
            _ingredientRecipeService = service;
        }
        //[HttpGet]
        //public async Task<ActionResult<List<RecipeDetailsDto>>> GetIngredientRecipe(int recipeId)
        //{
        //    return Ok(await _ingredientRecipeService.GetIngredientRecipes(recipeId));
        //}
    }
}
