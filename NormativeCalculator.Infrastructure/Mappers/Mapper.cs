using AutoMapper;
using Microsoft.AspNetCore.Identity;
using NormativeCalculator.Core.Entities;
using NormativeCalculator.Database;
using NormativeCalculator.Infrastructure.Dto;
using NormativeCalculator.Infrastructure.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Infrastructure.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Ingredient, IngredientDto>();
         
            CreateMap<RecipeCategory, RecipeCategoryDto>();

            CreateMap<MyUser, MyUserDto>();
            CreateMap<IdentityUser<int>, UserDto>();

            CreateMap<Recipe, RecipeDto>();
            CreateMap<RecipeInsertRequest, Recipe>().ReverseMap();
            CreateMap<RecipeRestUpsertModel, RecipeInsertRequest>();

            CreateMap<RecipeRestUpsertModel, IngredientRecipeInsertRequest>();
            CreateMap<IngredientRecipeInsertRequest, IngredientRecipeInsertRequest>();

            CreateMap<IngredientRecipe, IngredientRecipeDto>();
            CreateMap<IngredientRecipeInsertRequest, IngredientRecipe>();

        }
    }
}
