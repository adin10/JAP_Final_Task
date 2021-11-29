using Microsoft.EntityFrameworkCore;
using NormativeCalculator.Common.Helper;
using NormativeCalculator.Core.Entities;
using System;
using System.Collections.Generic;

namespace NormativeCalculator.Database.DataSeed
{
    public static  class RecipeCategorySeed
    {
        public static void SeedRecipeCategories(this ModelBuilder builder)
        {
            Random random = new Random();
            List<string> categoryNames = new() { "Pizza", "Palacinke", "Kolac", "Hamburger", "Sendvic", "Pitta", "Waffle", "Salata" };

            List<RecipeCategory> recipeCategory = new();
            var startDate = new DateTime(2021, 1, 1);
            var endDate = new DateTime(2021, 11, 29);
            for(int i = 1; i <= 100; i++)
            {
                recipeCategory.Add(new RecipeCategory
                {
                    Id = i,
                    Name = categoryNames[i % 8] + i.ToString(),
                    CreatedDate = DateGenerator.GenerateRandomDate(startDate, endDate),
                    Description = StringGenerator.GenerateDescripton()
                });
            }
            builder.Entity<RecipeCategory>().HasData(recipeCategory);
        }
    }
}
