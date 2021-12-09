using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Moq;
using NormativeCalculator.Common.Enum;
using NormativeCalculator.Core.Entities;
using NormativeCalculator.Database;
using NormativeCalculator.Core.Models.Dto;
using NormativeCalculator.Infrastructure.Interfaces;
using NormativeCalculator.Core.Models.Requests;
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
    public class RecipeServiceTests
    {
        private DbContextOptions<NCDbContext> _options;
        private NCDbContext _context;
        private RecipeService _recipeService;
        private IMapper _mapperMock;
        private ICalculatedService _calculatedService;

        [OneTimeSetUp]
        public void SetUp()
        {
            _options = new DbContextOptionsBuilder<NCDbContext>().
                UseInMemoryDatabase(databaseName: "JapTaskI")
                .ConfigureWarnings(x => x.Ignore(InMemoryEventId.TransactionIgnoredWarning))
                .Options;
            _context = new NCDbContext(_options);
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RecipeInsertRequest, Recipe>().ReverseMap();
                cfg.CreateMap<IngredientRecipeInsertRequest, IngredientRecipe>();
                cfg.CreateMap<Recipe, RecipeDto>();
                cfg.CreateMap<Recipe, RecipeDetailsDto>();
                cfg.CreateMap<MyUser, MyUserDto>();
                cfg.CreateMap<RecipeCategory, RecipeCategoryDto>();
            });
            _mapperMock = configuration.CreateMapper();
            _recipeService = new RecipeService(_mapperMock, _context, _calculatedService);

            SetUpDatabase();
        }

 
        [Test]
        public async Task CreateRecipe_AddingTwoEqualIngredients_CreateRecipeWithOneIngredient()
        {
            var request = new RecipeInsertRequest
            {
                Name = "RecipeWithEqualIngredients",
                Description = "aaaaaaa",
                RecipeCategoryId = 2,
                CreatedDate = DateTime.Now,
                MyUserId = 1,
                Ingredients = new List<IngredientRecipeInsertRequest>
                {
                    new IngredientRecipeInsertRequest
                    {
                        IngredientId=1,
                        Quantity=10,
                        UnitMeasure=UnitMeasure.g
                    },
                      new IngredientRecipeInsertRequest
                   {
                       IngredientId=1,
                       Quantity=10,
                       UnitMeasure=UnitMeasure.kg
                    }
                }
            };

            Assert.ThrowsAsync<ArgumentException>(async () => await _recipeService.Insert(request));
           
        }
       
        [Test]
        public async Task CreateRecipe_AddingMoreEqualIngredients_CreateRecipeWithUniqueIngredient()
        {
            var request = new RecipeInsertRequest
            {
                Name = "RecipeWithEqualIngredients2",
                Description = "bbbbbbb",
                RecipeCategoryId = 2,
                CreatedDate = DateTime.Now,
                MyUserId = 1,
                Ingredients = new List<IngredientRecipeInsertRequest>
                {
                    new IngredientRecipeInsertRequest
                    {
                        IngredientId=1,
                        Quantity=10,
                        UnitMeasure=UnitMeasure.g
                    },
                      new IngredientRecipeInsertRequest
                   {
                       IngredientId=1,
                       Quantity=10,
                       UnitMeasure=UnitMeasure.kg
                    },
                       new IngredientRecipeInsertRequest
                    {
                        IngredientId=2,
                        Quantity=20,
                        UnitMeasure=UnitMeasure.g
                    },
                        new IngredientRecipeInsertRequest
                    {
                        IngredientId=2,
                        Quantity=20,
                        UnitMeasure=UnitMeasure.kg
                    },
                        new IngredientRecipeInsertRequest
                    {
                        IngredientId=3,
                        Quantity=30,
                        UnitMeasure=UnitMeasure.kg
                    }
                }
            };

            Assert.ThrowsAsync<ArgumentException>(async () => await _recipeService.Insert(request));

        }
    
        [Test]
        public void CreatingRecipe_WithOneIngredient_AddRecipe()
        {

            var request = new RecipeInsertRequest
            {
                Name = "Recipe1",
                Description = "aaaaaaa",
                RecipeCategoryId = 2,
                //CreatedDate = DateTime.Now,
                //MyUserId = 1,
                Ingredients = new List<IngredientRecipeInsertRequest>
                {
                    new IngredientRecipeInsertRequest
                    {
                        IngredientId=1,
                        Quantity=10,
                        UnitMeasure=Common.Enum.UnitMeasure.g
                    }
                }
            };
          
            var recipe = _recipeService.Insert(request);
            var recipeInDatabase = _context.Recipes.FirstOrDefault(x => x.Name == request.Name);
            Assert.AreEqual(request.Name, recipeInDatabase.Name);
            Assert.AreEqual(request.Description, recipeInDatabase.Description);
            Assert.AreEqual(request.RecipeCategoryId, recipeInDatabase.RecipeCategoryId);
            Assert.AreEqual(request.MyUserId, recipeInDatabase.MyUserId);
            Assert.AreEqual(request.CreatedDate, recipeInDatabase.CreatedDate);
            Assert.True(request.Ingredients.Any());
        }

      
        [Test]
        public void CreatingRecipe_WithNoIngredient_AddRecipe()
        {
            var request = new RecipeInsertRequest
            {
                Name = "Recipe2",
                Description = "bbbbbb",
                RecipeCategoryId = 2,
                //CreatedDate = DateTime.Now,
                //MyUserId = 1,
                Ingredients = new List<IngredientRecipeInsertRequest>
                {
                }
            };
            Assert.ThrowsAsync<ArgumentException>(async () => await _recipeService.Insert(request));
        }

        [TestCase(0)]
        [TestCase(4)]
        public async Task GetRecipes_InputNumber_LoadMore(int numberOfData)
        {
            var lowRequest = new RecipeSearchRequest { number = numberOfData, categoryId = 1 };

            var result = await _recipeService.Get(lowRequest);
            Assert.That(result.Count, Is.EqualTo(numberOfData));
        }

       [TestCase]
        public async Task GetRecipes_InputNumber_LoadMoreInvalid()
        {
            var lowRequest = new RecipeSearchRequest { number = -1, categoryId = 1 };
            Assert.ThrowsAsync<ArgumentException>(async () => await _recipeService.Get(lowRequest));
        }

        public void SetUpDatabase()
        {
            _context.MyUsers.Add(new MyUser { Id = 1 });
            _context.RecipeCategories.Add(new RecipeCategory
            {
                Id = 1,
            });
            _context.Recipes.AddRange(new Recipe
            {
                Id = 1,
                RecipeCategoryId = 1,
                MyUserId = 1,
                IngredientRecipes = new List<IngredientRecipe>() { new IngredientRecipe { Id = 1 } }
            },
            new Recipe
            {
                Id = 2,
                RecipeCategoryId = 1,
                MyUserId = 1,
                IngredientRecipes = new List<IngredientRecipe>() { new IngredientRecipe { Id = 2 } }
            },
              new Recipe
              {
                  Id = 3,
                  RecipeCategoryId = 1,
                  MyUserId = 1,
                  IngredientRecipes = new List<IngredientRecipe>() { new IngredientRecipe { Id = 3 } }
              },
              new Recipe
              {
                  Id = 4,
                  RecipeCategoryId = 1,
                  MyUserId = 1,
                  IngredientRecipes = new List<IngredientRecipe>() { new IngredientRecipe { Id = 4 } }
              });
            _context.SaveChanges();
        }
    }
}
