using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NormativeCalculator.Core.Entities;

namespace NormativeCalculator.Core.Configuration
{
    public class IngredientEntityTypeConfiguration: IEntityTypeConfiguration<Ingredient>
    {
     

        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
