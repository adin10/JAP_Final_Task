using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Database;
using NormativeCalculator.Infrastructure.Dto;
using NormativeCalculator.Infrastructure.Requests;
using NormativeCalculator.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NormativeCalculator.Api.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _service;
        private readonly IMapper _mapper;

        public RecipeController(IRecipeService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<RecipeDto>>> get([FromQuery] RecipeSearchRequest request,int categoryId)
        {
            return Ok(await _service.get(request,categoryId));
        }
        [HttpGet("RecipeDetails/{recipeId}")]
        public async Task<ActionResult<List<RecipeDetailsDto>>> recipeDetails(int recipeId)
        {
            return Ok(await _service.RecipeDetails(recipeId));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<RecipeDto>>getById(int id){
            return Ok(await _service.getById(id));
        }

        [HttpPost]
        public async Task<ActionResult<Recipe>>Insert(RecipeRestUpsertModel request)
        {
            var insertRequest = _mapper.Map<RecipeInsertRequest>(request);
            insertRequest.MyUserId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            insertRequest.CreatedDate = DateTime.Now;
            return Ok(await _service.Insert(insertRequest));
        }
    }
}
