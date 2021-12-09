using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Core.Entities;
using NormativeCalculator.Core.Models.Responses;
using NormativeCalculator.Database;
using NormativeCalculator.Core.Models.Dto;
using NormativeCalculator.Infrastructure.Interfaces;
using NormativeCalculator.Core.Models.Requests;
using NormativeCalculator.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
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

        [HttpGet]
        public async Task<ActionResult<List<RecipeDto>>> Get([FromQuery] RecipeSearchRequest request)
        {
            return Ok(await _recipeService.Get(request));
        }

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

        [HttpPost]
        public async Task<ActionResult<Recipe>>Insert(RecipeRestUpsertModel request)
        {
            var insertRequest = _mapper.Map<RecipeInsertRequest>(request);
            insertRequest.MyUserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            insertRequest.CreatedDate = DateTime.Now;
            return Ok(await _recipeService.Insert(insertRequest));
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
