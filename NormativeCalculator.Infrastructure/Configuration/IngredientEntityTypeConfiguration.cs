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
    public class IngredientEntityTypeConfiguration: IEntityTypeConfiguration<Ingredients>
    {
     

        public void Configure(EntityTypeBuilder<Ingredients> builder)
        {
            builder.HasKey(x => x.IngredientsId);
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
