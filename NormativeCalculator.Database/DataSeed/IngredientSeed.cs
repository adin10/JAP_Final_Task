using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Common.Enum;
using NormativeCalculator.Common.Helper;
using NormativeCalculator.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Database.DataSeed
{
  public static  class IngredientSeed
    {
        public static void SeedIngredients(this ModelBuilder builder)
        {
            Random random = new Random();
            List<string> ingredientNames = new() { "Brasno", "Ulje", "Secer", "Jaja", "Maslac", "Cokolada" };
            List<Ingredient> ingredients = new();

            List<UnitMeasure> unitMeasures = new() { UnitMeasure.g, UnitMeasure.kg, UnitMeasure.kom, UnitMeasure.l, UnitMeasure.ml };

            var startDate = new DateTime(2021, 1, 1);
            var endDate = new DateTime(2021, 11, 29);

            for (int i = 1; i <= 100; i++)
            {

                float IngredientPrice = (float)Math.Round(random.Next(1, 50) + random.NextDouble(), 2);
                float IngredientQuantity = random.Next(1, 50);
                UnitMeasure IngredientUnitMeasures = unitMeasures[random.Next(0, 5)];

                ingredients.Add(new Ingredient
                {
                    Id = i,
                    Name = ingredientNames[i % 6] + i.ToString(),
                    UnitPrice = IngredientPrice,
                    UnitQuantity = IngredientQuantity,
                    UnitMeasure = IngredientUnitMeasures,
                    CreatedDate = DateGenerator.GenerateRandomDate(startDate, endDate)
                });
            }
            builder.Entity<Ingredient>().HasData(ingredients);
        }
    }
}
