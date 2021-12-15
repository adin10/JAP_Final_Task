using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Common.Enum;
using NormativeCalculator.Core.Models.Responses;
using NormativeCalculator.Database;
using NormativeCalculator.Core.Models.Dto;
using NormativeCalculator.Infrastructure.Interfaces;
using NormativeCalculator.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NormativeCalculator.Common.Helper;
using NormativeCalculator.Core.Entities;
using NormativeCalculator.Core.Models.Requests;

namespace NormativeCalculator.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;
        public IngredientsController(IIngredientService service)
        {
            _ingredientService = service;
        }

        // izmjeniti paginaciju
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<List<IngredientDto>>> Get([FromQuery] PaginationParams paginationParams, [FromQuery] IngredientSearchRequest request, int? number)
        {
            var ingredients = await _ingredientService.Get(paginationParams, request,number);
            Response.AddPaginationHeader(ingredients.CurrentPage,ingredients.PageSize
              ,ingredients.TotalCount,ingredients.TotalPages);
            return Ok(ingredients);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IngredientDto>> GetById(int id)
        {
            return Ok(await _ingredientService.GetById(id));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Ingredient>> Delete(int id)
        {
            return Ok(await _ingredientService.Delete(id));
        }

        [HttpPost]
        public async Task<ActionResult<Ingredient>> Insert(IngredientRestUpsertRequest request)
        {
            return Ok(await _ingredientService.Insert(request));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Ingredient>> Update(int id, IngredientRestUpsertRequest request)
        {
            return Ok(await _ingredientService.Update(id, request));
        }

        [HttpGet("procedure/mostUsedIngredients")]
        public async Task<ActionResult<IEnumerable<GetTop10UsedIngredientsResponse>>> GetTop10UsedIngredients(UnitMeasure unitMeasure,int min, int max)
        {
            return Ok(await _ingredientService.GetTop10UsedIngredients(unitMeasure, min, max));
        }
    }
}
