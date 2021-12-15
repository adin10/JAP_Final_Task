using FluentValidation;
using NormativeCalculator.Core.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.Validators
{
   public class RecipeInsertRequestValidator:AbstractValidator<RecipeInsertRequest>
    {
        public RecipeInsertRequestValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Required field");
            
        }
    }
}
