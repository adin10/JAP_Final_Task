using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class storedProcedures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Create procedure GetAllRecipes
                                As
                                Begin
                                select  R.Id, R.Name, R.TotalCost, Count(IR.IngredientId) As ukupno
                                from Recipes as R 
                                inner join IngredientRecipes as IR on R.Id=IR.RecipeId
                                group by R.Id, R.Name, R.TotalCost
                                having Count(IR.IngredientId)>=4
                                order by R.TotalCost desc
                                End");

            migrationBuilder.Sql(@"Create procedure GetRecipesByCategoryName
                                as
                                begin
                                Select RC.Name As CategoryName, R.Name As RecipeName, R.TotalCost As TotalCost
                                from RecipeCategories as RC inner join Recipes as R
                                on RC.Id=R.RecipeCategoryId
                                order by R.TotalCost Desc
                                End");
            migrationBuilder.Sql(@"Create procedure GetTop10UsedIngredients
                                (
	                                @MeasureUnit int,
	                                @MinQuantity int,
	                                @MaxQuantity int
                                )
                                as
                                begin
                                select TOP 10 I.Name, COUNT(IR.IngredientId) As ukupno
                                from Ingredients AS I inner join IngredientRecipes AS IR
                                on I.Id=IR.IngredientId
                                where I.UnitMeasure=@MeasureUnit and IR.Quantity between @MinQuantity and @MaxQuantity
                                group by I.Name
                                order by ukupno asc
                                end");
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("drop procedure GetAllRecipes ");
            migrationBuilder.Sql("drop procedure GetRecipesByCategoryName");
            migrationBuilder.Sql("drop procedure GetTop10UsedIngredients");
        }
    }
}