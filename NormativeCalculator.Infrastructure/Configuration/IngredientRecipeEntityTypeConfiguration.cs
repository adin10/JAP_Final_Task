using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NormativeCalculator.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Configuration
{
    public class IngredientRecipeEntityTypeConfiguration : IEntityTypeConfiguration<IngredientRecipe>
    {
        public void Configure(EntityTypeBuilder<IngredientRecipe> builder)
        {
            builder.HasKey(x => x.IngredientRecipeId);
            builder.HasOne(x => x.Ingredient).WithMany().HasForeignKey(x => x.IngredientId);
            builder.HasOne(x => x.Recipe).WithMany().HasForeignKey(x => x.RecipeId);
        }
    }
}
