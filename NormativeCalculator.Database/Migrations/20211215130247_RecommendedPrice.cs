using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class RecommendedPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
               name: "RecommendedPrice",
               table: "Recipes",
               type: "real",
               nullable: false,
               defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 69, 66f, 43.09f, 23, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 25, 17, 32, 0, 0, DateTimeKind.Unspecified), 56, 5f, 24.72f, 60, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 17, 18, 25, 0, 0, DateTimeKind.Unspecified), 49, 94f, 1.54f, 38, 3 });



            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 8, 4, 6, 14, 0, 0, DateTimeKind.Unspecified), 58, 88f, 4.53f, 97 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 25, 15, 21, 0, 0, DateTimeKind.Unspecified), 71, 55f, 35.31f, 58, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 26, 5, 40, 0, 0, DateTimeKind.Unspecified), 99, 33f, 33.01f, 31, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 27, 20, 30, 0, 0, DateTimeKind.Unspecified), 39, 73f, 16.03f, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 27, 18, 18, 0, 0, DateTimeKind.Unspecified), 88, 40f, 11.7f, 6, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 3, 16, 34, 0, 0, DateTimeKind.Unspecified), 59, 32f, 9.65f, 1, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 6, 4, 8, 0, 0, DateTimeKind.Unspecified), 8, 81f, 44.6f, 58, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 8, 16, 1, 0, 0, DateTimeKind.Unspecified), 7, 81f, 46.46f, 35, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 13, 17, 11, 0, 0, DateTimeKind.Unspecified), 17, 15f, 47.73f, 29, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 5, 20, 55, 0, 0, DateTimeKind.Unspecified), 94, 78f, 23.35f, 89, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 15, 5, 10, 0, 0, DateTimeKind.Unspecified), 88, 97f, 25.3f, 67, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 3, 22, 9, 0, 0, DateTimeKind.Unspecified), 66, 10f, 44.34f, 38, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 8, 3, 21, 0, 0, DateTimeKind.Unspecified), 49, 6f, 12.5f, 45, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 13, 1, 10, 0, 0, DateTimeKind.Unspecified), 59, 5f, 32.4f, 80, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 7, 8, 9, 0, 0, DateTimeKind.Unspecified), 27, 17f, 2.02f, 46, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 12, 0, 27, 0, 0, DateTimeKind.Unspecified), 23, 26f, 30.1f, 85, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 26, 21, 1, 0, 0, DateTimeKind.Unspecified), 5, 58f, 37.95f, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 5, 8, 34, 0, 0, DateTimeKind.Unspecified), 94, 7f, 37.84f, 93, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 1, 4, 15, 10, 0, 0, DateTimeKind.Unspecified), 39, 88f, 13.41f, 90 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 10, 9, 11, 0, 0, DateTimeKind.Unspecified), 27, 5f, 24.46f, 14, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 2, 20, 15, 34, 0, 0, DateTimeKind.Unspecified), 36, 20f, 45.71f });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 8, 10, 41, 0, 0, DateTimeKind.Unspecified), 35, 64f, 28.99f, 50, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 14, 3, 37, 0, 0, DateTimeKind.Unspecified), 85, 46f, 26.07f, 30, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 20, 4, 45, 0, 0, DateTimeKind.Unspecified), 62, 37f, 48.97f, 30, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 8, 16, 36, 0, 0, DateTimeKind.Unspecified), 45, 66f, 34.71f, 90, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 2, 5, 2, 0, 0, DateTimeKind.Unspecified), 85, 71f, 10.71f, 77, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 30, 1, 38, 0, 0, DateTimeKind.Unspecified), 22, 94f, 23.55f, 68, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 10, 12, 49, 0, 0, DateTimeKind.Unspecified), 91, 69f, 10.62f, 50, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 19, 12, 3, 0, 0, DateTimeKind.Unspecified), 7, 23f, 39.02f, 37, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 17, 10, 36, 0, 0, DateTimeKind.Unspecified), 97, 5f, 13.53f, 7, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 2, 16, 11, 27, 0, 0, DateTimeKind.Unspecified), 79, 34f, 19.9f, 51 });



            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 3, 19, 3, 38, 0, 0, DateTimeKind.Unspecified), 76, 21f, 14.04f, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 8, 5, 24, 0, 0, DateTimeKind.Unspecified), 29, 90f, 18f, 17, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 13, 23, 28, 0, 0, DateTimeKind.Unspecified), 76, 4f, 35.97f, 86, 4 });



            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 30, 6, 15, 0, 0, DateTimeKind.Unspecified), 60, 52f, 35.86f, 56, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 1, 23, 0, 19, 0, 0, DateTimeKind.Unspecified), 56, 40f, 33.54f, 84 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 23, 17, 6, 0, 0, DateTimeKind.Unspecified), 4, 52f, 25.04f, 94, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 23, 4, 9, 0, 0, DateTimeKind.Unspecified), 51, 46f, 23.48f, 71, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 23, 7, 35, 0, 0, DateTimeKind.Unspecified), 47, 25f, 47.81f, 64, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 26, 4, 24, 0, 0, DateTimeKind.Unspecified), 60, 86f, 36.74f, 83, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 6, 27, 9, 11, 0, 0, DateTimeKind.Unspecified), 30, 77f, 6.81f, 51 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 25, 0, 25, 0, 0, DateTimeKind.Unspecified), 33, 61f, 37.3f, 24, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 23, 14, 20, 0, 0, DateTimeKind.Unspecified), 43, 53f, 38.89f, 53, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 5, 21, 44, 0, 0, DateTimeKind.Unspecified), 8, 70f, 29.24f, 9, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 27, 18, 54, 0, 0, DateTimeKind.Unspecified), 4, 40f, 12.42f, 58, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 5, 0, 0, DateTimeKind.Unspecified), 21, 8f, 28.64f, 67, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 18, 0, 59, 0, 0, DateTimeKind.Unspecified), 90, 70f, 18.68f, 42, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 1, 6, 23, 36, 0, 0, DateTimeKind.Unspecified), 34, 90f, 22.33f, 70 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 29, 6, 50, 0, 0, DateTimeKind.Unspecified), 94, 40f, 45.19f, 48, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 9, 7, 55, 0, 0, DateTimeKind.Unspecified), 27, 12f, 4.4f, 29, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 22, 2, 21, 0, 0, DateTimeKind.Unspecified), 81, 81f, 31.35f, 54, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 8, 9, 14, 0, 0, DateTimeKind.Unspecified), 89, 78f, 45.7f, 6, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 23, 17, 56, 0, 0, DateTimeKind.Unspecified), 41, 88f, 41.87f, 17, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 9, 24, 19, 33, 0, 0, DateTimeKind.Unspecified), 26, 76f, 38.33f, 26 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 12, 11, 43, 0, 0, DateTimeKind.Unspecified), 48, 26f, 28.16f, 49, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 9, 4, 0, 55, 0, 0, DateTimeKind.Unspecified), 2, 43f, 34.23f, 99 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 20, 3, 54, 0, 0, DateTimeKind.Unspecified), 36, 38f, 35.63f, 9, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 24, 13, 16, 0, 0, DateTimeKind.Unspecified), 78, 24f, 23.13f, 1, 2 });



            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 24, 15, 18, 0, 0, DateTimeKind.Unspecified), 22, 15f, 44.85f, 36, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 18, 3, 58, 0, 0, DateTimeKind.Unspecified), 90, 46f, 27.64f, 25, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 25, 6, 35, 0, 0, DateTimeKind.Unspecified), 93, 18f, 14.4f, 11, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 8, 20, 9, 28, 0, 0, DateTimeKind.Unspecified), 62, 16f, 49.38f, 17 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 12, 13, 50, 0, 0, DateTimeKind.Unspecified), 36, 93f, 23.32f, 30, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 31, 0, 0, DateTimeKind.Unspecified), 80, 91f, 43.71f, 52, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 29, 21, 56, 0, 0, DateTimeKind.Unspecified), 25, 37f, 25.57f, 55, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 28, 1, 41, 0, 0, DateTimeKind.Unspecified), 36, 9f, 4f, 84, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 7, 7, 2, 0, 0, DateTimeKind.Unspecified), 17, 52f, 32.56f, 97, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 11, 18, 11, 0, 0, DateTimeKind.Unspecified), 98, 44.72f, 98, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 4, 20, 41, 0, 0, DateTimeKind.Unspecified), 92, 89f, 16.61f, 69, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 12, 15, 27, 0, 0, DateTimeKind.Unspecified), 40, 53f, 4.35f, 59, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 10, 11, 1, 0, 0, DateTimeKind.Unspecified), 60, 96f, 12.62f, 68, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 16, 1, 35, 0, 0, DateTimeKind.Unspecified), 30, 43f, 17.37f, 8, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 25, 11, 9, 0, 0, DateTimeKind.Unspecified), 96, 89f, 39.35f, 29, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 14, 1, 29, 0, 0, DateTimeKind.Unspecified), 82, 46f, 35f, 3, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 20, 3, 11, 0, 0, DateTimeKind.Unspecified), 24, 61f, 12.18f, 7, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 24, 0, 0, DateTimeKind.Unspecified), 62, 42f, 16.11f, 3, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 5, 18, 51, 0, 0, DateTimeKind.Unspecified), 37, 25f, 22.92f, 28, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 7, 10, 7, 0, 0, DateTimeKind.Unspecified), 32, 16f, 29.88f, 15, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 22, 15, 32, 0, 0, DateTimeKind.Unspecified), 24, 2f, 34.17f, 12, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 21, 11, 49, 0, 0, DateTimeKind.Unspecified), 67, 30f, 36.78f, 84, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 11, 13, 12, 27, 0, 0, DateTimeKind.Unspecified), 89, 73f, 44.73f, 73 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 22, 3, 45, 0, 0, DateTimeKind.Unspecified), 19, 35f, 4.37f, 11, 2 });


            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 13, 12, 58, 0, 0, DateTimeKind.Unspecified), 19, 18f, 46.08f, 87, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 11, 18, 23, 0, 0, DateTimeKind.Unspecified), 85, 21f, 15.3f, 93, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 13, 11, 27, 0, 0, DateTimeKind.Unspecified), 50, 75f, 41.15f, 69, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 18, 3, 55, 0, 0, DateTimeKind.Unspecified), 42, 14f, 48.85f, 37, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 19, 13, 22, 0, 0, DateTimeKind.Unspecified), 74, 23f, 9.33f, 9, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 24, 5, 20, 0, 0, DateTimeKind.Unspecified), 39, 37f, 41.16f, 84, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 1, 3, 20, 25, 0, 0, DateTimeKind.Unspecified), 65, 49f, 41.71f, 37 });



            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 9, 18, 13, 12, 0, 0, DateTimeKind.Unspecified), 30, 44f, 45.42f, 53 });


            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 7, 10, 55, 0, 0, DateTimeKind.Unspecified), 25.39f, 5, 0.7254286f, 35f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 16, 22, 39, 0, 0, DateTimeKind.Unspecified), 35.07f, 2, 5.845f, 6f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 9, 17, 9, 0, 0, DateTimeKind.Unspecified), 48.78f, 1, 1.084f, 45f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), 45.38f, 1.463871f, 31f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 10, 22, 59, 0, 0, DateTimeKind.Unspecified), 5.29f, 3, 0.12302326f, 43f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 5, 16, 21, 0, 0, DateTimeKind.Unspecified), 42.38f, 3, 1.0866667f, 39f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 20, 9, 35, 0, 0, DateTimeKind.Unspecified), 17.8f, 2, 0.40454543f, 44f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 2, 3, 48, 0, 0, DateTimeKind.Unspecified), 24.05f, 4, 0.65f, 37f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 13, 9, 16, 0, 0, DateTimeKind.Unspecified), 43.35f, 1.8847826f, 23f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 13, 23, 38, 0, 0, DateTimeKind.Unspecified), 8.88f, 4, 0.19733334f, 45f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 26, 0, 0, DateTimeKind.Unspecified), 6.52f, 3, 0.326f, 20f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 23, 7, 49, 0, 0, DateTimeKind.Unspecified), 15.44f, 3, 0.39589742f, 39f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 7, 5, 49, 0, 0, DateTimeKind.Unspecified), 7.97f, 0.44277775f, 18f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 6, 2, 20, 0, 0, DateTimeKind.Unspecified), 27.42f, 2, 1.0546154f, 26f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 4, 11, 1, 0, 0, DateTimeKind.Unspecified), 30.74f, 3, 6.148f, 5f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 22, 10, 14, 0, 0, DateTimeKind.Unspecified), 9.04f, 0.30133334f, 30f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 8, 4, 5, 0, 0, DateTimeKind.Unspecified), 2.17f, 5, 0.09041667f, 24f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 27, 2, 23, 0, 0, DateTimeKind.Unspecified), 45.61f, 1, 1.0365909f, 44f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 24, 18, 53, 0, 0, DateTimeKind.Unspecified), 19.15f, 1, 0.53194445f, 36f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 5, 6, 34, 0, 0, DateTimeKind.Unspecified), 48.9f, 3, 1.4382353f, 34f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 18, 1, 5, 0, 0, DateTimeKind.Unspecified), 1.97f, 5, 0.042826086f, 46f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 4, 15, 38, 0, 0, DateTimeKind.Unspecified), 34.96f, 3.4959998f, 10f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 9, 15, 7, 0, 0, DateTimeKind.Unspecified), 41.35f, 5, 2.0674999f, 20f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 19, 12, 18, 0, 0, DateTimeKind.Unspecified), 40f, 1.4814814f, 27f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 18, 12, 31, 0, 0, DateTimeKind.Unspecified), 45.48f, 2, 1.0828571f, 42f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 10, 0, 0, DateTimeKind.Unspecified), 48.22f, 48.22f, 1f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 18, 11, 21, 0, 0, DateTimeKind.Unspecified), 5.15f, 1, 0.2575f, 20f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Price", "UnitPrice" },
                values: new object[] { new DateTime(2021, 7, 25, 18, 50, 0, 0, DateTimeKind.Unspecified), 34.18f, 4.8828573f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Price", "UnitPrice" },
                values: new object[] { new DateTime(2021, 8, 1, 4, 5, 0, 0, DateTimeKind.Unspecified), 3.19f, 0.0725f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 31, 2, 51, 0, 0, DateTimeKind.Unspecified), 6.1f, 2, 0.5083333f, 12f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice" },
                values: new object[] { new DateTime(2021, 10, 8, 4, 30, 0, 0, DateTimeKind.Unspecified), 48.02f, 5, 1.3338889f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 10, 5, 22, 0, 0, DateTimeKind.Unspecified), 11.47f, 1, 0.5461905f, 21f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 16, 4, 53, 0, 0, DateTimeKind.Unspecified), 30.66f, 5, 1.46f, 21f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 6, 10, 34, 0, 0, DateTimeKind.Unspecified), 3.56f, 0.077391304f, 46f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 7, 16, 43, 0, 0, DateTimeKind.Unspecified), 48.39f, 5, 2.3042858f, 21f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 1, 1, 3, 0, 0, DateTimeKind.Unspecified), 28.82f, 0.75842106f, 38f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 12, 0, 23, 0, 0, DateTimeKind.Unspecified), 11.69f, 5, 0.6494444f, 18f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 27, 12, 35, 0, 0, DateTimeKind.Unspecified), 5.34f, 3, 0.113617025f, 47f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 17, 3, 52, 0, 0, DateTimeKind.Unspecified), 12.78f, 1.5975f, 8f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 3, 23, 26, 0, 0, DateTimeKind.Unspecified), 24.45f, 4, 1.528125f, 16f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 1, 6, 16, 0, 0, DateTimeKind.Unspecified), 37.01f, 0.97394735f, 38f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice" },
                values: new object[] { new DateTime(2021, 9, 2, 15, 28, 0, 0, DateTimeKind.Unspecified), 38.64f, 5, 1.170909f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 20, 20, 5, 0, 0, DateTimeKind.Unspecified), 13.1f, 4, 1.0916667f, 12f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 13, 12, 36, 0, 0, DateTimeKind.Unspecified), 34.69f, 1.3342307f, 26f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 21, 21, 35, 0, 0, DateTimeKind.Unspecified), 13.08f, 0.7266667f, 18f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice" },
                values: new object[] { new DateTime(2021, 3, 24, 12, 48, 0, 0, DateTimeKind.Unspecified), 6.82f, 1, 0.45466667f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 13, 23, 56, 0, 0, DateTimeKind.Unspecified), 35.61f, 1, 2.7392309f, 13f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 21, 5, 28, 0, 0, DateTimeKind.Unspecified), 21.99f, 5, 1.374375f, 16f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 25, 3, 16, 0, 0, DateTimeKind.Unspecified), 4.81f, 5, 0.12025f, 40f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 13, 14, 11, 0, 0, DateTimeKind.Unspecified), 3.74f, 5, 0.085f, 44f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 17, 1, 6, 0, 0, DateTimeKind.Unspecified), 2.85f, 2, 0.16764705f, 17f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 8, 5, 13, 0, 0, DateTimeKind.Unspecified), 5.22f, 0.74571425f, 7f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 5, 3, 20, 0, 0, DateTimeKind.Unspecified), 13.01f, 5, 0.38264707f, 34f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 14, 9, 42, 0, 0, DateTimeKind.Unspecified), 5.79f, 3, 0.2316f, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 1, 15, 52, 0, 0, DateTimeKind.Unspecified), 36.5f, 2, 2.28125f, 16f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 1, 19, 16, 0, 0, DateTimeKind.Unspecified), 19.39f, 1, 3.8779998f, 5f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 8, 7, 32, 0, 0, DateTimeKind.Unspecified), 39.73f, 3, 1.2415625f, 32f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 22, 4, 50, 0, 0, DateTimeKind.Unspecified), 44.97f, 5, 8.994f, 5f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 14, 10, 29, 0, 0, DateTimeKind.Unspecified), 9.78f, 1, 0.39119998f, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 4, 17, 48, 0, 0, DateTimeKind.Unspecified), 24.28f, 5, 2.6977777f, 9f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 19, 5, 0, 0, 0, DateTimeKind.Unspecified), 24.72f, 5, 24.72f, 1f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 26, 14, 45, 0, 0, DateTimeKind.Unspecified), 15.9f, 0.75714284f, 21f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 1, 23, 42, 0, 0, DateTimeKind.Unspecified), 16.89f, 5, 0.4119512f, 41f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 14, 6, 24, 0, 0, DateTimeKind.Unspecified), 21.76f, 4, 2.176f, 10f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 4, 19, 8, 0, 0, DateTimeKind.Unspecified), 38.07f, 1, 3.4609091f, 11f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 16, 9, 4, 0, 0, DateTimeKind.Unspecified), 29.27f, 1, 0.8869697f, 33f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 55, 0, 0, DateTimeKind.Unspecified), 45.17f, 1, 3.7641666f, 12f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 31, 19, 14, 0, 0, DateTimeKind.Unspecified), 15.23f, 5, 0.6922727f, 22f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 1, 9, 37, 0, 0, DateTimeKind.Unspecified), 16.83f, 0.51f, 33f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 4, 9, 57, 0, 0, DateTimeKind.Unspecified), 19.68f, 3, 0.41f, 48f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 10, 9, 51, 0, 0, DateTimeKind.Unspecified), 15.36f, 2, 0.5485714f, 28f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 12, 15, 29, 0, 0, DateTimeKind.Unspecified), 8.54f, 5, 1.708f, 5f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 12, 22, 30, 0, 0, DateTimeKind.Unspecified), 29.86f, 5, 1.1944001f, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 24, 19, 26, 0, 0, DateTimeKind.Unspecified), 4.81f, 1, 0.10688889f, 45f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 7, 0, 18, 0, 0, DateTimeKind.Unspecified), 3.73f, 2, 0.1492f, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 13, 9, 37, 0, 0, DateTimeKind.Unspecified), 33.11f, 2, 0.6757143f, 49f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 11, 19, 33, 0, 0, DateTimeKind.Unspecified), 22.39f, 5, 1.8658333f, 12f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 25, 2, 30, 0, 0, DateTimeKind.Unspecified), 5.53f, 2, 0.42538464f, 13f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 28, 14, 43, 0, 0, DateTimeKind.Unspecified), 5.34f, 1, 1.335f, 4f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 26, 23, 43, 0, 0, DateTimeKind.Unspecified), 35.65f, 1, 5.0928574f, 7f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 25, 5, 14, 0, 0, DateTimeKind.Unspecified), 4.81f, 0.13361111f, 36f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 27, 5, 53, 0, 0, DateTimeKind.Unspecified), 36.03f, 5, 1.8963157f, 19f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 1, 15, 33, 0, 0, DateTimeKind.Unspecified), 45.45f, 4, 1.515f, 30f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 19, 13, 53, 0, 0, DateTimeKind.Unspecified), 9.84f, 2, 0.8945455f, 11f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 15, 1, 45, 0, 0, DateTimeKind.Unspecified), 18.48f, 4, 0.65999997f, 28f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 28, 23, 16, 0, 0, DateTimeKind.Unspecified), 16.51f, 2, 0.9711765f, 17f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 6, 2, 1, 0, 0, DateTimeKind.Unspecified), 30.41f, 1.900625f, 16f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 4, 19, 10, 0, 0, DateTimeKind.Unspecified), 37.7f, 5, 1.508f, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 3, 18, 41, 0, 0, DateTimeKind.Unspecified), 30.12f, 10.04f, 3f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 4, 21, 26, 0, 0, DateTimeKind.Unspecified), 20.56f, 5, 1.1422222f, 18f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 21, 17, 31, 0, 0, DateTimeKind.Unspecified), 1.71f, 4, 0.051818185f, 33f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 21, 19, 32, 0, 0, DateTimeKind.Unspecified), 46.61f, 1, 1.0357778f, 45f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 13, 2, 6, 0, 0, DateTimeKind.Unspecified), 6.87f, 0.16357143f, 42f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 13, 10, 4, 0, 0, DateTimeKind.Unspecified), 5.38f, 5, 1.7933334f, 3f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 14, 18, 25, 0, 0, DateTimeKind.Unspecified), 24.67f, 0.60170734f, 41f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 3, 15, 31, 0, 0, DateTimeKind.Unspecified), 36.64f, 1, 0.9642105f, 38f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 1, 15, 45, 0, 0, DateTimeKind.Unspecified), 47.2f, 2, 15.733334f, 3f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 10, 13, 40, 0, 0, DateTimeKind.Unspecified), 39.35f, 3, 0.98375f, 40f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 6, 17, 28, 0, 0, DateTimeKind.Unspecified), 6.15f, 5, 0.16621622f, 37f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 4, 12, 31, 0, 0, DateTimeKind.Unspecified), 41.69f, 3, 6.9483333f, 6f });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 23, 6, 32, 0, 0, DateTimeKind.Unspecified), "teghvgjJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 22, 16, 55, 0, 0, DateTimeKind.Unspecified), "pJHfAjzi" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 1, 2, 17, 0, 0, DateTimeKind.Unspecified), "cADzftmz" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 15, 17, 33, 0, 0, DateTimeKind.Unspecified), "ebHilJJv" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 22, 12, 30, 0, 0, DateTimeKind.Unspecified), "fbwmDWeg" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 23, 14, 48, 0, 0, DateTimeKind.Unspecified), "WWesMIvl" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 6, 11, 26, 0, 0, DateTimeKind.Unspecified), "KnvKrcBD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 20, 18, 3, 0, 0, DateTimeKind.Unspecified), "LWcusaSD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 31, 14, 1, 0, 0, DateTimeKind.Unspecified), "fmasAjjz" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), "SLsroJDo" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 3, 23, 58, 0, 0, DateTimeKind.Unspecified), "WvvWpAed" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 14, 19, 42, 0, 0, DateTimeKind.Unspecified), "wAuoKAWS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 3, 3, 24, 0, 0, DateTimeKind.Unspecified), "gAlHISBK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 7, 6, 23, 0, 0, DateTimeKind.Unspecified), "dDAwDkAS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 17, 10, 46, 0, 0, DateTimeKind.Unspecified), "hKWcWWnm" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 10, 2, 5, 0, 0, DateTimeKind.Unspecified), "iAWkWJAg" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 4, 8, 58, 0, 0, DateTimeKind.Unspecified), "iDkIHLwH" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 3, 10, 10, 0, 0, DateTimeKind.Unspecified), "JLJpAWAn" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 21, 8, 44, 0, 0, DateTimeKind.Unspecified), "WzgWMSss" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 19, 4, 56, 0, 0, DateTimeKind.Unspecified), "lWAJWpWj" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 15, 1, 0, 0, 0, DateTimeKind.Unspecified), "fIpdaMop" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 14, 12, 30, 0, 0, DateTimeKind.Unspecified), "nghJWSrK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 23, 11, 54, 0, 0, DateTimeKind.Unspecified), "zAvrJdkB" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 3, 16, 54, 0, 0, DateTimeKind.Unspecified), "hKKWrWWK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 27, 11, 34, 0, 0, DateTimeKind.Unspecified), "dAkfnznJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 46, 0, 0, DateTimeKind.Unspecified), "hSDWwWHn" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 10, 11, 1, 0, 0, DateTimeKind.Unspecified), "SSznMzzc" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 1, 19, 45, 0, 0, DateTimeKind.Unspecified), "WWMmrWWW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 31, 12, 48, 0, 0, DateTimeKind.Unspecified), "zWHdJlna" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 20, 0, 0, DateTimeKind.Unspecified), "vDjMKvcB" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 28, 10, 34, 0, 0, DateTimeKind.Unspecified), "encuhvSS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 11, 3, 36, 0, 0, DateTimeKind.Unspecified), "miAADbKB" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 5, 22, 42, 0, 0, DateTimeKind.Unspecified), "ASsJSDBv" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 27, 0, 1, 0, 0, DateTimeKind.Unspecified), "HzLulBwi" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 27, 6, 3, 0, 0, DateTimeKind.Unspecified), "SshcKKBa" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 18, 1, 37, 0, 0, DateTimeKind.Unspecified), "SaSDSWwu" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 17, 15, 8, 0, 0, DateTimeKind.Unspecified), "SHbJdiWA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 19, 13, 48, 0, 0, DateTimeKind.Unspecified), "JJJADmvS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 13, 1, 2, 0, 0, DateTimeKind.Unspecified), "WpWiADWp" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 18, 4, 12, 0, 0, DateTimeKind.Unspecified), "orAAKWAJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 24, 20, 52, 0, 0, DateTimeKind.Unspecified), "WzzKAJfB" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 30, 12, 52, 0, 0, DateTimeKind.Unspecified), "JSpASSzA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 2, 8, 55, 0, 0, DateTimeKind.Unspecified), "WeJuaoDz" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 17, 14, 43, 0, 0, DateTimeKind.Unspecified), "ASzSmWJW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 10, 13, 21, 0, 0, DateTimeKind.Unspecified), "AASgILlS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 13, 7, 55, 0, 0, DateTimeKind.Unspecified), "klvkkbAs" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 24, 2, 2, 0, 0, DateTimeKind.Unspecified), "JlpHdoAH" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 20, 17, 29, 0, 0, DateTimeKind.Unspecified), "AaAWotod" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 3, 8, 9, 0, 0, DateTimeKind.Unspecified), "MDDSepJK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 4, 9, 56, 0, 0, DateTimeKind.Unspecified), "ASjKJokH" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 23, 11, 32, 0, 0, DateTimeKind.Unspecified), "kDLbsdAJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 10, 18, 43, 0, 0, DateTimeKind.Unspecified), "DckIWsHS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 8, 8, 19, 0, 0, DateTimeKind.Unspecified), "SspWbBsD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 3, 17, 20, 0, 0, DateTimeKind.Unspecified), "sKIgffWJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 31, 11, 46, 0, 0, DateTimeKind.Unspecified), "WkKoBmAL" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 6, 18, 1, 0, 0, DateTimeKind.Unspecified), "StWbedWv" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 31, 5, 0, 0, 0, DateTimeKind.Unspecified), "nsIDDBJW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 30, 9, 23, 0, 0, DateTimeKind.Unspecified), "JmWInKDA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 20, 5, 59, 0, 0, DateTimeKind.Unspecified), "nDaKJsnW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 16, 10, 44, 0, 0, DateTimeKind.Unspecified), "SsLHDpwn" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 14, 3, 46, 0, 0, DateTimeKind.Unspecified), "WtLKomSm" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 3, 15, 41, 0, 0, DateTimeKind.Unspecified), "DAWoDMKm" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 23, 5, 15, 0, 0, DateTimeKind.Unspecified), "AeKDdaDA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 2, 10, 41, 0, 0, DateTimeKind.Unspecified), "dgJDWSep" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 24, 22, 26, 0, 0, DateTimeKind.Unspecified), "KvbMSJDa" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 23, 20, 22, 0, 0, DateTimeKind.Unspecified), "SKibWDeS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), "MDIwBWkK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 5, 3, 22, 0, 0, DateTimeKind.Unspecified), "LMWitfKJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 9, 0, 20, 0, 0, DateTimeKind.Unspecified), "WtDiJHBf" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 2, 9, 8, 0, 0, DateTimeKind.Unspecified), "DKKoSAme" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 26, 10, 56, 0, 0, DateTimeKind.Unspecified), "bhJehWKI" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 15, 19, 10, 0, 0, DateTimeKind.Unspecified), "jmcIduSL" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 22, 9, 8, 0, 0, DateTimeKind.Unspecified), "jKlosALl" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 4, 4, 31, 0, 0, DateTimeKind.Unspecified), "bAWWuMAs" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 23, 8, 3, 0, 0, DateTimeKind.Unspecified), "HDhkwwwi" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 15, 12, 7, 0, 0, DateTimeKind.Unspecified), "WSWSJJbf" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 10, 3, 35, 0, 0, DateTimeKind.Unspecified), "gSfnmSSf" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 8, 21, 11, 0, 0, DateTimeKind.Unspecified), "puczSWuo" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 24, 3, 33, 0, 0, DateTimeKind.Unspecified), "pAhwmvsS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 12, 3, 38, 0, 0, DateTimeKind.Unspecified), "ddAJSkJo" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 14, 23, 43, 0, 0, DateTimeKind.Unspecified), "HLHHIHeA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 23, 17, 32, 0, 0, DateTimeKind.Unspecified), "SbMevcBS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 27, 11, 36, 0, 0, DateTimeKind.Unspecified), "pWpMWBAA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 26, 2, 52, 0, 0, DateTimeKind.Unspecified), "ttkjmMhf" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 8, 15, 48, 0, 0, DateTimeKind.Unspecified), "WKKWoJAH" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 18, 15, 51, 0, 0, DateTimeKind.Unspecified), "JzBkAmpa" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 6, 19, 16, 0, 0, DateTimeKind.Unspecified), "BcvnJAWg" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 3, 5, 22, 0, 0, DateTimeKind.Unspecified), "DSovzMzc" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 29, 12, 15, 0, 0, DateTimeKind.Unspecified), "JIpSnJrD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 18, 12, 1, 0, 0, DateTimeKind.Unspecified), "iSohaSkf" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 15, 20, 37, 0, 0, DateTimeKind.Unspecified), "djSkwJke" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 20, 5, 45, 0, 0, DateTimeKind.Unspecified), "dSWssdkA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 29, 7, 48, 0, 0, DateTimeKind.Unspecified), "awrASHJW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 25, 14, 17, 0, 0, DateTimeKind.Unspecified), "SSemuDfs" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 4, 0, 26, 0, 0, DateTimeKind.Unspecified), "JismmlKD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 24, 5, 11, 0, 0, DateTimeKind.Unspecified), "DlKSWDge" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 6, 7, 37, 0, 0, DateTimeKind.Unspecified), "vDhDpAhu" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 31, 22, 13, 0, 0, DateTimeKind.Unspecified), "sAAHWWWB" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 21, 16, 17, 0, 0, DateTimeKind.Unspecified), "BvJnSWsK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 18, 16, 58, 0, 0, DateTimeKind.Unspecified), "ArfSefIS" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 15, 9, 52, 0, 0, DateTimeKind.Unspecified), "ADSItDcl", 21, 78.44416f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 11, 4, 41, 0, 0, DateTimeKind.Unspecified), "aSIuJMjJ", 23, 9.357504f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 22, 19, 50, 0, 0, DateTimeKind.Unspecified), "BbeBtLts", 11, 93.59074f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 21, 17, 19, 0, 0, DateTimeKind.Unspecified), "gtWWtzor", 32, 28.862154f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 3, 4, 20, 0, 0, DateTimeKind.Unspecified), "cKWIhJiS", 3, 43.30659f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 3, 9, 36, 0, 0, DateTimeKind.Unspecified), "ttmKidba", 38, 96.328285f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 29, 6, 43, 0, 0, DateTimeKind.Unspecified), "gAidansL", 46, 40.360264f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 14, 7, 53, 0, 0, DateTimeKind.Unspecified), "JsHDDdLK", 14, 30.971607f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 5, 9, 24, 0, 0, DateTimeKind.Unspecified), "HsrWSuwS", 40, 49.2462f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 17, 6, 15, 0, 0, DateTimeKind.Unspecified), "LhiDDWod", 30, 27.485523f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 20, 23, 43, 0, 0, DateTimeKind.Unspecified), "rDSJmlrW", 14, 57.01827f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 14, 5, 1, 0, 0, DateTimeKind.Unspecified), "ufjWkiSo", 40, 61.041092f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 22, 14, 6, 0, 0, DateTimeKind.Unspecified), "DAfAScdJ", 11, 72.72123f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 18, 10, 45, 0, 0, DateTimeKind.Unspecified), "aBkLesma", 38, 27.480099f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 8, 12, 33, 0, 0, DateTimeKind.Unspecified), "cWSumWpv", 23, 92.63013f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 20, 23, 7, 0, 0, DateTimeKind.Unspecified), "fKDSkWvW", 36, 59.27643f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 25, 23, 11, 0, 0, DateTimeKind.Unspecified), "jAwJADro", 48, 68.30866f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 14, 9, 49, 0, 0, DateTimeKind.Unspecified), "DeASaAWb", 2, 48.228657f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 28, 4, 39, 0, 0, DateTimeKind.Unspecified), "AjSJDKcK", 47, 39.842438f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 7, 19, 51, 0, 0, DateTimeKind.Unspecified), "tWWiwlBr", 47, 8.7212715f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 13, 7, 2, 0, 0, DateTimeKind.Unspecified), "fBSlJsAw", 18, 60.554573f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 3, 7, 45, 0, 0, DateTimeKind.Unspecified), "msJheDvJ", 29, 24.142141f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 26, 0, 33, 0, 0, DateTimeKind.Unspecified), "AKWbSIhS", 1, 78.928375f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 26, 12, 10, 0, 0, DateTimeKind.Unspecified), "IADIDiIn", 32, 43.19162f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 11, 16, 26, 0, 0, DateTimeKind.Unspecified), "KBJwLshD", 15, 11.286328f });


            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 30, 13, 23, 0, 0, DateTimeKind.Unspecified), "nDoAnDtp", 93.794014f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 30, 12, 26, 0, 0, DateTimeKind.Unspecified), "tDvWLWwd", 21, 28.519075f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 11, 1, 1, 0, 0, DateTimeKind.Unspecified), "BWWBWAKu", 10, 31.69992f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 4, 8, 47, 0, 0, DateTimeKind.Unspecified), "uzrAvDDM", 2, 71.326904f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 14, 17, 52, 0, 0, DateTimeKind.Unspecified), "sSBaAJac", 27, 77.13976f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 5, 5, 52, 0, 0, DateTimeKind.Unspecified), "ioeAcjHD", 28, 54.15744f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 19, 9, 2, 0, 0, DateTimeKind.Unspecified), "KoJdoASr", 10, 16.912354f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 22, 2, 12, 0, 0, DateTimeKind.Unspecified), "kJDSiWJu", 39, 60.01144f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 12, 13, 51, 0, 0, DateTimeKind.Unspecified), "aAAghwkH", 44, 81.074486f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 17, 0, 33, 0, 0, DateTimeKind.Unspecified), "DBtWLMsk", 22, 76.11411f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 5, 10, 2, 0, 0, DateTimeKind.Unspecified), "KsAgsMWB", 14, 55.48929f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 11, 22, 13, 0, 0, DateTimeKind.Unspecified), "MjWWsiAw", 36, 7.6579676f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 18, 9, 33, 0, 0, DateTimeKind.Unspecified), "vWLBWBSn", 39, 56.58528f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 12, 16, 8, 0, 0, DateTimeKind.Unspecified), "eSwJBgAp", 37, 48.185814f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 2, 16, 33, 0, 0, DateTimeKind.Unspecified), "BocSJKce", 38, 28.185246f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 23, 18, 8, 0, 0, DateTimeKind.Unspecified), "JWkWAlov", 18, 68.57937f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 28, 9, 46, 0, 0, DateTimeKind.Unspecified), "WJmhcSBk", 15, 24.24484f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 20, 12, 26, 0, 0, DateTimeKind.Unspecified), "DHbuzLDK", 32, 67.28487f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 14, 21, 43, 0, 0, DateTimeKind.Unspecified), "WszdgcJH", 33, 41.978065f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 8, 12, 29, 0, 0, DateTimeKind.Unspecified), "SJSSrAKA", 3, 83.79093f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 28, 5, 26, 0, 0, DateTimeKind.Unspecified), "HddHJsnA", 25, 34.049587f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 23, 15, 20, 0, 0, DateTimeKind.Unspecified), "KSoeSSHc", 1, 47.713955f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 5, 21, 30, 0, 0, DateTimeKind.Unspecified), "WsnmWloJ", 31, 13.876955f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 22, 19, 18, 0, 0, DateTimeKind.Unspecified), "gWDpiSJS", 29, 84.364105f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 9, 16, 19, 0, 0, DateTimeKind.Unspecified), "eiJsWrJr", 48, 89.02003f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 21, 5, 56, 0, 0, DateTimeKind.Unspecified), "jSpoJHAD", 41, 44.939056f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 15, 9, 1, 0, 0, DateTimeKind.Unspecified), "dWJAWpez", 14, 81.88177f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 30, 21, 37, 0, 0, DateTimeKind.Unspecified), "WzDnLWBA", 19.896223f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 25, 5, 28, 0, 0, DateTimeKind.Unspecified), "SHDBMomS", 6.7772655f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 13, 2, 7, 0, 0, DateTimeKind.Unspecified), "DAdcADJw", 32, 35.587494f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 14, 4, 8, 0, 0, DateTimeKind.Unspecified), "HDlKdbcK", 26, 85.58246f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 25, 7, 39, 0, 0, DateTimeKind.Unspecified), "epDrSWAk", 40, 12.20104f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 8, 0, 52, 0, 0, DateTimeKind.Unspecified), "jtseHteK", 3, 40.02106f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 9, 14, 2, 0, 0, DateTimeKind.Unspecified), "reoHmbDW", 41, 30.30331f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 6, 20, 13, 0, 0, DateTimeKind.Unspecified), "KcWpJWLM", 20, 94.95869f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 28, 18, 17, 0, 0, DateTimeKind.Unspecified), "JksWSASW", 37.891415f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 4, 6, 52, 0, 0, DateTimeKind.Unspecified), "zLLBSIIn", 12, 94.6775f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 2, 0, 37, 0, 0, DateTimeKind.Unspecified), "zskDJtDc", 4, 34.94217f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 5, 12, 23, 0, 0, DateTimeKind.Unspecified), "IIKWaiwk", 15, 20.973995f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 16, 17, 51, 0, 0, DateTimeKind.Unspecified), "DzssAAcu", 43, 43.307117f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 23, 19, 59, 0, 0, DateTimeKind.Unspecified), "npluiWgK", 30, 7.297907f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 54, 0, 0, DateTimeKind.Unspecified), "lpJnKAim", 9, 73.12008f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 6, 20, 54, 0, 0, DateTimeKind.Unspecified), "AvWMibWm", 37, 72.63431f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 21, 11, 59, 0, 0, DateTimeKind.Unspecified), "sSbkrssA", 19, 38.233795f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 16, 13, 4, 0, 0, DateTimeKind.Unspecified), "uIAvggAS", 47, 14.281643f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 15, 0, 58, 0, 0, DateTimeKind.Unspecified), "WaBWnjsS", 22, 68.74879f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 27, 0, 16, 0, 0, DateTimeKind.Unspecified), "nkKAAhll", 23, 39.861217f });


            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 6, 3, 18, 0, 0, DateTimeKind.Unspecified), "SSJSiKfK", 32, 80.596985f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 20, 12, 54, 0, 0, DateTimeKind.Unspecified), "BWliAnWi", 4, 78.27407f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 7, 21, 58, 0, 0, DateTimeKind.Unspecified), "jtSfDAll", 41, 49.76294f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 8, 12, 6, 0, 0, DateTimeKind.Unspecified), "DschfrJJ", 25.243422f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 14, 14, 27, 0, 0, DateTimeKind.Unspecified), "KSJrpDwD", 48, 82.01702f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 1, 3, 57, 0, 0, DateTimeKind.Unspecified), "ejWJAdJe", 8, 45.710926f });


            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 4, 22, 3, 0, 0, DateTimeKind.Unspecified), "SSsSAWsk", 43, 50.864315f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 23, 14, 55, 0, 0, DateTimeKind.Unspecified), "dwWABSLH", 27, 66.05801f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 20, 5, 42, 0, 0, DateTimeKind.Unspecified), "JzauMApA", 39, 71.075806f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 26, 16, 27, 0, 0, DateTimeKind.Unspecified), "SWhlDpKl", 43, 78.039215f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 22, 11, 55, 0, 0, DateTimeKind.Unspecified), "rSJHhKIg", 46, 41.0129f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 18, 20, 50, 0, 0, DateTimeKind.Unspecified), "JJHzsJKs", 8, 94.66316f });


            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 27, 20, 43, 0, 0, DateTimeKind.Unspecified), "pAaSSklK", 5, 67.20468f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 28, 11, 43, 0, 0, DateTimeKind.Unspecified), "AtDJbiDg", 7, 50.624535f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 31, 20, 25, 0, 0, DateTimeKind.Unspecified), "JAHhSJbS", 31, 34.801937f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 9, 2, 23, 0, 0, DateTimeKind.Unspecified), "vWloJlMz", 10, 66.13223f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 1, 21, 20, 0, 0, DateTimeKind.Unspecified), "zusoKepD", 37, 84.8552f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 7, 19, 30, 0, 0, DateTimeKind.Unspecified), "AMJesHrL", 21, 75.003685f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 6, 19, 54, 0, 0, DateTimeKind.Unspecified), "iBAsmcuz", 29, 44.629723f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 2, 22, 16, 0, 0, DateTimeKind.Unspecified), "SipbDSgw", 41, 37.11463f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 20, 11, 15, 0, 0, DateTimeKind.Unspecified), "wezSSltB", 42, 87.48896f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 27, 9, 9, 0, 0, DateTimeKind.Unspecified), "BhSAgSwJ", 25, 59.034935f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 18, 0, 3, 0, 0, DateTimeKind.Unspecified), "sugeozju", 8, 71.32951f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 27, 3, 51, 0, 0, DateTimeKind.Unspecified), "aMsDKoDK", 30, 97.018295f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 22, 23, 21, 0, 0, DateTimeKind.Unspecified), 44, 88f, 10.05f, 41, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 21, 3, 47, 0, 0, DateTimeKind.Unspecified), 93, 55f, 18.53f, 88, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 21, 18, 24, 0, 0, DateTimeKind.Unspecified), 50, 80f, 13.86f, 15, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 27, 3, 6, 0, 0, DateTimeKind.Unspecified), 59, 56f, 17.29f, 52, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 11, 20, 2, 56, 0, 0, DateTimeKind.Unspecified), 10, 41f, 1.35f, 35 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 11, 8, 34, 0, 0, DateTimeKind.Unspecified), 16, 20f, 48.73f, 77, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 26, 15, 23, 0, 0, DateTimeKind.Unspecified), 26, 6f, 28.6f, 68, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 19, 19, 15, 0, 0, DateTimeKind.Unspecified), 86, 99f, 10.92f, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 1, 4, 26, 0, 0, DateTimeKind.Unspecified), 3, 25f, 42.45f, 44, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 2, 0, 0, DateTimeKind.Unspecified), 12, 34f, 31.64f, 56, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 5, 7, 32, 0, 0, DateTimeKind.Unspecified), 54, 49f, 12.95f, 88, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 21, 16, 43, 0, 0, DateTimeKind.Unspecified), 41, 16f, 26.06f, 58, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 1, 23, 14, 0, 0, DateTimeKind.Unspecified), 91, 96f, 37.29f, 24, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 28, 4, 20, 0, 0, DateTimeKind.Unspecified), 43, 68f, 27.01f, 36, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 1, 20, 27, 0, 0, DateTimeKind.Unspecified), 33, 86f, 9.73f, 56, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, 30f, 28.24f, 58, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 13, 14, 23, 0, 0, DateTimeKind.Unspecified), 15, 14f, 6.71f, 83, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 2, 3, 31, 0, 0, DateTimeKind.Unspecified), 38, 7f, 42.69f, 48, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 31, 8, 4, 0, 0, DateTimeKind.Unspecified), 28, 27f, 46.65f, 49, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 12, 5, 21, 0, 0, DateTimeKind.Unspecified), 87, 43f, 31.55f, 78, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 28, 9, 31, 0, 0, DateTimeKind.Unspecified), 84, 13f, 12.65f, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 16, 3, 46, 0, 0, DateTimeKind.Unspecified), 99, 6f, 10.46f, 59, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 5, 6, 5, 27, 0, 0, DateTimeKind.Unspecified), 65, 54f, 5.42f, 86 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 5, 12, 22, 0, 0, DateTimeKind.Unspecified), 87, 89f, 6.11f, 82, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 5, 29, 4, 1, 0, 0, DateTimeKind.Unspecified), 93, 84f, 38.29f });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 24, 18, 14, 0, 0, DateTimeKind.Unspecified), 28, 50f, 38.67f, 67, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 29, 2, 46, 0, 0, DateTimeKind.Unspecified), 82, 23f, 44.72f, 89, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 31, 9, 33, 0, 0, DateTimeKind.Unspecified), 4, 63f, 41.86f, 88, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 26, 2, 35, 0, 0, DateTimeKind.Unspecified), 37, 51f, 18.09f, 19, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 10, 23, 2, 0, 0, DateTimeKind.Unspecified), 20, 55f, 30.34f, 33, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 8, 17, 54, 0, 0, DateTimeKind.Unspecified), 30, 18f, 27.35f, 37, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 3, 13, 12, 0, 0, DateTimeKind.Unspecified), 19, 70f, 13.59f, 30, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 17, 8, 44, 0, 0, DateTimeKind.Unspecified), 11, 21f, 39.88f, 64, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 20, 7, 58, 0, 0, DateTimeKind.Unspecified), 9, 9f, 7.13f, 8, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 8, 5, 2, 6, 0, 0, DateTimeKind.Unspecified), 58, 20f, 28.26f, 49 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 4, 7, 8, 56, 0, 0, DateTimeKind.Unspecified), 55, 79f, 6.35f, 89 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 10, 6, 9, 8, 0, 0, DateTimeKind.Unspecified), 53, 60f, 13.64f, 68 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 9, 17, 53, 0, 0, DateTimeKind.Unspecified), 60, 61f, 42.64f, 38, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 1, 6, 38, 0, 0, DateTimeKind.Unspecified), 45, 62f, 48.39f, 73, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 10, 8, 52, 0, 0, DateTimeKind.Unspecified), 24, 21f, 10.46f, 41, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 6, 16, 20, 0, 0, DateTimeKind.Unspecified), 4, 96f, 42.06f, 61, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 7, 3, 3, 13, 0, 0, DateTimeKind.Unspecified), 30, 70f, 37.98f, 59 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 23, 10, 59, 0, 0, DateTimeKind.Unspecified), 44, 51f, 26.54f, 96, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 15, 21, 10, 0, 0, DateTimeKind.Unspecified), 85, 90f, 7.95f, 24, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 28, 8, 54, 0, 0, DateTimeKind.Unspecified), 50, 12f, 15.49f, 23, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 2, 13, 24, 0, 0, DateTimeKind.Unspecified), 23, 53f, 34.04f, 60, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 4, 13, 19, 2, 0, 0, DateTimeKind.Unspecified), 32, 15f, 45.88f, 75 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 29, 19, 23, 0, 0, DateTimeKind.Unspecified), 75, 82f, 13.27f, 86, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 8, 16, 46, 0, 0, DateTimeKind.Unspecified), 86, 1f, 24.69f, 12, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 17, 18, 34, 0, 0, DateTimeKind.Unspecified), 67, 19f, 26.95f, 7, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 20, 21, 41, 0, 0, DateTimeKind.Unspecified), 11, 97f, 18.63f, 68, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 19, 1, 15, 0, 0, DateTimeKind.Unspecified), 91, 43f, 21.98f, 3, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 13, 0, 48, 0, 0, DateTimeKind.Unspecified), 36, 77f, 40.99f, 60, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 7, 24, 12, 21, 0, 0, DateTimeKind.Unspecified), 96, 9f, 4.46f, 65 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 29, 7, 5, 0, 0, DateTimeKind.Unspecified), 91, 36f, 1.68f, 64, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 7, 19, 34, 0, 0, DateTimeKind.Unspecified), 80, 95f, 25.73f, 2, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 17, 22, 19, 0, 0, DateTimeKind.Unspecified), 23, 52f, 19.27f, 79, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 17, 6, 2, 0, 0, DateTimeKind.Unspecified), 13, 86f, 4.05f, 41, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 29, 23, 5, 0, 0, DateTimeKind.Unspecified), 8, 86f, 29.74f, 21, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 3, 29, 8, 41, 0, 0, DateTimeKind.Unspecified), 22, 47f, 36.27f, 12 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 11, 5, 48, 0, 0, DateTimeKind.Unspecified), 35, 98f, 46.06f, 96, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 2, 24, 5, 49, 0, 0, DateTimeKind.Unspecified), 87, 85f, 8.85f, 93 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 24, 16, 39, 0, 0, DateTimeKind.Unspecified), 38, 25f, 36.56f, 40, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 22, 5, 24, 0, 0, DateTimeKind.Unspecified), 59, 90f, 41.15f, 2, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 1, 14, 7, 0, 0, DateTimeKind.Unspecified), 28, 98f, 26.63f, 78, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 1, 18, 19, 0, 0, DateTimeKind.Unspecified), 52, 90f, 12.9f, 23, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 5, 7, 58, 0, 0, DateTimeKind.Unspecified), 35, 22f, 9.08f, 58, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 10, 15, 15, 0, 0, DateTimeKind.Unspecified), 36, 91f, 43.72f, 70, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 8, 22, 2, 13, 0, 0, DateTimeKind.Unspecified), 56, 40f, 8.48f, 15 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 25, 11, 30, 0, 0, DateTimeKind.Unspecified), 81, 68f, 43.03f, 64, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 19, 0, 52, 0, 0, DateTimeKind.Unspecified), 31, 67f, 13.18f, 47, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 4, 20, 29, 0, 0, DateTimeKind.Unspecified), 50, 70f, 4.81f, 62, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 29, 20, 52, 0, 0, DateTimeKind.Unspecified), 93, 12f, 24.61f, 8, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 21, 23, 12, 0, 0, DateTimeKind.Unspecified), 6, 6f, 47.6f, 4, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), 74, 14.84f, 82, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 24, 6, 17, 0, 0, DateTimeKind.Unspecified), 55, 80f, 4.48f, 4, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 23, 16, 47, 0, 0, DateTimeKind.Unspecified), 52, 83f, 36.2f, 95, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 19, 8, 17, 0, 0, DateTimeKind.Unspecified), 34, 33f, 29.46f, 83, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 6, 3, 28, 0, 0, DateTimeKind.Unspecified), 3, 23f, 19.75f, 91, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 29, 14, 36, 0, 0, DateTimeKind.Unspecified), 86, 87f, 41.2f, 74, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 13, 23, 11, 0, 0, DateTimeKind.Unspecified), 78, 43f, 12.58f, 41, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 29, 7, 22, 0, 0, DateTimeKind.Unspecified), 60, 92f, 16.68f, 63, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 23, 16, 46, 0, 0, DateTimeKind.Unspecified), 83, 14f, 47.1f, 39, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 9, 8, 1, 0, 0, DateTimeKind.Unspecified), 36, 23f, 18.94f, 48, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 19, 1, 21, 0, 0, DateTimeKind.Unspecified), 28, 75f, 28.85f, 13, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 20, 16, 39, 0, 0, DateTimeKind.Unspecified), 75, 33f, 9.85f, 97, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 22, 12, 23, 0, 0, DateTimeKind.Unspecified), 26, 80f, 28.15f, 60, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 5, 24, 20, 22, 0, 0, DateTimeKind.Unspecified), 24, 17f, 19.44f, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 21, 0, 53, 0, 0, DateTimeKind.Unspecified), 64, 99f, 5.69f, 28, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 29, 6, 32, 0, 0, DateTimeKind.Unspecified), 47, 50f, 43.01f, 53, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 18, 10, 37, 0, 0, DateTimeKind.Unspecified), 78, 90f, 43.56f, 86, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 20, 3, 6, 0, 0, DateTimeKind.Unspecified), 53, 51f, 2.63f, 75, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 9, 18, 47, 0, 0, DateTimeKind.Unspecified), 32, 69f, 26.55f, 58, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 3, 21, 57, 0, 0, DateTimeKind.Unspecified), 68, 10f, 45.39f, 86, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 28, 3, 4, 0, 0, DateTimeKind.Unspecified), 28, 33f, 2.17f, 65, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 11, 10, 30, 0, 0, DateTimeKind.Unspecified), 59, 5f, 39.06f, 46, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 5, 9, 10, 33, 0, 0, DateTimeKind.Unspecified), 45, 83f, 26.46f, 93 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 30, 5, 35, 0, 0, DateTimeKind.Unspecified), 64, 41f, 7.58f, 14, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 7, 15, 7, 2, 0, 0, DateTimeKind.Unspecified), 98, 78f, 27.17f, 47 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity" },
                values: new object[] { new DateTime(2021, 10, 27, 14, 34, 0, 0, DateTimeKind.Unspecified), 48, 43f, 11.77f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 1, 9, 57, 0, 0, DateTimeKind.Unspecified), 17.98f, 2, 1.4983333f, 12f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 4, 6, 16, 0, 0, DateTimeKind.Unspecified), 34.6f, 3, 1.0484848f, 33f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 25, 21, 16, 0, 0, DateTimeKind.Unspecified), 30.05f, 5, 1.3065217f, 23f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 13, 18, 32, 0, 0, DateTimeKind.Unspecified), 20.31f, 1.8463635f, 11f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 2, 6, 23, 0, 0, DateTimeKind.Unspecified), 31f, 4, 1.24f, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 14, 8, 46, 0, 0, DateTimeKind.Unspecified), 27.51f, 4, 27.51f, 1f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 25, 17, 43, 0, 0, DateTimeKind.Unspecified), 45.94f, 5, 1.068372f, 43f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 13, 23, 33, 0, 0, DateTimeKind.Unspecified), 40.71f, 2, 1.1308333f, 36f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 20, 19, 44, 0, 0, DateTimeKind.Unspecified), 11.39f, 0.8761539f, 13f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 17, 13, 24, 0, 0, DateTimeKind.Unspecified), 28.93f, 2, 1.6072222f, 18f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 15, 22, 3, 0, 0, DateTimeKind.Unspecified), 16.06f, 4, 0.3917073f, 41f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 22, 23, 13, 0, 0, DateTimeKind.Unspecified), 36.73f, 5, 7.3459997f, 5f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 8, 17, 20, 0, 0, DateTimeKind.Unspecified), 28.08f, 4.68f, 6f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 13, 9, 51, 0, 0, DateTimeKind.Unspecified), 16.69f, 3, 2.7816668f, 6f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 28, 1, 1, 0, 0, DateTimeKind.Unspecified), 48.6f, 4, 4.0499997f, 12f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 3, 15, 22, 0, 0, DateTimeKind.Unspecified), 37.12f, 18.56f, 2f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 18, 22, 13, 0, 0, DateTimeKind.Unspecified), 16.46f, 2, 1.4963635f, 11f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 30, 4, 51, 0, 0, DateTimeKind.Unspecified), 3.14f, 4, 0.10827587f, 29f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 20, 23, 9, 0, 0, DateTimeKind.Unspecified), 32.32f, 5, 1.5390476f, 21f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 7, 10, 22, 0, 0, DateTimeKind.Unspecified), 34.33f, 2, 0.7628889f, 45f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 27, 4, 51, 0, 0, DateTimeKind.Unspecified), 42.39f, 4, 0.86510205f, 49f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 30, 20, 21, 0, 0, DateTimeKind.Unspecified), 29.07f, 0.855f, 34f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 3, 18, 55, 0, 0, DateTimeKind.Unspecified), 14.43f, 3, 2.0614285f, 7f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 15, 11, 18, 0, 0, DateTimeKind.Unspecified), 35.62f, 1.6190909f, 22f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 10, 3, 24, 0, 0, DateTimeKind.Unspecified), 2.93f, 1, 0.15421052f, 19f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 21, 13, 13, 0, 0, DateTimeKind.Unspecified), 26.09f, 1.242381f, 21f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 23, 6, 56, 0, 0, DateTimeKind.Unspecified), 25.43f, 3, 25.43f, 1f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Price", "UnitPrice" },
                values: new object[] { new DateTime(2021, 9, 6, 2, 11, 0, 0, DateTimeKind.Unspecified), 14.65f, 2.0928571f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Price", "UnitPrice" },
                values: new object[] { new DateTime(2021, 4, 9, 15, 30, 0, 0, DateTimeKind.Unspecified), 34.05f, 0.7738636f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 22, 7, 51, 0, 0, DateTimeKind.Unspecified), 7.3f, 1, 0.48666668f, 15f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice" },
                values: new object[] { new DateTime(2021, 3, 23, 5, 44, 0, 0, DateTimeKind.Unspecified), 38.69f, 4, 1.0747222f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 22, 21, 24, 0, 0, DateTimeKind.Unspecified), 1.61f, 2, 0.032857142f, 49f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 25, 22, 13, 0, 0, DateTimeKind.Unspecified), 44.22f, 4, 2.01f, 22f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 23, 14, 14, 0, 0, DateTimeKind.Unspecified), 48.65f, 1.4742424f, 33f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 24, 23, 7, 0, 0, DateTimeKind.Unspecified), 48.56f, 2, 4.4145455f, 11f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 18, 8, 9, 0, 0, DateTimeKind.Unspecified), 4.69f, 0.39083335f, 12f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 26, 23, 4, 0, 0, DateTimeKind.Unspecified), 15.5f, 4, 1.1071428f, 14f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 31, 17, 16, 0, 0, DateTimeKind.Unspecified), 36.1f, 4, 12.033333f, 3f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 11, 17, 52, 0, 0, DateTimeKind.Unspecified), 31.12f, 1.2448001f, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 26, 23, 58, 0, 0, DateTimeKind.Unspecified), 18.78f, 3, 0.89428574f, 21f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 3, 10, 40, 0, 0, DateTimeKind.Unspecified), 22.99f, 3.8316667f, 6f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice" },
                values: new object[] { new DateTime(2021, 4, 28, 19, 29, 0, 0, DateTimeKind.Unspecified), 11.38f, 2, 0.34484848f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 2, 15, 39, 0, 0, DateTimeKind.Unspecified), 20.14f, 5, 1.1188889f, 18f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 11, 9, 47, 0, 0, DateTimeKind.Unspecified), 4.14f, 0.41399997f, 10f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 23.11f, 1.3594118f, 17f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice" },
                values: new object[] { new DateTime(2021, 9, 7, 15, 9, 0, 0, DateTimeKind.Unspecified), 17.33f, 4, 1.1553333f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 3, 7, 30, 0, 0, DateTimeKind.Unspecified), 8.71f, 3, 1.2442857f, 7f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 7, 11, 46, 0, 0, DateTimeKind.Unspecified), 8.82f, 2, 0.44099998f, 20f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 30, 18, 44, 0, 0, DateTimeKind.Unspecified), 8.33f, 2, 0.23138888f, 36f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 18, 4, 41, 0, 0, DateTimeKind.Unspecified), 29.18f, 3, 1.3895239f, 21f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 18, 0, 0, DateTimeKind.Unspecified), 41.25f, 5, 2.9464285f, 14f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 25, 8, 37, 0, 0, DateTimeKind.Unspecified), 36.47f, 1.1051515f, 33f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 2, 13, 20, 0, 0, DateTimeKind.Unspecified), 46.43f, 1, 2.4436843f, 19f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 13, 5, 44, 0, 0, DateTimeKind.Unspecified), 22.9f, 2, 0.81785715f, 28f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 24, 0, 0, DateTimeKind.Unspecified), 34.34f, 5, 0.7631111f, 45f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 2, 13, 36, 0, 0, DateTimeKind.Unspecified), 13.83f, 5, 0.31431818f, 44f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 3, 11, 21, 0, 0, DateTimeKind.Unspecified), 37.17f, 4, 1.6895454f, 22f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 8, 9, 57, 0, 0, DateTimeKind.Unspecified), 21.11f, 1, 0.84440005f, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 2, 15, 8, 0, 0, DateTimeKind.Unspecified), 35.43f, 2, 1.0420588f, 34f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 9, 17, 10, 0, 0, DateTimeKind.Unspecified), 3.72f, 4, 1.24f, 3f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 20, 1, 50, 0, 0, DateTimeKind.Unspecified), 3.65f, 4, 0.08111111f, 45f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 17, 15, 31, 0, 0, DateTimeKind.Unspecified), 22.15f, 0.59864867f, 37f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 7, 8, 3, 0, 0, DateTimeKind.Unspecified), 38.61f, 1, 1.9305f, 20f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 27, 11, 53, 0, 0, DateTimeKind.Unspecified), 14.92f, 3, 0.45212123f, 33f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 26, 7, 40, 0, 0, DateTimeKind.Unspecified), 18.7f, 5, 0.45609757f, 41f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 26, 0, 39, 0, 0, DateTimeKind.Unspecified), 2.91f, 3, 0.97f, 3f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 29, 1, 0, 0, 0, DateTimeKind.Unspecified), 46.11f, 2, 1.7077779f, 27f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 16, 3, 5, 0, 0, DateTimeKind.Unspecified), 11.47f, 3, 3.8233335f, 3f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 21, 10, 43, 0, 0, DateTimeKind.Unspecified), 15.21f, 0.69136363f, 22f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 10, 16, 52, 0, 0, DateTimeKind.Unspecified), 46.16f, 5, 6.5942855f, 7f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 18, 0, 0, DateTimeKind.Unspecified), 21.19f, 3, 0.44145834f, 48f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 21, 4, 56, 0, 0, DateTimeKind.Unspecified), 35.26f, 4, 0.7195918f, 49f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 21, 10, 58, 0, 0, DateTimeKind.Unspecified), 38.69f, 1, 1.0747222f, 36f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 22, 23, 11, 0, 0, DateTimeKind.Unspecified), 44.48f, 2, 1.39f, 32f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 6, 23, 41, 0, 0, DateTimeKind.Unspecified), 29.07f, 1, 0.74538463f, 39f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 29, 9, 22, 0, 0, DateTimeKind.Unspecified), 30.74f, 1, 15.37f, 2f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 26, 4, 41, 0, 0, DateTimeKind.Unspecified), 28.44f, 2, 0.61826086f, 46f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 7, 0, 0, DateTimeKind.Unspecified), 24.06f, 1, 6.015f, 4f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 10, 11, 18, 0, 0, DateTimeKind.Unspecified), 29.24f, 3, 3.655f, 8f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 5, 12, 14, 0, 0, DateTimeKind.Unspecified), 46.25f, 4, 7.7083335f, 6f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 21, 5, 42, 0, 0, DateTimeKind.Unspecified), 7.75f, 0.59615386f, 13f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 14, 19, 10, 0, 0, DateTimeKind.Unspecified), 37.7f, 3, 9.425f, 4f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 9, 7, 26, 0, 0, DateTimeKind.Unspecified), 28.29f, 3, 28.29f, 1f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 21, 10, 49, 0, 0, DateTimeKind.Unspecified), 19.8f, 4, 0.4040816f, 49f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 18, 10, 32, 0, 0, DateTimeKind.Unspecified), 8.68f, 1, 0.6676923f, 13f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 26, 21, 6, 0, 0, DateTimeKind.Unspecified), 16.92f, 4, 1.0575f, 16f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 19, 8, 3, 0, 0, DateTimeKind.Unspecified), 31.52f, 0.8294737f, 38f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 10, 16, 28, 0, 0, DateTimeKind.Unspecified), 17.79f, 1, 1.6172729f, 11f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 7, 17, 50, 0, 0, DateTimeKind.Unspecified), 47.1f, 4.71f, 10f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 31, 0, 0, DateTimeKind.Unspecified), 24.51f, 3, 0.87535715f, 28f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 12, 20, 48, 0, 0, DateTimeKind.Unspecified), 19.12f, 2, 0.7648f, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 19, 13, 6, 0, 0, DateTimeKind.Unspecified), 3.21f, 4, 0.07829268f, 41f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 28, 2, 8, 0, 0, DateTimeKind.Unspecified), 13.47f, 0.38485715f, 35f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 3, 0, 42, 0, 0, DateTimeKind.Unspecified), 1.85f, 1, 0.10277778f, 18f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 5, 22, 7, 0, 0, DateTimeKind.Unspecified), 22.54f, 0.5008889f, 45f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 14, 19, 9, 0, 0, DateTimeKind.Unspecified), 46.42f, 4, 1.9341666f, 24f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 20, 11, 25, 0, 0, DateTimeKind.Unspecified), 4.67f, 1, 0.10377778f, 45f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 9, 3, 46, 0, 0, DateTimeKind.Unspecified), 30.13f, 4, 3.013f, 10f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 14, 2, 7, 0, 0, DateTimeKind.Unspecified), 6.38f, 1, 0.14177778f, 45f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 12, 23, 20, 0, 0, DateTimeKind.Unspecified), 21.12f, 5, 0.64000005f, 33f });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 29, 14, 15, 0, 0, DateTimeKind.Unspecified), "KfwWgdpi" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 18, 10, 45, 0, 0, DateTimeKind.Unspecified), "ohBBDAzA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 7, 1, 30, 0, 0, DateTimeKind.Unspecified), "SIMDcjop" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 30, 21, 45, 0, 0, DateTimeKind.Unspecified), "lvcSkabs" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 19, 6, 19, 0, 0, DateTimeKind.Unspecified), "uncWJJfp" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 16, 14, 43, 0, 0, DateTimeKind.Unspecified), "mMtDdfAB" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 13, 10, 12, 0, 0, DateTimeKind.Unspecified), "chswISvD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 21, 1, 54, 0, 0, DateTimeKind.Unspecified), "SisSbASn" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 24, 5, 58, 0, 0, DateTimeKind.Unspecified), "gdhmSwWd" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 51, 0, 0, DateTimeKind.Unspecified), "WWphSolg" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 30, 6, 6, 0, 0, DateTimeKind.Unspecified), "SAKdHBHK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 17, 18, 17, 0, 0, DateTimeKind.Unspecified), "AshSzuoK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 1, 1, 59, 0, 0, DateTimeKind.Unspecified), "SeADSzSD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 25, 15, 24, 0, 0, DateTimeKind.Unspecified), "inWkDmKD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 19, 21, 43, 0, 0, DateTimeKind.Unspecified), "ApDDSJWD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 23, 23, 46, 0, 0, DateTimeKind.Unspecified), "vWusplJo" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 8, 21, 8, 0, 0, DateTimeKind.Unspecified), "oBjSzmjn" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 19, 9, 13, 0, 0, DateTimeKind.Unspecified), "WiJtKzcW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 12, 19, 22, 0, 0, DateTimeKind.Unspecified), "AJIguKbd" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 9, 8, 57, 0, 0, DateTimeKind.Unspecified), "wnKsctnA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 24, 13, 52, 0, 0, DateTimeKind.Unspecified), "HwMWdbeW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 1, 6, 17, 0, 0, DateTimeKind.Unspecified), "fAJKDkID" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 10, 21, 12, 0, 0, DateTimeKind.Unspecified), "KWSWzAMD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 25, 16, 39, 0, 0, DateTimeKind.Unspecified), "DglhWLlv" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 22, 2, 48, 0, 0, DateTimeKind.Unspecified), "MWSoBdBW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 29, 14, 50, 0, 0, DateTimeKind.Unspecified), "BgaWbwen" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 21, 2, 59, 0, 0, DateTimeKind.Unspecified), "sDWnSDAh" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 10, 0, 9, 0, 0, DateTimeKind.Unspecified), "DtsAWADn" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 11, 20, 45, 0, 0, DateTimeKind.Unspecified), "wpSbwDzw" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 29, 22, 4, 0, 0, DateTimeKind.Unspecified), "mWhowkAb" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 26, 20, 5, 0, 0, DateTimeKind.Unspecified), "bWAecSWr" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 23, 6, 12, 0, 0, DateTimeKind.Unspecified), "sDShJWJW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 25, 10, 32, 0, 0, DateTimeKind.Unspecified), "gJjASdWA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 1, 7, 51, 0, 0, DateTimeKind.Unspecified), "gpaKvkHs" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 20, 6, 1, 0, 0, DateTimeKind.Unspecified), "JvJSlMkD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 7, 3, 56, 0, 0, DateTimeKind.Unspecified), "SpKMIoAS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 22, 9, 41, 0, 0, DateTimeKind.Unspecified), "dBiJaWkW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 26, 16, 34, 0, 0, DateTimeKind.Unspecified), "jKSJSMMm" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 15, 11, 14, 0, 0, DateTimeKind.Unspecified), "MsnjAdtk" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 14, 7, 47, 0, 0, DateTimeKind.Unspecified), "DHdDAAgL" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 24, 5, 34, 0, 0, DateTimeKind.Unspecified), "ssAAbArf" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 38, 0, 0, DateTimeKind.Unspecified), "kASsSwDJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 16, 20, 23, 0, 0, DateTimeKind.Unspecified), "upasaHSa" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 28, 6, 52, 0, 0, DateTimeKind.Unspecified), "iSksSWwp" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 19, 1, 9, 0, 0, DateTimeKind.Unspecified), "SenDkbkD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 24, 17, 43, 0, 0, DateTimeKind.Unspecified), "aiDWzAnb" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 4, 0, 24, 0, 0, DateTimeKind.Unspecified), "dpfiAWLW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 1, 6, 38, 0, 0, DateTimeKind.Unspecified), "vAAeADuD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 27, 12, 20, 0, 0, DateTimeKind.Unspecified), "spSLjaBt" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 1, 20, 28, 0, 0, DateTimeKind.Unspecified), "fazLWiDm" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 22, 13, 20, 0, 0, DateTimeKind.Unspecified), "WinuDosW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 29, 15, 41, 0, 0, DateTimeKind.Unspecified), "mAhDrfna" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 12, 11, 8, 0, 0, DateTimeKind.Unspecified), "WspfevLd" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 31, 23, 7, 0, 0, DateTimeKind.Unspecified), "WJdLlDel" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 4, 8, 38, 0, 0, DateTimeKind.Unspecified), "fsvBSDSh" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 31, 7, 58, 0, 0, DateTimeKind.Unspecified), "AAWALbbD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 8, 13, 33, 0, 0, DateTimeKind.Unspecified), "JvclLshn" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 12, 8, 50, 0, 0, DateTimeKind.Unspecified), "rjWLlWSm" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 7, 18, 56, 0, 0, DateTimeKind.Unspecified), "uAuAAJoW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 18, 15, 28, 0, 0, DateTimeKind.Unspecified), "DimlIgkK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 24, 11, 43, 0, 0, DateTimeKind.Unspecified), "AdeIAAuH" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 1, 10, 2, 0, 0, DateTimeKind.Unspecified), "phjDueAm" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 12, 5, 8, 0, 0, DateTimeKind.Unspecified), "groAJioa" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 25, 7, 53, 0, 0, DateTimeKind.Unspecified), "gnSWjMsj" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 4, 14, 45, 0, 0, DateTimeKind.Unspecified), "DShhAArD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 6, 23, 54, 0, 0, DateTimeKind.Unspecified), "DSKKBKuv" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 24, 7, 45, 0, 0, DateTimeKind.Unspecified), "mDewLogD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 28, 18, 7, 0, 0, DateTimeKind.Unspecified), "WeHHhSsu" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 6, 9, 22, 0, 0, DateTimeKind.Unspecified), "WaBKSKKk" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 11, 17, 47, 0, 0, DateTimeKind.Unspecified), "aWuMJJwt" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 30, 14, 4, 0, 0, DateTimeKind.Unspecified), "JovkIWsW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 11, 4, 33, 0, 0, DateTimeKind.Unspecified), "WJtvmHtI" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 2, 21, 58, 0, 0, DateTimeKind.Unspecified), "mhABkSsA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 30, 11, 34, 0, 0, DateTimeKind.Unspecified), "lJwcJlMb" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 14, 3, 23, 0, 0, DateTimeKind.Unspecified), "JoWLomDA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 15, 19, 14, 0, 0, DateTimeKind.Unspecified), "SAJptsWr" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 14, 9, 54, 0, 0, DateTimeKind.Unspecified), "uWSsAShc" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 14, 14, 19, 0, 0, DateTimeKind.Unspecified), "LAWAAoIs" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), "SrIWJDAD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 28, 9, 5, 0, 0, DateTimeKind.Unspecified), "KhJsSgfJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 24, 14, 26, 0, 0, DateTimeKind.Unspecified), "AhHnDziH" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 23, 20, 20, 0, 0, DateTimeKind.Unspecified), "gSasoSks" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 14, 11, 49, 0, 0, DateTimeKind.Unspecified), "cvWbKDzJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 11, 0, 16, 0, 0, DateTimeKind.Unspecified), "fSJSdIfA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 8, 8, 44, 0, 0, DateTimeKind.Unspecified), "SeasSDAn" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 28, 4, 23, 0, 0, DateTimeKind.Unspecified), "igSiDgAM" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 11, 19, 3, 0, 0, DateTimeKind.Unspecified), "ADoDBerA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 22, 11, 24, 0, 0, DateTimeKind.Unspecified), "AWiABsWr" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 27, 23, 12, 0, 0, DateTimeKind.Unspecified), "WoBkSASB" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 22, 22, 3, 0, 0, DateTimeKind.Unspecified), "KrLzhnsW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 30, 14, 23, 0, 0, DateTimeKind.Unspecified), "SDWBAWiS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 8, 0, 51, 0, 0, DateTimeKind.Unspecified), "JeSAsASS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 37, 0, 0, DateTimeKind.Unspecified), "DADkWAnd" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 25, 19, 46, 0, 0, DateTimeKind.Unspecified), "IKSklMKz" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 20, 20, 4, 0, 0, DateTimeKind.Unspecified), "vkDKWdSD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 22, 19, 31, 0, 0, DateTimeKind.Unspecified), "gSsKkLjJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 26, 13, 29, 0, 0, DateTimeKind.Unspecified), "WgMHWgts" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 22, 12, 29, 0, 0, DateTimeKind.Unspecified), "AASJSWwL" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 22, 16, 6, 0, 0, DateTimeKind.Unspecified), "pkzhSibz" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 15, 1, 15, 0, 0, DateTimeKind.Unspecified), "WDeWcSAS" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 10, 14, 9, 0, 0, DateTimeKind.Unspecified), "DrJfDfJo", 38, 50.42016f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 20, 4, 25, 0, 0, DateTimeKind.Unspecified), "LBAWresi", 5, 91.64009f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 17, 1, 2, 0, 0, DateTimeKind.Unspecified), "rWlDvbHv", 1, 67.31803f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 21, 1, 52, 0, 0, DateTimeKind.Unspecified), "ewWfcDvD", 40, 20.734762f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 15, 12, 23, 0, 0, DateTimeKind.Unspecified), "LKhpstAk", 22, 24.213655f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 15, 16, 22, 0, 0, DateTimeKind.Unspecified), "shpvpdeW", 25, 15.906132f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 7, 21, 39, 0, 0, DateTimeKind.Unspecified), "lMszwABB", 27, 76.53951f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 8, 14, 9, 0, 0, DateTimeKind.Unspecified), "HjaAhSlm", 2, 23.12252f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 10, 6, 3, 0, 0, DateTimeKind.Unspecified), "gAgKAcSS", 28, 50.542233f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 19, 11, 2, 0, 0, DateTimeKind.Unspecified), "JbDmSmfb", 44, 43.750885f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 7, 8, 54, 0, 0, DateTimeKind.Unspecified), "tsJhgWAW", 35, 68.623634f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 16, 2, 13, 0, 0, DateTimeKind.Unspecified), "lJShssdS", 22, 58.279007f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 29, 22, 38, 0, 0, DateTimeKind.Unspecified), "AcozADWi", 29, 42.434135f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 31, 2, 54, 0, 0, DateTimeKind.Unspecified), "dAWzrnIu", 48, 19.37813f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 17, 11, 27, 0, 0, DateTimeKind.Unspecified), "dDgWKefh", 30, 81.69213f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 6, 6, 39, 0, 0, DateTimeKind.Unspecified), "throuHDu", 19, 44.995594f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 12, 8, 4, 0, 0, DateTimeKind.Unspecified), "WArHWWeA", 27, 58.324013f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 14, 21, 14, 0, 0, DateTimeKind.Unspecified), "WAdSocSW", 33, 93.93622f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 10, 1, 20, 0, 0, DateTimeKind.Unspecified), "IletlocS", 24, 63.24037f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 2, 10, 33, 0, 0, DateTimeKind.Unspecified), "SgcWjtKv", 26, 43.170887f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 5, 16, 35, 0, 0, DateTimeKind.Unspecified), "MnwSAgzt", 24, 70.61897f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 19, 8, 31, 0, 0, DateTimeKind.Unspecified), "MmedasLp", 39, 60.77546f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 7, 9, 15, 0, 0, DateTimeKind.Unspecified), "DtAhDkiW", 6, 91.20554f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 29, 1, 12, 0, 0, DateTimeKind.Unspecified), "HASSJoWp", 37, 42.207535f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 28, 20, 3, 0, 0, DateTimeKind.Unspecified), "AHSaDabH", 34, 83.92869f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 18, 3, 11, 0, 0, DateTimeKind.Unspecified), "ISwWjDIw", 13, 97.17492f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 22, 2, 47, 0, 0, DateTimeKind.Unspecified), "oJmIAWLA", 42.037876f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 19, 10, 15, 0, 0, DateTimeKind.Unspecified), "fWWvvJJW", 47, 56.104614f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 20, 1, 3, 0, 0, DateTimeKind.Unspecified), "DWgsJLSD", 32, 73.84686f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 21, 4, 31, 0, 0, DateTimeKind.Unspecified), "sSsLJkwH", 41, 37.999565f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 56, 0, 0, DateTimeKind.Unspecified), "WlBJbAzp", 40, 94.1833f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 18, 0, 54, 0, 0, DateTimeKind.Unspecified), "SbMWbWmj", 36, 85.27838f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), "WAtvLsJs", 21, 97.13665f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 29, 11, 58, 0, 0, DateTimeKind.Unspecified), "aJscmDSJ", 25, 32.709248f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 23, 22, 4, 0, 0, DateTimeKind.Unspecified), "opJidAKS", 26, 97.14394f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 2, 1, 17, 0, 0, DateTimeKind.Unspecified), "rSBAAAAJ", 28, 44.430927f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 28, 18, 7, 0, 0, DateTimeKind.Unspecified), "DiJASdSl", 40, 4.4388647f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 19, 5, 33, 0, 0, DateTimeKind.Unspecified), "AeAouudL", 28, 54.44473f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 6, 22, 25, 0, 0, DateTimeKind.Unspecified), "dbwSAdff", 41, 98.05505f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 3, 18, 9, 0, 0, DateTimeKind.Unspecified), "pHdaMbDe", 39, 43.92093f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 21, 23, 27, 0, 0, DateTimeKind.Unspecified), "mAsdeecl", 7, 97.90655f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 8, 17, 53, 0, 0, DateTimeKind.Unspecified), "wAWDanpS", 21, 42.671192f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 1, 10, 25, 0, 0, DateTimeKind.Unspecified), "KAJMsWJD", 1, 34.13723f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 17, 6, 48, 0, 0, DateTimeKind.Unspecified), "cWKiDIrs", 12, 63.384167f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 13, 0, 36, 0, 0, DateTimeKind.Unspecified), "KWbWADJD", 26, 62.927307f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 30, 18, 34, 0, 0, DateTimeKind.Unspecified), "Wmlstgec", 21, 27.494602f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 21, 14, 27, 0, 0, DateTimeKind.Unspecified), "rgmkvJSw", 26, 82.84804f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 25, 23, 14, 0, 0, DateTimeKind.Unspecified), "SSbpDJmH", 13, 40.714325f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 14, 13, 15, 0, 0, DateTimeKind.Unspecified), "ilvklJbW", 3, 52.23211f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 30, 15, 28, 0, 0, DateTimeKind.Unspecified), "WJSjBBgA", 27, 45.1382f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 1, 11, 4, 0, 0, DateTimeKind.Unspecified), "WDSAKfbS", 18, 11.99213f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 6, 14, 11, 0, 0, DateTimeKind.Unspecified), "hKADWzwd", 20, 59.080627f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 28, 2, 26, 0, 0, DateTimeKind.Unspecified), "DKjhAJIS", 30, 69.79905f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 14, 15, 33, 0, 0, DateTimeKind.Unspecified), "fwlWWzAn", 23.209631f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 6, 6, 44, 0, 0, DateTimeKind.Unspecified), "IeJacufc", 3.4533648f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 20, 5, 38, 0, 0, DateTimeKind.Unspecified), "jwdWJbIB", 29, 16.071268f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 11, 19, 9, 0, 0, DateTimeKind.Unspecified), "hAjDsDlI", 31, 5.8005166f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 18, 23, 50, 0, 0, DateTimeKind.Unspecified), "AfJdJmnS", 20, 79.82175f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 24, 5, 49, 0, 0, DateTimeKind.Unspecified), "JDjJIwbW", 24, 53.326286f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 26, 9, 11, 0, 0, DateTimeKind.Unspecified), "zgSkIgWd", 14, 26.48305f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 22, 13, 34, 0, 0, DateTimeKind.Unspecified), "HAJIlSAI", 37, 64.92184f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 18, 11, 23, 0, 0, DateTimeKind.Unspecified), "LSoSSbiS", 54.58983f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 22, 13, 6, 0, 0, DateTimeKind.Unspecified), "kschLASW", 16, 36.113365f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 18, 1, 31, 0, 0, DateTimeKind.Unspecified), "LWBkbbaK", 49, 54.820297f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 13, 13, 5, 0, 0, DateTimeKind.Unspecified), "gWviJswH", 2, 37.608795f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), "StbDidWv", 39, 37.811214f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 8, 19, 13, 0, 0, DateTimeKind.Unspecified), "WaazeIlS", 43, 74.68557f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 29, 10, 40, 0, 0, DateTimeKind.Unspecified), "DSWSvSKS", 45, 90.59562f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 7, 4, 49, 0, 0, DateTimeKind.Unspecified), "SSISJapJ", 27, 52.84885f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 16, 10, 9, 0, 0, DateTimeKind.Unspecified), "JtAsMJAK", 12, 51.022305f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 8, 12, 32, 0, 0, DateTimeKind.Unspecified), "JfmaaKwr", 23, 97.400215f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 24, 2, 30, 0, 0, DateTimeKind.Unspecified), "zWjHALlA", 34, 31.06231f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 8, 22, 48, 0, 0, DateTimeKind.Unspecified), "JkhsnaIW", 35, 12.268239f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 7, 7, 10, 0, 0, DateTimeKind.Unspecified), "AmKAoWSl", 33, 12.1415615f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 14, 11, 6, 0, 0, DateTimeKind.Unspecified), "zjaowJIm", 41, 12.687605f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 25, 22, 42, 0, 0, DateTimeKind.Unspecified), "lwAAISmb", 43, 62.916626f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 15, 22, 6, 0, 0, DateTimeKind.Unspecified), "gDLWDcAJ", 38, 89.97816f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 21, 2, 26, 0, 0, DateTimeKind.Unspecified), "popKDWbH", 88.98028f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 15, 0, 35, 0, 0, DateTimeKind.Unspecified), "ASloSSsA", 18, 53.91096f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 27, 1, 28, 0, 0, DateTimeKind.Unspecified), "uJkIAJhc", 48, 77.12414f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 25, 12, 43, 0, 0, DateTimeKind.Unspecified), "DBKSSgSt", 34, 74.25824f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 27, 3, 33, 0, 0, DateTimeKind.Unspecified), "AuDjzcnz", 32, 69.56274f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 5, 21, 0, 0, 0, DateTimeKind.Unspecified), "sLcAvWjj", 19, 47.10277f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 23, 9, 35, 0, 0, DateTimeKind.Unspecified), "fWoWLAfz", 41, 17.222506f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 17, 17, 26, 0, 0, DateTimeKind.Unspecified), "hnKsloSS", 4, 99.27023f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 1, 7, 44, 0, 0, DateTimeKind.Unspecified), "oLWzWnvs", 17, 58.247578f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 23, 22, 28, 0, 0, DateTimeKind.Unspecified), "JKrHSnJb", 7, 74.55543f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 24, 15, 26, 0, 0, DateTimeKind.Unspecified), "rsWWLSBa", 11, 33.40493f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 26, 5, 13, 0, 0, DateTimeKind.Unspecified), "oBbinIkh", 49, 12.184316f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 4, 16, 26, 0, 0, DateTimeKind.Unspecified), "fpKDtJlL", 18, 13.770631f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 21, 6, 7, 0, 0, DateTimeKind.Unspecified), "KAddszJA", 17, 56.100075f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 13, 18, 17, 0, 0, DateTimeKind.Unspecified), "SJgJWJJs", 39, 86.70726f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 23, 23, 44, 0, 0, DateTimeKind.Unspecified), "oWhvlmeI", 15, 8.749629f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 9, 13, 14, 0, 0, DateTimeKind.Unspecified), "KjBAScHD", 25, 34.241337f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 10, 4, 35, 0, 0, DateTimeKind.Unspecified), "gJvAJsSL", 25, 43.654514f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 2, 12, 4, 0, 0, DateTimeKind.Unspecified), "AiBDWrss", 7, 44.206444f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 20, 4, 47, 0, 0, DateTimeKind.Unspecified), "zkoWWIJo", 4, 5.1187506f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 15, 8, 53, 0, 0, DateTimeKind.Unspecified), "LmDiJfhD", 48, 11.474103f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 4, 17, 42, 0, 0, DateTimeKind.Unspecified), "eBJArWsS", 11, 20.44738f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 25, 16, 36, 0, 0, DateTimeKind.Unspecified), "SpAcSKgk", 24, 3.0404582f });
        }
    }
}
