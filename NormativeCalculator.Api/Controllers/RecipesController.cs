using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Core.Entities;
using NormativeCalculator.Core.Models.Dto;
using NormativeCalculator.Core.Models.Requests;
using NormativeCalculator.Core.Models.Responses;
using NormativeCalculator.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NormativeCalculator.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeService _recipeService;
        private readonly IMapper _mapper;

        public RecipesController(IRecipeService service,IMapper mapper)
        {
            _recipeService = service;
            _mapper = mapper;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<List<RecipeDto>>> Get([FromQuery] RecipeSearchRequest request)
        {
            return Ok(await _recipeService.Get(request));
        }

        [AllowAnonymous]
        [HttpGet("recipeDetails/{id}")]
        public async Task<ActionResult<RecipeDetailsDto>> RecipeDetails(int id)
        {
            return Ok(await _recipeService.RecipeDetails(id));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RecipeDto>> GetById(int id)
        {
            return Ok(await _recipeService.GetById(id));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Recipe>> Delete(int? id)
        {
            return Ok(await _recipeService.Delete(id.GetValueOrDefault()));
        }

        [HttpPost]
        public async Task<ActionResult<Recipe>>Insert(RecipeRestUpsertModel request)
        {
            return Ok(await _recipeService.Insert(request));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Recipe>> Update(int id, RecipeUpdateModel request)
        {
            return Ok(await _recipeService.Update(id, request));
        }

        [HttpGet("procedure/getAllRecipes")]
        public async Task<ActionResult<IEnumerable<GetAllRecipesResponse>>> GetAllRecipes()
        {
            return Ok(await _recipeService.GetAllRecipes());
        }

        [HttpGet("procedure/getRecipesByCategoryName")]
        public async Task<ActionResult<IEnumerable<GetRecipesByCategoryNameResponse>>> GetRecipesByCategoryName()
        {
            return Ok(await _recipeService.GetRecipesByCategoryName());
        }
    }
}
