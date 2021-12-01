using Moq;
using NormativeCalculator.Core.Dto;
using NormativeCalculator.Infrastructure.Interfaces;
using NormativeCalculator.Core.Requests;
using NormativeCalculator.Infrastructure.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NormativeCalculator.Core.Entities;
using NormativeCalculator.Common.Enum;

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

        [Test]
        public void CalculateIngredientUnitCost_Ingredient_Calculate()
        {
            var ingredient = new Ingredient
            {
                Id = 1,
                UnitQuantity = 10,
                Price=30,
                UnitMeasure = UnitMeasure.kg,
                Name = "Brasno"
            };

            var result = ingredient.Price / ingredient.UnitQuantity;
            var expectedResult = 3;
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void CalculateIngredientUnitCostWithDecimal_Ingredient_Calculate()
        {
            var ingredient = new Ingredient
            {
                Id = 1,
                UnitQuantity = 12.5f,
                Price = 8.5f,
                UnitMeasure = UnitMeasure.kg,
                Name = "Brasno"
            };

            var result = Math.Round((ingredient.Price / ingredient.UnitQuantity),2);
            var expectedResult = 0.68;
            Assert.AreEqual(result, expectedResult);
        }


        [Test]
        public void RecipeCost_CalculateCost()
        {
            var recipe = new RecipeDetailsDto
            {
                Name = "Baklava",
                Description = "Ukusno",
                RecipeId = 1,
                IngredientRecipes = new()
                {
                    new()
                    {
                        Quantity = 1000,
                        IngredientCost = 3
                    },
                    new()
                    {
                        Quantity = 1000,
                        IngredientCost = 3
                    }
                }
            };
            var realPrice = _calculatedService.CalculateRecipe(recipe);
            var expectedPrice = 6;
            Assert.AreEqual(expectedPrice, realPrice);
        }

        [Test]
        public void RecipeCost_WithDecimalNumber_CalculateCost()
        {
            var recipe = new RecipeDetailsDto
            {
                Name = "Baklava",
                Description = "Ukusno",
                RecipeId = 1,
                IngredientRecipes = new()
                {
                    new()
                    {
                        Quantity = 100,
                        IngredientCost = 1.4f
                    },
                    new()
                    {
                        Quantity = 25,
                        IngredientCost = 1.7f
                    },
                    new()
                    {
                        Quantity = 25,
                        IngredientCost = 2.7f
                    }
                }
            };
            var realPrice = _calculatedService.CalculateRecipe(recipe);
            var expectedPrice = 5.8f;
            Assert.AreEqual(expectedPrice, realPrice);
        }
    }
}
