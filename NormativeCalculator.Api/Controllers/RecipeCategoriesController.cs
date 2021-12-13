using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Core.Entities;
using NormativeCalculator.Core.Models.Dto;
using NormativeCalculator.Core.Models.Requests;
using NormativeCalculator.Infrastructure.Interfaces;
using NormativeCalculator.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormativeCalculator.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeCategoriesController : ControllerBase
    {
        private readonly IRecipeCategoryService _recipeCategoryService;

        public RecipeCategoriesController(IRecipeCategoryService service)
        {
            _recipeCategoryService = service;
        }
        
        [AllowAnonymous]
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

        [HttpPost]
        public async Task<ActionResult<RecipeCategory>> Insert(RecipeCategoryUpsertRequest request)
        {
            return Ok(await _recipeCategoryService.Insert(request));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<RecipeCategory>> Update(int id, RecipeCategoryUpsertRequest request)
        {
            return Ok(await _recipeCategoryService.Update(id, request));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<RecipeCategory>> Delete(int id)
        {
            return Ok(await _recipeCategoryService.Delete(id));
        }
    }
}
