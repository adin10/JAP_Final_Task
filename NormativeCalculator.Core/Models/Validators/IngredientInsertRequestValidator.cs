using FluentValidation;
using NormativeCalculator.Core.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Core.Models.Validators
{
   public class IngredientInsertRequestValidator:AbstractValidator<IngredientRestUpsertRequest>
    {
        public IngredientInsertRequestValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Required field");
            RuleFor(x => x.Price).NotNull().NotEmpty().WithMessage("Required field");
            RuleFor(x => x.UnitMeasure).NotNull().NotEmpty().WithMessage("Required field");
            RuleFor(x => x.UnitQuantity).NotNull().NotEmpty().WithMessage("Required field"); 
        }
    }
}
