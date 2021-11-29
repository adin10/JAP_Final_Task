using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Common.Enum;
using NormativeCalculator.Core.Entities;
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

            modelBuilder.Entity<RecipeCategory>().HasData(
              new RecipeCategory { Id = 1, Name = "Pizza", Description = "Pizza kategorijaa", CreatedDate = new DateTime(2008, 5, 19, 8, 30, 52) },
              new RecipeCategory { Id = 2, Name = "Palacinke", Description = "Pizza kategorija", CreatedDate = new DateTime(2009, 6, 12, 8, 30, 52) },
              new RecipeCategory { Id = 3, Name = "Kolac", Description = "Kolac kategorija", CreatedDate = new DateTime(2018, 12, 21, 8, 30, 52) },
              new RecipeCategory { Id = 4, Name = "Hamburger", Description = "Hamburger kategorija", CreatedDate = new DateTime(2021, 10, 30, 8, 30, 52) }
              );


            modelBuilder.Entity<Ingredient>().HasData(
                   new Ingredient { Id = 1, Name = "Brasno", UnitPrice = 20, UnitQuantity = 18, UnitMeasure = UnitMeasure.kg },
                   new Ingredient { Id = 2, Name = "Ulje", UnitPrice = 3, UnitQuantity = 1, UnitMeasure = UnitMeasure.l },
                   new Ingredient { Id = 3, Name = "Secer", UnitPrice = 1.5F, UnitQuantity = 1, UnitMeasure = UnitMeasure.kg },
                   new Ingredient { Id = 4, Name = "Jaja", UnitPrice = 10, UnitQuantity = 30, UnitMeasure = UnitMeasure.kg },
                   new Ingredient { Id = 5, Name = "Maslac", UnitPrice = 25, UnitQuantity = 2, UnitMeasure = UnitMeasure.kg }
                   );

            modelBuilder.Entity<Recipe>().HasData(
               new Recipe { Id = 1, Name = "Rafaelo", Description = "Ukusni kolac", MyUserId = 1, CreatedDate = new DateTime(2018, 12, 21, 8, 30, 52), RecipeCategoryId = 3 },
                new Recipe { Id = 2, Name = "Snickers", Description = "Predobar kolac", MyUserId = 2, CreatedDate = new DateTime(2016, 12, 21, 8, 30, 52), RecipeCategoryId = 3 },
                new Recipe { Id = 3, Name = "Palacinke sa nutelom", Description = "Vrhunski specijalitet", MyUserId = 1, CreatedDate = new DateTime(2018, 12, 21, 8, 30, 52), RecipeCategoryId = 2 }
               );
        }
    }
}
