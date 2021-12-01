using Moq;
using NormativeCalculator.Infrastructure.Dto;
using NormativeCalculator.Infrastructure.Interfaces;
using NormativeCalculator.Infrastructure.Requests;
using NormativeCalculator.Infrastructure.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Services.Tests
{
    [TestFixture]
    public class CalculatedServiceTests
    {
        private CalculatedService _calculatedService;
        private Mock<ICalculatedService> calculatedServiceMock;

        [OneTimeSetUp]
        public void Test()
        {
            calculatedServiceMock = new Mock<ICalculatedService>();
            _calculatedService = new CalculatedService();
        }

        //Calculating recipe cost
        [Test]
        public void RecipeCost_CalculateCost()
        {
            var list = new List<IngredientRecipeDto>();
            var ingredients = new IngredientDto
            {
                Id = 1,
                UnitMeasure = "gr",
                Name = "jaja",
                UnitPrice = 10,
                UnitQuantity = 30
            };
            list.Add(new IngredientRecipeDto
            {
                Ingredient = ingredients,
                Quantity = 1000
            });
            var recipe = new RecipeDetailsDto
            {
                Name = "Baklava",
                Description = "Ukusno",
                RecipeId = 1,
                IngredientRecipes = list
            };
            var realPrice = _calculatedService.CalculateRecipe(recipe);
            var expectedPrice = (list.FirstOrDefault().Quantity * ingredients.UnitPrice) / ingredients.UnitQuantity;
            Assert.AreEqual(expectedPrice, realPrice);
        }
    }
}
