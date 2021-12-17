using AutoMapper;
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
            CreateMap<IngredientRestUpsertRequest, Ingredient>();
         
            CreateMap<RecipeCategory, RecipeCategoryDto>();
            CreateMap<RecipeCategoryUpsertRequest, RecipeCategory>();

            CreateMap<MyUser, MyUserDto>();
            CreateMap<IdentityUser<int>, UserDto>();

            CreateMap<Recipe, RecipeDto>();
            CreateMap<RecipeInsertRequest, Recipe>().ReverseMap();
            CreateMap<RecipeRestUpsertModel, Recipe>();
            CreateMap<RecipeRestUpsertModel, RecipeInsertRequest>();
            CreateMap<RecipeUpdateRequest, Recipe>().ReverseMap();
            CreateMap<RecipeUpdateModel, RecipeUpdateRequest>();

            CreateMap<RecipeRestUpsertModel, IngredientRecipeInsertRequest>();
            CreateMap<IngredientRecipeInsertRequest, IngredientRecipeInsertRequest>();

            CreateMap<IngredientRecipe, IngredientRecipeDto>().ForMember(l=>l.IngredientCost,l=>l.MapFrom(q=>q.Price));
            CreateMap<IngredientRecipeInsertRequest, IngredientRecipe>();
        }
    }
}
