using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Common.Enum;
using NormativeCalculator.Core.Responses;
using NormativeCalculator.Database;
using NormativeCalculator.Core.Dto;
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
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;
        public IngredientsController(IIngredientService service)
        {
            _ingredientService = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<IngredientDto>>> Get()
        {
            return Ok(await _ingredientService.Get());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IngredientDto>> GetById(int id)
        {
            return Ok(await _ingredientService.GetById(id));
        }

        [HttpGet("procedure/mostUsedIngredients")]
        public async Task<ActionResult<IEnumerable<GetTop10UsedIngredientsResponse>>> GetTop10UsedIngredients(UnitMeasure unitMeasure,int min, int max)
        {
            return Ok(await _ingredientService.GetTop10UsedIngredients(unitMeasure, min, max));
        }
     

    }
}
