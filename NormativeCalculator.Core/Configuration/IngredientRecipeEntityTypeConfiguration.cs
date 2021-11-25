using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NormativeCalculator.Core.Entities;

namespace NormativeCalculator.Core.Configuration
{
    public class IngredientRecipeEntityTypeConfiguration : IEntityTypeConfiguration<IngredientRecipe>
    {
        public void Configure(EntityTypeBuilder<IngredientRecipe> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Ingredient).WithMany().HasForeignKey(x => x.IngredientId);
            builder.HasOne(x => x.Recipe).WithMany().HasForeignKey(x => x.RecipeId);
        }
    }
}
