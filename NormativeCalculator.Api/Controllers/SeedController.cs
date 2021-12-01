using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NormativeCalculator.Common.Roles;
using NormativeCalculator.Database;
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
        private readonly NCDbContext _context;
        private readonly UserManager<IdentityUser<int>> _userManager;
        private readonly RoleManager<IdentityRole<int>> _userrole;

        public SeedController(NCDbContext context, UserManager<IdentityUser<int>> userManager,
            RoleManager<IdentityRole<int>> userrole)
        {
            _context = context;
            _userManager = userManager;
            _userrole = userrole;
        }
     
        [HttpPost]
        public async Task<IActionResult> PostAsync()
        {
            var user = new IdentityUser<int>
            {
                Email = "adin.smajkic@edu.fit.ba",
                EmailConfirmed = true,
                UserName = "adinsmajkic",
            };

            var userResult = await _userManager.CreateAsync(user, "Proba12345*");
            var roleResult = await _userrole.CreateAsync(new IdentityRole<int>(Role.User.ToString()));
            var userRoleResult = await _userManager.AddToRoleAsync(user, Role.User.ToString());
           
            return Ok();
        }
    }
}
