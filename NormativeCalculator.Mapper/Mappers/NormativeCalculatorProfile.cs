﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using NormativeCalculator.Core.Entities;
using NormativeCalculator.Core.Models.Dto;
using NormativeCalculator.Core.Models.Requests;

namespace NormativeCalculator.Mapper
{
    public class NormativeCalculatorProfile : Profile //izmjeniti naziv
    {
        public NormativeCalculatorProfile()
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

            CreateMap<IngredientRecipe, IngredientRecipeDto>().ForMember(l=>l.IngredientCost,l=>l.MapFrom(q=>q.Price));
            CreateMap<IngredientRecipeInsertRequest, IngredientRecipe>();
        }
    }
}
