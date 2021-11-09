using AutoMapper;
using Microsoft.AspNetCore.Identity;
using NormativeCalculator.Database;
using NormativeCalculator.Infrastructure.Dto;
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
            CreateMap<Ingredients, IngredientDto>();

            CreateMap<RecipeCategory, RecipeCategoryDto>();

            CreateMap<MyUser, MyUserDto>();
            CreateMap<IdentityUser<int>, UserDto>();

        }
    }
}
