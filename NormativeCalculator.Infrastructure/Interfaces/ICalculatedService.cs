using NormativeCalculator.Infrastructure.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Interfaces
{
   public interface ICalculatedService
    {
        public float CalculateRecipe(RecipeDetailsDto recipe);
    }
}
