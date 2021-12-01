using AutoMapper;
using Microsoft.AspNetCore.Identity;
using NormativeCalculator.Core.Entities;
using NormativeCalculator.Core.Dto;
using NormativeCalculator.Core.Requests;

namespace NormativeCalculator.Mapper
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

            CreateMap<IngredientRecipe, IngredientRecipeDto>().ForMember(l=>l.IngredientCost,l=>l.MapFrom(q=>q.Price));
            CreateMap<IngredientRecipeInsertRequest, IngredientRecipe>();
        }
    }
}
