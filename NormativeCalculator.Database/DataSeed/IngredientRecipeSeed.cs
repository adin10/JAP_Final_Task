using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Common.Enum;
using NormativeCalculator.Common.Helper;
using NormativeCalculator.Core.Entities;
using System;
using MoreLinq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Database.DataSeed
{
  public static class IngredientRecipeSeed
    {
        public static void SeedIngredientRecipes(this ModelBuilder builder)
        {
            Random random = new Random();
            List<IngredientRecipe> ingredientRecipes = new();

            List<UnitMeasure> unitMeasures = new() { UnitMeasure.g,
                UnitMeasure.kg, UnitMeasure.kom, UnitMeasure.l, UnitMeasure.ml };

            var startDate = new DateTime(2021, 1, 1);
            var endDate = new DateTime(2021, 11, 29);

            for (int i = 1; i <= 100; i++)
            {
                ingredientRecipes.Add(new IngredientRecipe
                {
                    Id = i,
                    RecipeId = random.Next(1, 100),
                    IngredientId = random.Next(1, 100),
                    CreatedDate = DateGenerator.GenerateRandomDate(startDate, endDate),
                    Quantity=(float)Math.Round(random.Next(1,50)+random.NextDouble(),2),
                    UnitMeasure=unitMeasures[random.Next(0,5)],
                    Price= random.Next(1, 100)
                });
            }
            ingredientRecipes = ingredientRecipes.DistinctBy(x => new { x.RecipeId, x.IngredientId }).ToList();
            builder.Entity<IngredientRecipe>().HasData(ingredientRecipes);
        }
    }
}
