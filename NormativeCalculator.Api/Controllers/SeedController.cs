using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Database;
using NormativeCalculator.Infrastructure.Context;
using NormativeCalculator.Infrastructure.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormativeCalculator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController : ControllerBase
    {
        private readonly MyContext _context;

        private readonly UserManager<IdentityUser<int>> _userManager;
        private readonly RoleManager<IdentityRole<int>> _userrole;

     
        public SeedController(MyContext context, UserManager<IdentityUser<int>> userManager,
            RoleManager<IdentityRole<int>> userrole)
        {
            _context = context;
            _userManager = userManager;
            _userrole = userrole;
        }
        [HttpPost("SeedIngredients")]
        public async Task<IActionResult> PostIngredients()
        {
            var ingredient = new Ingredients
            {
                Name="Sugar",
                UnitQuantity=1,
                MeasureUnit = "kg",
                UnitPrice=1
            };
            await _context.Ingredients.AddAsync(ingredient);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPost("SeedRecipeCategory")]
        public async Task<IActionResult> PostRecipeCategory()
        {
            var recipeCategory = new RecipeCategory
            {
               CategoryName="Pancake",
               Description="Very nice pancake"
            };
            await _context.RecipeCategory.AddAsync(recipeCategory);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync()
        {
            var user = new IdentityUser<int>
            {
                Email = "mehmed.smajkic@sarajevo.ba",
                EmailConfirmed = true,
                UserName = "mehmedsmajkic",
            };

            var userResult = await _userManager.CreateAsync(user, "Test12345*");
            var roleResult = await _userrole.CreateAsync(new IdentityRole<int>(Role.User.ToString()));
            var userRoleResult = await _userManager.AddToRoleAsync(user, Role.User.ToString());
           
            return Ok();
        }
    }
}
