using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Common.Enum;
using NormativeCalculator.Core.Entities;
using NormativeCalculator.Database.DataSeed;
using System;

namespace NormativeCalculator.Database
{
    public class NCDbContext:IdentityDbContext<IdentityUser<int>,IdentityRole<int>,int>
    {
        public NCDbContext(DbContextOptions<NCDbContext> options) : base(options)
        {
        }
        public DbSet<MyUser> MyUsers { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<IngredientRecipe> IngredientRecipes { get; set; }
        public DbSet<RecipeCategory> RecipeCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MyUser>().HasData(
              new MyUser { Id = 1, FirstName = "Adin", LastName = "Smajkic", CreatedDate = new DateTime(2020, 5, 19, 8, 30, 52) },
                new MyUser { Id = 2, FirstName = "user", LastName = "user", CreatedDate = new DateTime(2018, 5, 19, 8, 30, 52) }
                  );

            modelBuilder.SeedRecipeCategories();
            modelBuilder.SeedIngredients();
            modelBuilder.SeedRecipes();
            modelBuilder.SeedIngredientRecipes();

        }
    }
}
