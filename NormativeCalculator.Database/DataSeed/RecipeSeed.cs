using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Common.Helper;
using NormativeCalculator.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Database.DataSeed
{
   public static class RecipeSeed
    {
        public static void SeedRecipes(this ModelBuilder builder)
        {
            Random random = new Random();

            List<string> recipeNames = new()
            {
                "Pizza sa sirom ",
                "Rafaelo",
                "Snickers",
                "Baklava",
                "Palacinke sa nutelom",
                "Saher torta",
                "Cokoladni kolac",
                "Ferrero"
            };
            List<Recipe> recipes = new();
            var startDate = new DateTime(2021, 1, 1);
            var endDate = new DateTime(2021, 11, 29);

            for(int i = 1; i <= 100; i++)
            {
                recipes.Add(new Recipe
                {
                    Id = i,
                    Name = recipeNames[i % 8] + i.ToString(),
                    Description = StringGenerator.GenerateDescripton(),
                    CreatedDate = DateGenerator.GenerateRandomDate(startDate, endDate),
                    MyUserId = random.Next(1, 2),
                    RecipeCategoryId = random.Next(1, 50),
                    TotalCost = (float)(random.Next(1, 100) + random.NextDouble())
                });
            }
            builder.Entity<Recipe>().HasData(recipes);
        }
    }
}
