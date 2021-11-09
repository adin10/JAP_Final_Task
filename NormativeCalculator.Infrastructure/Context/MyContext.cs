using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Context
{
   public class MyContext:IdentityDbContext<IdentityUser<int>,IdentityRole<int>,int>
    {
        public MyContext(DbContextOptions<MyContext>options) : base(options)
        {
        }

        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<IngredientRecipe> IngredientRecipe { get; set; }
        public DbSet<MyUser> MyUser { get; set; }
        public DbSet<RecipeCategory> RecipeCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
