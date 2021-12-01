using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class addUnitPriceToIngredients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "UnitPrice",
                table: "Ingredients",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 7, 23, 25, 0, 0, DateTimeKind.Unspecified), 13, 34.62f, 17, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 7, 0, 10, 0, 0, DateTimeKind.Unspecified), 50, 33.06f, 24, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 5, 11, 3, 0, 0, DateTimeKind.Unspecified), 32, 33.74f, 32, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 24, 4, 27, 0, 0, DateTimeKind.Unspecified), 39, 25.35f, 26, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 8, 6, 16, 0, 0, DateTimeKind.Unspecified), 72, 30.23f, 62, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 27, 8, 13, 0, 0, DateTimeKind.Unspecified), 25, 20.76f, 99, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 4, 20, 8, 0, 0, DateTimeKind.Unspecified), 5, 8.52f, 99, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 9, 9, 9, 19, 0, 0, DateTimeKind.Unspecified), 42, 23.43f, 51 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 17, 11, 22, 0, 0, DateTimeKind.Unspecified), 48, 28.34f, 22, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 8, 5, 13, 35, 0, 0, DateTimeKind.Unspecified), 56, 10.02f, 13 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 21, 8, 23, 0, 0, DateTimeKind.Unspecified), 74, 13.18f, 38, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 8, 24, 3, 41, 0, 0, DateTimeKind.Unspecified), 52, 23.63f, 45 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 4, 26, 12, 42, 0, 0, DateTimeKind.Unspecified), 9, 45.54f, 98 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 29, 7, 42, 0, 0, DateTimeKind.Unspecified), 16, 7.72f, 27, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 28, 8, 55, 0, 0, DateTimeKind.Unspecified), 93, 5.44f, 84, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 10, 18, 13, 0, 0, DateTimeKind.Unspecified), 16, 14.02f, 14, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 5, 8, 11, 0, 0, DateTimeKind.Unspecified), 7, 19.56f, 43, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 8, 22, 10, 0, 0, DateTimeKind.Unspecified), 79, 49.43f, 25, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 17, 20, 16, 0, 0, DateTimeKind.Unspecified), 95, 41.43f, 99, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 5, 10, 44, 0, 0, DateTimeKind.Unspecified), 58, 2.27f, 13, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 23, 9, 21, 0, 0, DateTimeKind.Unspecified), 42, 24.68f, 96, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 20, 2, 2, 0, 0, DateTimeKind.Unspecified), 66, 40.5f, 45, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 5, 29, 2, 11, 0, 0, DateTimeKind.Unspecified), 25, 22.76f, 30 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 24, 13, 32, 0, 0, DateTimeKind.Unspecified), 70, 17.41f, 92, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 16, 20, 32, 0, 0, DateTimeKind.Unspecified), 18, 35.15f, 48, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 10, 20, 36, 0, 0, DateTimeKind.Unspecified), 11, 33.53f, 88, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 10, 13, 21, 30, 0, 0, DateTimeKind.Unspecified), 13, 1.09f, 55 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 29, 12, 1, 0, 0, DateTimeKind.Unspecified), 59, 35.22f, 1, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 2, 4, 37, 0, 0, DateTimeKind.Unspecified), 97, 24.48f, 59, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 23, 21, 23, 0, 0, DateTimeKind.Unspecified), 53, 4.86f, 75, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 30, 14, 32, 0, 0, DateTimeKind.Unspecified), 24, 31.46f, 42, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 14, 0, 48, 0, 0, DateTimeKind.Unspecified), 71, 16.33f, 79, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 23, 17, 29, 0, 0, DateTimeKind.Unspecified), 1, 15.95f, 34, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 30, 21, 14, 0, 0, DateTimeKind.Unspecified), 24, 17.87f, 17, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 8, 20, 9, 0, 0, DateTimeKind.Unspecified), 99, 6.72f, 34, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 23, 4, 28, 0, 0, DateTimeKind.Unspecified), 70, 12.87f, 50, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 20, 2, 58, 0, 0, DateTimeKind.Unspecified), 5, 39.54f, 36, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 8, 22, 10, 0, 0, DateTimeKind.Unspecified), 51, 27.63f, 31, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 25, 15, 42, 0, 0, DateTimeKind.Unspecified), 27, 19.75f, 29, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 9, 7, 10, 0, 0, DateTimeKind.Unspecified), 68, 26.07f, 58, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 7, 1, 23, 19, 0, 0, DateTimeKind.Unspecified), 18, 10.29f, 51 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 21, 0, 0, DateTimeKind.Unspecified), 12, 45.23f, 43, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 1, 3, 11, 25, 0, 0, DateTimeKind.Unspecified), 48, 23.72f, 9 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 7, 7, 18, 0, 0, DateTimeKind.Unspecified), 21, 37.83f, 29, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 8, 8, 17, 26, 0, 0, DateTimeKind.Unspecified), 70, 35.76f, 66 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 25, 19, 56, 0, 0, DateTimeKind.Unspecified), 61, 19.36f, 7, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 11, 4, 8, 9, 0, 0, DateTimeKind.Unspecified), 18, 8.76f, 82 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 5, 5, 19, 33, 0, 0, DateTimeKind.Unspecified), 85, 25.88f, 18 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 4, 15, 19, 45, 0, 0, DateTimeKind.Unspecified), 60, 16.68f, 20 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 22, 9, 27, 0, 0, DateTimeKind.Unspecified), 81, 33.65f, 80, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 8, 4, 9, 18, 0, 0, DateTimeKind.Unspecified), 93, 35.98f, 37 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 7, 16, 31, 0, 0, DateTimeKind.Unspecified), 75, 27.59f, 81, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 2, 0, 5, 0, 0, DateTimeKind.Unspecified), 33, 34.63f, 91, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 5, 0, 14, 0, 0, DateTimeKind.Unspecified), 71, 43.13f, 44, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 18, 21, 23, 0, 0, DateTimeKind.Unspecified), 39, 2.74f, 7, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 6, 21, 59, 0, 0, DateTimeKind.Unspecified), 95, 36.3f, 25, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 12, 21, 30, 0, 0, DateTimeKind.Unspecified), 48, 9.32f, 89, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 11, 6, 7, 55, 0, 0, DateTimeKind.Unspecified), 42, 24.29f, 71 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 28, 9, 40, 0, 0, DateTimeKind.Unspecified), 6, 36.55f, 44, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 14, 10, 43, 0, 0, DateTimeKind.Unspecified), 13, 2.72f, 48, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 9, 8, 7, 0, 0, DateTimeKind.Unspecified), 6, 28.09f, 66, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 11, 4, 42, 0, 0, DateTimeKind.Unspecified), 44, 35.54f, 42, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 25, 13, 59, 0, 0, DateTimeKind.Unspecified), 3, 12.31f, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 3, 23, 3, 0, 0, DateTimeKind.Unspecified), 15, 19.35f, 44, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 11, 5, 7, 35, 0, 0, DateTimeKind.Unspecified), 22, 29.25f, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 11, 0, 0, DateTimeKind.Unspecified), 66, 24.64f, 1, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 24, 15, 28, 0, 0, DateTimeKind.Unspecified), 92, 1.68f, 13, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 19, 11, 33, 0, 0, DateTimeKind.Unspecified), 90, 5.94f, 83, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 1, 6, 4, 26, 0, 0, DateTimeKind.Unspecified), 72, 47.95f, 28 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 10, 20, 15, 15, 0, 0, DateTimeKind.Unspecified), 81, 21.31f, 41 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 30, 10, 1, 0, 0, DateTimeKind.Unspecified), 74, 34.5f, 34, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 3, 14, 6, 28, 0, 0, DateTimeKind.Unspecified), 47, 16.63f, 44 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 9, 13, 5, 0, 0, DateTimeKind.Unspecified), 95, 3.56f, 76, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 7, 11, 24, 0, 0, DateTimeKind.Unspecified), 3, 28.7f, 94, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 9, 11, 21, 59, 0, 0, DateTimeKind.Unspecified), 7, 22.49f, 54 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 17, 14, 37, 0, 0, DateTimeKind.Unspecified), 28, 32.23f, 31, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 19, 18, 52, 0, 0, DateTimeKind.Unspecified), 25, 9.98f, 19, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 14, 20, 6, 0, 0, DateTimeKind.Unspecified), 25, 25.09f, 38, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 22, 0, 35, 0, 0, DateTimeKind.Unspecified), 58, 23.56f, 37, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 4, 4, 12, 26, 0, 0, DateTimeKind.Unspecified), 67, 20.73f, 32 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 57, 0, 0, DateTimeKind.Unspecified), 25, 36.9f, 39, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 13, 16, 15, 0, 0, DateTimeKind.Unspecified), 30, 10.55f, 27, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 10, 8, 19, 10, 0, 0, DateTimeKind.Unspecified), 82, 5.59f, 16 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 20, 12, 4, 0, 0, DateTimeKind.Unspecified), 77, 4.9f, 52, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 12, 20, 20, 0, 0, DateTimeKind.Unspecified), 52, 24.52f, 70, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 10, 8, 17, 0, 0, DateTimeKind.Unspecified), 60, 44.39f, 95, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 22, 17, 23, 0, 0, DateTimeKind.Unspecified), 89, 45.15f, 64, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 9, 23, 20, 59, 0, 0, DateTimeKind.Unspecified), 52, 14.87f, 93 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 20, 22, 45, 0, 0, DateTimeKind.Unspecified), 5, 47.8f, 8, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 15, 6, 29, 0, 0, DateTimeKind.Unspecified), 49, 43.38f, 54, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 10, 6, 5, 27, 0, 0, DateTimeKind.Unspecified), 60, 24.9f, 54 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 1, 14, 15, 0, 0, DateTimeKind.Unspecified), 77, 10.86f, 86, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 26, 6, 1, 0, 0, DateTimeKind.Unspecified), 42, 40.92f, 66, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 28, 20, 27, 0, 0, DateTimeKind.Unspecified), 91, 47.93f, 27, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 4, 25, 15, 11, 0, 0, DateTimeKind.Unspecified), 50, 10.52f, 99 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 9, 1, 6, 39, 0, 0, DateTimeKind.Unspecified), 56, 34.5f, 65 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 9, 21, 25, 0, 0, DateTimeKind.Unspecified), 74, 25.82f, 47, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 2, 8, 15, 0, 0, DateTimeKind.Unspecified), 41, 1.77f, 4, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 50, 0, 0, DateTimeKind.Unspecified), 32, 21.7f, 17, 4 });

            migrationBuilder.InsertData(
                table: "IngredientRecipes",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { 52, new DateTime(2021, 10, 16, 18, 11, 0, 0, DateTimeKind.Unspecified), 47, 0f, 22.01f, 81, 5 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 21, 3, 40, 0, 0, DateTimeKind.Unspecified), 49.9f, 5, 1.0395833f, 48f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 8, 10, 19, 0, 0, DateTimeKind.Unspecified), 3.17f, 4, 0.07547619f, 42f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 11, 4, 52, 0, 0, DateTimeKind.Unspecified), 47.2f, 1, 1.8153846f, 26f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 18, 5, 41, 0, 0, DateTimeKind.Unspecified), 15.43f, 2, 0.964375f, 16f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 11, 16, 8, 0, 0, DateTimeKind.Unspecified), 33.67f, 3, 5.611666f, 6f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 8, 11, 22, 0, 0, DateTimeKind.Unspecified), 11.68f, 4, 0.4672f, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 28, 15, 55, 0, 0, DateTimeKind.Unspecified), 12.64f, 2, 0.46814817f, 27f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 13, 23, 30, 0, 0, DateTimeKind.Unspecified), 25.34f, 1, 0.5508696f, 46f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 7, 8, 21, 0, 0, DateTimeKind.Unspecified), 31.87f, 0.79675f, 40f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 30, 5, 49, 0, 0, DateTimeKind.Unspecified), 23.52f, 4, 0.60307693f, 39f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 24, 9, 25, 0, 0, DateTimeKind.Unspecified), 19.04f, 1, 2.38f, 8f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 11, 19, 59, 0, 0, DateTimeKind.Unspecified), 16.49f, 0.5686207f, 29f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 2, 11, 9, 0, 0, DateTimeKind.Unspecified), 38.68f, 1.2893333f, 30f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 13, 23, 10, 0, 0, DateTimeKind.Unspecified), 27.24f, 1, 2.4763637f, 11f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 5, 0, 49, 0, 0, DateTimeKind.Unspecified), 20.23f, 5, 1.1238889f, 18f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 17, 13, 12, 0, 0, DateTimeKind.Unspecified), 31.82f, 4, 2.6516666f, 12f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Price", "UnitPrice" },
                values: new object[] { new DateTime(2021, 4, 11, 6, 49, 0, 0, DateTimeKind.Unspecified), 14.31f, 0.4471875f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 14, 4, 55, 0, 0, DateTimeKind.Unspecified), 31.88f, 2, 0.91085714f, 35f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 26, 13, 21, 0, 0, DateTimeKind.Unspecified), 44.36f, 2, 2.0163636f, 22f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 31, 22, 3, 0, 0, DateTimeKind.Unspecified), 26.25f, 4, 1.1931819f, 22f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 17, 6, 34, 0, 0, DateTimeKind.Unspecified), 3.62f, 3, 0.27846152f, 13f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 12, 3, 3, 0, 0, DateTimeKind.Unspecified), 36.42f, 1, 1.0711764f, 34f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 25, 9, 47, 0, 0, DateTimeKind.Unspecified), 33.48f, 1, 16.74f, 2f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 28, 3, 3, 0, 0, DateTimeKind.Unspecified), 8.38f, 5, 1.3966666f, 6f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 8, 2, 35, 0, 0, DateTimeKind.Unspecified), 40.54f, 2, 0.827347f, 49f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 24, 23, 19, 0, 0, DateTimeKind.Unspecified), 42.17f, 3, 2.8113332f, 15f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 8, 15, 1, 0, 0, DateTimeKind.Unspecified), 48.46f, 1.514375f, 32f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 15, 2, 54, 0, 0, DateTimeKind.Unspecified), 39.04f, 2, 1.0010257f, 39f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 1, 0, 50, 0, 0, DateTimeKind.Unspecified), 39.62f, 3, 2.201111f, 18f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 2, 23, 26, 0, 0, DateTimeKind.Unspecified), 28.4f, 3, 0.6454545f, 44f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 13, 16, 10, 0, 0, DateTimeKind.Unspecified), 31.26f, 2, 0.8226316f, 38f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 15, 7, 37, 0, 0, DateTimeKind.Unspecified), 43.47f, 5, 0.8871429f, 49f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 17, 17, 21, 0, 0, DateTimeKind.Unspecified), 12.88f, 0.71555555f, 18f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 19, 6, 13, 0, 0, DateTimeKind.Unspecified), 13.43f, 3, 0.30522728f, 44f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 6, 12, 39, 0, 0, DateTimeKind.Unspecified), 16.38f, 1, 0.38093022f, 43f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 24, 2, 44, 0, 0, DateTimeKind.Unspecified), 39.52f, 4, 1.3627586f, 29f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 22, 17, 33, 0, 0, DateTimeKind.Unspecified), 35.87f, 1.6304545f, 22f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 29, 20, 44, 0, 0, DateTimeKind.Unspecified), 1.12f, 5, 1.12f, 1f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 31, 21, 14, 0, 0, DateTimeKind.Unspecified), 33.14f, 5, 1.7442105f, 19f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 18, 6, 0, 0, 0, DateTimeKind.Unspecified), 21.15f, 5, 10.575f, 2f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 29, 5, 19, 0, 0, DateTimeKind.Unspecified), 23.13f, 3, 0.5028261f, 46f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 19, 22, 27, 0, 0, DateTimeKind.Unspecified), 34.79f, 1, 0.79068184f, 44f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 24, 22, 49, 0, 0, DateTimeKind.Unspecified), 37.49f, 2, 1.1026471f, 34f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 29, 11, 10, 0, 0, DateTimeKind.Unspecified), 27.61f, 6.9025f, 4f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 13, 17, 44, 0, 0, DateTimeKind.Unspecified), 33.14f, 1.4408696f, 23f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 18, 14, 41, 0, 0, DateTimeKind.Unspecified), 2.46f, 2, 0.098400004f, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 27, 10, 18, 0, 0, DateTimeKind.Unspecified), 44.95f, 2, 2.6441176f, 17f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 13, 4, 33, 0, 0, DateTimeKind.Unspecified), 3.28f, 2, 0.14260869f, 23f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 7, 21, 13, 0, 0, DateTimeKind.Unspecified), 18.37f, 4, 0.45925003f, 40f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 6, 13, 7, 0, 0, DateTimeKind.Unspecified), 29.68f, 3, 0.6452174f, 46f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 3, 10, 47, 0, 0, DateTimeKind.Unspecified), 48.08f, 5, 1.2328205f, 39f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 20, 21, 45, 0, 0, DateTimeKind.Unspecified), 22.82f, 2, 0.53069764f, 43f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 8, 1, 13, 0, 0, DateTimeKind.Unspecified), 4.28f, 0.093043484f, 46f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 17, 4, 48, 0, 0, DateTimeKind.Unspecified), 35.03f, 1.5230434f, 23f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 28, 22, 39, 0, 0, DateTimeKind.Unspecified), 32.81f, 4, 16.405f, 2f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 37, 0, 0, DateTimeKind.Unspecified), 23.77f, 5, 1.485625f, 16f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 17, 0, 32, 0, 0, DateTimeKind.Unspecified), 2.51f, 0.061219513f, 41f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 14, 1, 48, 0, 0, DateTimeKind.Unspecified), 40.41f, 3, 1.5542308f, 26f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 11, 3, 6, 0, 0, DateTimeKind.Unspecified), 11.55f, 3, 11.55f, 1f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 17, 16, 49, 0, 0, DateTimeKind.Unspecified), 33.97f, 0.9991177f, 34f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 28, 20, 21, 0, 0, DateTimeKind.Unspecified), 4.29f, 4, 1.43f, 3f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), 18.19f, 1, 0.7579167f, 24f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 15, 22, 39, 0, 0, DateTimeKind.Unspecified), 45.79f, 45.79f, 1f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 5, 8, 54, 0, 0, DateTimeKind.Unspecified), 32.19f, 1, 1.4631817f, 22f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 17, 13, 39, 0, 0, DateTimeKind.Unspecified), 38.33f, 3, 1.5332f, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 10, 1, 48, 0, 0, DateTimeKind.Unspecified), 1.69f, 4, 0.14083333f, 12f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 23, 2, 37, 0, 0, DateTimeKind.Unspecified), 38.94f, 9.735f, 4f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 12, 4, 56, 0, 0, DateTimeKind.Unspecified), 1.5f, 4, 0.083333336f, 18f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 8, 10, 31, 0, 0, DateTimeKind.Unspecified), 7.97f, 2, 0.24151514f, 33f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 14, 22, 4, 0, 0, DateTimeKind.Unspecified), 36.54f, 3, 6.09f, 6f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 26, 19, 39, 0, 0, DateTimeKind.Unspecified), 2.49f, 2, 0.17785715f, 14f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 11, 10, 5, 0, 0, DateTimeKind.Unspecified), 20.73f, 2, 1.2194117f, 17f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 14, 7, 40, 0, 0, DateTimeKind.Unspecified), 6.81f, 0.681f, 10f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 6, 7, 21, 0, 0, DateTimeKind.Unspecified), 23.74f, 1, 7.9133334f, 3f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 3, 16, 43, 0, 0, DateTimeKind.Unspecified), 3.38f, 5, 3.38f, 1f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 28, 8, 7, 0, 0, DateTimeKind.Unspecified), 7.33f, 5, 0.458125f, 16f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 21, 4, 14, 0, 0, DateTimeKind.Unspecified), 22.35f, 4, 0.6984375f, 32f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 23, 22, 36, 0, 0, DateTimeKind.Unspecified), 27.28f, 1, 1.1366667f, 24f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 18, 9, 19, 0, 0, DateTimeKind.Unspecified), 12.67f, 5, 0.28155556f, 45f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 21, 11, 54, 0, 0, DateTimeKind.Unspecified), 21.22f, 2, 1.5157143f, 14f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 29, 13, 0, 0, 0, DateTimeKind.Unspecified), 29.05f, 1, 14.525f, 2f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 26, 10, 27, 0, 0, DateTimeKind.Unspecified), 15.02f, 1, 1.3654546f, 11f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 10, 5, 41, 0, 0, DateTimeKind.Unspecified), 45.27f, 1, 7.545f, 6f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 23, 11, 42, 0, 0, DateTimeKind.Unspecified), 26.69f, 0.76257145f, 35f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 28, 12, 39, 0, 0, DateTimeKind.Unspecified), 9.87f, 2, 0.3525f, 28f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 23, 18, 24, 0, 0, DateTimeKind.Unspecified), 5.67f, 3, 0.23625f, 24f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 5, 6, 23, 0, 0, DateTimeKind.Unspecified), 17.98f, 4, 3.596f, 5f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 1, 12, 33, 0, 0, DateTimeKind.Unspecified), 41.54f, 0.8654167f, 48f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 21, 7, 34, 0, 0, DateTimeKind.Unspecified), 5.99f, 2, 0.14609756f, 41f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 30, 12, 1, 0, 0, DateTimeKind.Unspecified), 15.11f, 5, 3.0219998f, 5f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 8, 2, 12, 0, 0, DateTimeKind.Unspecified), 7.25f, 1, 0.19078948f, 38f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 9, 15, 44, 0, 0, DateTimeKind.Unspecified), 9.15f, 0.26911762f, 34f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 19, 17, 38, 0, 0, DateTimeKind.Unspecified), 48.21f, 5, 2.8358822f, 17f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 15, 4, 25, 0, 0, DateTimeKind.Unspecified), 32.24f, 0.6859575f, 47f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 19, 9, 38, 0, 0, DateTimeKind.Unspecified), 28.22f, 1, 0.656279f, 43f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 15, 16, 19, 0, 0, DateTimeKind.Unspecified), 46.41f, 1, 1.6575f, 28f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 4, 23, 47, 0, 0, DateTimeKind.Unspecified), 15.27f, 5, 1.2725f, 12f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 18, 13, 54, 0, 0, DateTimeKind.Unspecified), 43.62f, 2.181f, 20f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 15, 21, 31, 0, 0, DateTimeKind.Unspecified), 38.14f, 3, 0.8475555f, 45f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 2, 15, 55, 0, 0, DateTimeKind.Unspecified), 45.21f, 2, 1.4128125f, 32f });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 18, 3, 13, 0, 0, DateTimeKind.Unspecified), "AtSgSogc" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 9, 10, 37, 0, 0, DateTimeKind.Unspecified), "bAHJDhSK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 11, 19, 49, 0, 0, DateTimeKind.Unspecified), "lJuJDAAS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 6, 21, 45, 0, 0, DateTimeKind.Unspecified), "IgKdhAbA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 12, 16, 4, 0, 0, DateTimeKind.Unspecified), "DemfSDSW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 2, 21, 10, 0, 0, DateTimeKind.Unspecified), "gkgDaAWe" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 8, 6, 40, 0, 0, DateTimeKind.Unspecified), "eKIDJzsi" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 8, 20, 38, 0, 0, DateTimeKind.Unspecified), "AirDJdMh" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 26, 6, 16, 0, 0, DateTimeKind.Unspecified), "HJszMDMA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 16, 9, 26, 0, 0, DateTimeKind.Unspecified), "WWwtKASf" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 23, 5, 10, 0, 0, DateTimeKind.Unspecified), "ssWtcDbe" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 5, 18, 49, 0, 0, DateTimeKind.Unspecified), "Jemwjvcd" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 10, 20, 29, 0, 0, DateTimeKind.Unspecified), "pDAmsrjK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 15, 17, 2, 0, 0, DateTimeKind.Unspecified), "LfSnSeWS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 19, 16, 9, 0, 0, DateTimeKind.Unspecified), "BlineDeg" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 24, 16, 53, 0, 0, DateTimeKind.Unspecified), "AmIInzDm" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 5, 13, 59, 0, 0, DateTimeKind.Unspecified), "KvcKDtJa" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 16, 12, 52, 0, 0, DateTimeKind.Unspecified), "nvBSAKhD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 1, 17, 9, 0, 0, DateTimeKind.Unspecified), "wpSWmKWI" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 30, 19, 57, 0, 0, DateTimeKind.Unspecified), "MWBeDtov" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 14, 15, 52, 0, 0, DateTimeKind.Unspecified), "DKSDcbSh" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 8, 19, 34, 0, 0, DateTimeKind.Unspecified), "whaWWgzS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 21, 18, 24, 0, 0, DateTimeKind.Unspecified), "forWABDI" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 8, 21, 12, 0, 0, DateTimeKind.Unspecified), "zmHkSHwJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 29, 6, 15, 0, 0, DateTimeKind.Unspecified), "ffsgcJwz" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 6, 2, 11, 0, 0, DateTimeKind.Unspecified), "sWAfJoSK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 15, 9, 31, 0, 0, DateTimeKind.Unspecified), "rWDlcpAc" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 10, 21, 24, 0, 0, DateTimeKind.Unspecified), "DMdWtSrI" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 13, 2, 19, 0, 0, DateTimeKind.Unspecified), "HgKLKpMw" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 5, 23, 31, 0, 0, DateTimeKind.Unspecified), "IJWAbJdh" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 19, 14, 7, 0, 0, DateTimeKind.Unspecified), "vJJlHlLI" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 5, 0, 38, 0, 0, DateTimeKind.Unspecified), "jpKgBWdS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 23, 8, 35, 0, 0, DateTimeKind.Unspecified), "zWzJJWab" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 15, 17, 41, 0, 0, DateTimeKind.Unspecified), "WAzhAkaW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 13, 10, 49, 0, 0, DateTimeKind.Unspecified), "LAswLfgv" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 14, 2, 53, 0, 0, DateTimeKind.Unspecified), "nKHzJKAf" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 31, 20, 5, 0, 0, DateTimeKind.Unspecified), "SWnsssvs" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 1, 19, 14, 0, 0, DateTimeKind.Unspecified), "JLBiIAeD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 21, 11, 55, 0, 0, DateTimeKind.Unspecified), "pAoJpWWr" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 11, 13, 59, 0, 0, DateTimeKind.Unspecified), "BarDpKnM" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 10, 2, 53, 0, 0, DateTimeKind.Unspecified), "KppSSHlu" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), "DMDDKWJD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 22, 21, 21, 0, 0, DateTimeKind.Unspecified), "HWgAwpWl" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 18, 22, 10, 0, 0, DateTimeKind.Unspecified), "jAIzfzhr" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 4, 9, 45, 0, 0, DateTimeKind.Unspecified), "KJWAtsbS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 1, 13, 54, 0, 0, DateTimeKind.Unspecified), "SJevaWKK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 3, 13, 7, 0, 0, DateTimeKind.Unspecified), "uKpJvuzl" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 13, 11, 5, 0, 0, DateTimeKind.Unspecified), "DeBbLWne" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 22, 18, 57, 0, 0, DateTimeKind.Unspecified), "KmvStfjo" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 4, 12, 56, 0, 0, DateTimeKind.Unspecified), "SwlDltku" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 9, 6, 8, 0, 0, DateTimeKind.Unspecified), "hlcsfDMi" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 25, 16, 52, 0, 0, DateTimeKind.Unspecified), "jsDnIaIL" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 4, 2, 40, 0, 0, DateTimeKind.Unspecified), "JaHJsIjn" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 23, 1, 25, 0, 0, DateTimeKind.Unspecified), "KbWAiLah" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 18, 0, 41, 0, 0, DateTimeKind.Unspecified), "JhAWJMDm" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 10, 7, 39, 0, 0, DateTimeKind.Unspecified), "smKagAwS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 16, 16, 12, 0, 0, DateTimeKind.Unspecified), "WtWlSsbs" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 5, 22, 36, 0, 0, DateTimeKind.Unspecified), "bKIeBWDr" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 6, 15, 30, 0, 0, DateTimeKind.Unspecified), "rSuHhjfS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 53, 0, 0, DateTimeKind.Unspecified), "avuecihJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 19, 11, 38, 0, 0, DateTimeKind.Unspecified), "BrmIJWvv" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 27, 9, 16, 0, 0, DateTimeKind.Unspecified), "fDDWeJAt" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 24, 18, 19, 0, 0, DateTimeKind.Unspecified), "nvWoBIAA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 18, 6, 45, 0, 0, DateTimeKind.Unspecified), "mmkpdSoA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 28, 19, 18, 0, 0, DateTimeKind.Unspecified), "JjKkAisK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 19, 4, 32, 0, 0, DateTimeKind.Unspecified), "vWKSJhJg" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 12, 10, 14, 0, 0, DateTimeKind.Unspecified), "AaSJALeS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 24, 2, 47, 0, 0, DateTimeKind.Unspecified), "LKBSKfrh" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 3, 6, 13, 0, 0, DateTimeKind.Unspecified), "kArMrAHe" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 5, 13, 15, 0, 0, DateTimeKind.Unspecified), "WfJKlLAf" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 22, 20, 47, 0, 0, DateTimeKind.Unspecified), "JeWcfWsW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 1, 18, 45, 0, 0, DateTimeKind.Unspecified), "eSsSSSDo" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 26, 0, 56, 0, 0, DateTimeKind.Unspecified), "SuvMIAWj" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 21, 3, 10, 0, 0, DateTimeKind.Unspecified), "rSStSBwD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 18, 17, 3, 0, 0, DateTimeKind.Unspecified), "JzawAocB" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 17, 18, 51, 0, 0, DateTimeKind.Unspecified), "sKSDgSsh" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 17, 22, 13, 0, 0, DateTimeKind.Unspecified), "gDMLvWoA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 5, 20, 13, 0, 0, DateTimeKind.Unspecified), "ovStbWSB" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 4, 11, 27, 0, 0, DateTimeKind.Unspecified), "stcjIAIs" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 26, 16, 20, 0, 0, DateTimeKind.Unspecified), "sJKlJndW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 3, 13, 4, 0, 0, DateTimeKind.Unspecified), "nAmtJSKA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 1, 22, 26, 0, 0, DateTimeKind.Unspecified), "gejeKHDt" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 19, 2, 26, 0, 0, DateTimeKind.Unspecified), "JnhKWmrJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 11, 13, 23, 0, 0, DateTimeKind.Unspecified), "WKwBudbb" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 25, 17, 23, 0, 0, DateTimeKind.Unspecified), "rffDAzMA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 25, 21, 15, 0, 0, DateTimeKind.Unspecified), "SfcSpAWA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 2, 21, 57, 0, 0, DateTimeKind.Unspecified), "tiAWfoAa" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 29, 7, 10, 0, 0, DateTimeKind.Unspecified), "hSDchbDd" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), "chJsKDHo" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 4, 3, 10, 0, 0, DateTimeKind.Unspecified), "szSKkJod" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 29, 10, 40, 0, 0, DateTimeKind.Unspecified), "WWhkDzMc" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 28, 21, 28, 0, 0, DateTimeKind.Unspecified), "iesdAABW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 24, 3, 43, 0, 0, DateTimeKind.Unspecified), "DDHhWpgu" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 11, 22, 2, 0, 0, DateTimeKind.Unspecified), "DjlHstIB" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 21, 2, 20, 0, 0, DateTimeKind.Unspecified), "rDntAoAJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 16, 17, 37, 0, 0, DateTimeKind.Unspecified), "mAnwJWzA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 4, 2, 41, 0, 0, DateTimeKind.Unspecified), "JhWkSges" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 3, 14, 35, 0, 0, DateTimeKind.Unspecified), "SKAtjlWW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 20, 2, 51, 0, 0, DateTimeKind.Unspecified), "nSSrDiAn" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 17, 5, 13, 0, 0, DateTimeKind.Unspecified), "AcMnbHKM" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 24, 12, 4, 0, 0, DateTimeKind.Unspecified), "JJKkvDWk", 37, 72.79659f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 16, 5, 22, 0, 0, DateTimeKind.Unspecified), "vISeWfza", 32, 20.88861f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 5, 18, 2, 0, 0, DateTimeKind.Unspecified), "bAjIJfMS", 30, 6.2081194f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 22, 23, 8, 0, 0, DateTimeKind.Unspecified), "kWSMlSvD", 11, 5.7768297f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 13, 17, 28, 0, 0, DateTimeKind.Unspecified), "aISssstA", 11, 33.611427f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 26, 0, 42, 0, 0, DateTimeKind.Unspecified), "lDAWzSWu", 18, 7.9544096f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 7, 14, 4, 0, 0, DateTimeKind.Unspecified), "JJlBwWbS", 34, 94.99534f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 2, 17, 52, 0, 0, DateTimeKind.Unspecified), "ScDSAWWD", 37, 66.0747f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 12, 12, 5, 0, 0, DateTimeKind.Unspecified), "tJeIsWBK", 18, 92.8927f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 3, 14, 31, 0, 0, DateTimeKind.Unspecified), "fADsjgnt", 23, 50.685318f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 17, 20, 22, 0, 0, DateTimeKind.Unspecified), "DrnrWJDc", 5, 39.93016f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 22, 1, 55, 0, 0, DateTimeKind.Unspecified), "KDSvwHSB", 13, 29.797087f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 25, 16, 29, 0, 0, DateTimeKind.Unspecified), "BruAJJAS", 50.708652f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 21, 15, 12, 0, 0, DateTimeKind.Unspecified), "sWzDtHsW", 43, 25.67056f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 19, 3, 48, 0, 0, DateTimeKind.Unspecified), "KJSDuSDA", 38, 90.17089f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 2, 9, 53, 0, 0, DateTimeKind.Unspecified), "lbbsrfdz", 10, 90.4734f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 4, 7, 19, 0, 0, DateTimeKind.Unspecified), "HbSLSDJf", 49, 33.858257f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 21, 10, 56, 0, 0, DateTimeKind.Unspecified), "vSDMzDHe", 8, 60.383778f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 7, 20, 15, 0, 0, DateTimeKind.Unspecified), "BSHAApgJ", 32, 94.475204f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 21, 19, 14, 0, 0, DateTimeKind.Unspecified), "rMwAAspl", 7, 83.645966f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 2, 19, 25, 0, 0, DateTimeKind.Unspecified), "WDprSWSj", 8, 40.987717f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 25, 14, 4, 0, 0, DateTimeKind.Unspecified), "DJfKHedA", 47, 93.0009f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 21, 21, 21, 0, 0, DateTimeKind.Unspecified), "tAAtskDr", 13, 21.405298f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 9, 22, 29, 0, 0, DateTimeKind.Unspecified), "MSASeAlW", 17, 97.46878f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 6, 19, 51, 0, 0, DateTimeKind.Unspecified), "pKozjpnS", 45, 99.138f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 16, 3, 54, 0, 0, DateTimeKind.Unspecified), "DsJokslm", 22, 51.441143f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 22, 16, 27, 0, 0, DateTimeKind.Unspecified), "SKrABAKu", 6, 1.4999971f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 30, 3, 15, 0, 0, DateTimeKind.Unspecified), "wDzJegec", 38, 70.54954f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 20, 21, 43, 0, 0, DateTimeKind.Unspecified), "thzJWJAd", 13, 77.56019f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 19, 0, 24, 0, 0, DateTimeKind.Unspecified), "HDtarkgB", 45, 23.982563f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 22, 8, 19, 0, 0, DateTimeKind.Unspecified), "AmDpWpvu", 17, 74.0308f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 3, 14, 20, 0, 0, DateTimeKind.Unspecified), "DMSkAtLA", 10, 82.37278f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 12, 1, 5, 0, 0, DateTimeKind.Unspecified), "sSMdArsj", 24, 29.057955f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 13, 17, 24, 0, 0, DateTimeKind.Unspecified), "nnmKBKcn", 34, 73.96251f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 27, 23, 49, 0, 0, DateTimeKind.Unspecified), "LJjLgKsd", 47, 60.12943f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 14, 7, 38, 0, 0, DateTimeKind.Unspecified), "ScMJWnjo", 22, 7.3451943f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 24, 16, 25, 0, 0, DateTimeKind.Unspecified), "gDSDodJt", 33, 47.305256f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 17, 6, 32, 0, 0, DateTimeKind.Unspecified), "WWcrcALl", 21, 67.2715f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 10, 18, 14, 0, 0, DateTimeKind.Unspecified), "AWsDjaJD", 1, 9.581699f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 3, 11, 56, 0, 0, DateTimeKind.Unspecified), "sLrAzDDa", 24, 50.192623f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 19, 4, 20, 0, 0, DateTimeKind.Unspecified), "dWvbgDWW", 31, 83.45492f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 5, 12, 31, 0, 0, DateTimeKind.Unspecified), "nIcrSgaL", 32, 41.242283f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 18, 0, 28, 0, 0, DateTimeKind.Unspecified), "kHbDMkfg", 40, 92.84071f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 18, 17, 2, 0, 0, DateTimeKind.Unspecified), "KcisSKAk", 5, 4.619871f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 11, 15, 38, 0, 0, DateTimeKind.Unspecified), "ncmesIfr", 20, 47.28547f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 18, 0, 16, 0, 0, DateTimeKind.Unspecified), "SDAtSuAk", 26, 81.24768f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 17, 23, 15, 0, 0, DateTimeKind.Unspecified), "SAHKBDeA", 1, 37.12944f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 27, 2, 25, 0, 0, DateTimeKind.Unspecified), "AnndsAdD", 8, 27.15756f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 29, 0, 37, 0, 0, DateTimeKind.Unspecified), "ASdWJAuu", 20, 83.31856f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 16, 23, 44, 0, 0, DateTimeKind.Unspecified), "KWnrASit", 31, 86.91954f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), "jSSkeiHJ", 12, 78.74665f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 17, 12, 50, 0, 0, DateTimeKind.Unspecified), "StkiDbWk", 41, 95.5876f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 13, 17, 38, 0, 0, DateTimeKind.Unspecified), "AjAfpirJ", 23, 32.2977f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 23, 2, 17, 0, 0, DateTimeKind.Unspecified), "fmkLmJtg", 11, 46.78097f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 2, 20, 29, 0, 0, DateTimeKind.Unspecified), "fMJvALvA", 29, 65.4706f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 27, 21, 59, 0, 0, DateTimeKind.Unspecified), "hrSDAkAD", 14, 63.375237f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 27, 8, 0, 0, 0, DateTimeKind.Unspecified), "SdSolcca", 38, 38.91769f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 24, 19, 33, 0, 0, DateTimeKind.Unspecified), "JJfLWIAk", 35, 3.645567f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 16, 3, 17, 0, 0, DateTimeKind.Unspecified), "DddJgKrH", 28, 4.502198f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 26, 13, 33, 0, 0, DateTimeKind.Unspecified), "WISDzIiJ", 4, 75.976585f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 2, 8, 15, 0, 0, DateTimeKind.Unspecified), "tWgiAeMc", 39, 15.142148f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 6, 10, 49, 0, 0, DateTimeKind.Unspecified), "LAIfSDJr", 48, 15.252163f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 10, 20, 9, 0, 0, DateTimeKind.Unspecified), "LDBJgmth", 3, 50.00989f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 24, 11, 40, 0, 0, DateTimeKind.Unspecified), "SiDvfcDI", 20, 65.97085f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 10, 6, 12, 0, 0, DateTimeKind.Unspecified), "DksoWpnJ", 20, 21.728888f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 15, 6, 2, 0, 0, DateTimeKind.Unspecified), "ibWmKkAk", 2, 32.26424f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 9, 0, 50, 0, 0, DateTimeKind.Unspecified), "dWhMnBJg", 34, 76.454994f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 9, 23, 5, 0, 0, DateTimeKind.Unspecified), "oDzJDwSI", 48, 5.748323f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 22, 15, 22, 0, 0, DateTimeKind.Unspecified), "oDBAfzHD", 33, 41.48451f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 3, 20, 10, 0, 0, DateTimeKind.Unspecified), "lSsfwfuD", 25, 54.571053f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 9, 17, 28, 0, 0, DateTimeKind.Unspecified), "losAMHBb", 7, 97.21237f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 17, 0, 46, 0, 0, DateTimeKind.Unspecified), "wrDAABpW", 1, 68.14718f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 11, 16, 42, 0, 0, DateTimeKind.Unspecified), "eWWWWveJ", 4, 91.33153f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 3, 8, 19, 0, 0, DateTimeKind.Unspecified), "SJHJdSHi", 2, 53.03196f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 5, 14, 54, 0, 0, DateTimeKind.Unspecified), "DADngzJS", 44, 70.15538f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 26, 6, 54, 0, 0, DateTimeKind.Unspecified), "zAbKzWHA", 35, 8.979335f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 35, 0, 0, DateTimeKind.Unspecified), "rWaAhJSS", 37, 18.293682f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 2, 4, 19, 0, 0, DateTimeKind.Unspecified), "kJBoDMSS", 9, 84.10059f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 27, 6, 50, 0, 0, DateTimeKind.Unspecified), "WSfSbbKS", 32, 12.324772f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 17, 19, 34, 0, 0, DateTimeKind.Unspecified), "epritpiW", 6, 6.430614f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 1, 4, 38, 0, 0, DateTimeKind.Unspecified), "SWooJiaW", 31, 55.111523f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 24, 14, 1, 0, 0, DateTimeKind.Unspecified), "eAdtMDHB", 35, 88.80948f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 2, 2, 37, 0, 0, DateTimeKind.Unspecified), "KkeJASWo", 19, 3.2417102f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 2, 21, 58, 0, 0, DateTimeKind.Unspecified), "ltuLnHzJ", 20, 36.920403f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 7, 15, 24, 0, 0, DateTimeKind.Unspecified), "DDrbWHkA", 49, 21.45833f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 7, 19, 28, 0, 0, DateTimeKind.Unspecified), "SgLpWiJA", 19, 17.73407f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 20, 20, 41, 0, 0, DateTimeKind.Unspecified), "HIJikKfl", 40, 47.230583f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 19, 22, 47, 0, 0, DateTimeKind.Unspecified), "nadlKhWz", 10, 97.351326f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 14, 20, 54, 0, 0, DateTimeKind.Unspecified), "miIpmJAJ", 14, 16.595463f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 1, 1, 50, 0, 0, DateTimeKind.Unspecified), "DDISAspc", 48, 92.29337f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 20, 23, 37, 0, 0, DateTimeKind.Unspecified), "SJjwbnHb", 18, 15.609026f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 1, 20, 52, 0, 0, DateTimeKind.Unspecified), "sfJWWWJH", 30, 31.469501f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 1, 3, 15, 0, 0, DateTimeKind.Unspecified), "zudItvmb", 10, 28.057207f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 13, 4, 40, 0, 0, DateTimeKind.Unspecified), "ASiSJusM", 30, 59.61021f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 2, 3, 41, 0, 0, DateTimeKind.Unspecified), "WaWAWkuD", 41, 89.242874f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 11, 17, 30, 0, 0, DateTimeKind.Unspecified), "AWAhJpob", 33, 89.94595f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 24, 16, 22, 0, 0, DateTimeKind.Unspecified), "LhnwoDHk", 33, 41.52503f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 24, 12, 47, 0, 0, DateTimeKind.Unspecified), "ShWpebnd", 38, 78.08426f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 7, 10, 49, 0, 0, DateTimeKind.Unspecified), "JSMDsAWl", 45, 59.470375f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 30, 9, 36, 0, 0, DateTimeKind.Unspecified), "adoWKfhB", 28, 59.62125f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "Ingredients");

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 24, 3, 7, 0, 0, DateTimeKind.Unspecified), 5, 38.94f, 71, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 29, 6, 38, 0, 0, DateTimeKind.Unspecified), 34, 17.45f, 48, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 18, 0, 15, 0, 0, DateTimeKind.Unspecified), 49, 49.09f, 79, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 21, 7, 8, 0, 0, DateTimeKind.Unspecified), 24, 48.68f, 85, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 5, 9, 38, 0, 0, DateTimeKind.Unspecified), 65, 36.16f, 88, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 10, 5, 29, 0, 0, DateTimeKind.Unspecified), 75, 3.14f, 53, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 27, 1, 39, 0, 0, DateTimeKind.Unspecified), 91, 23.86f, 58, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 8, 5, 3, 12, 0, 0, DateTimeKind.Unspecified), 79, 47.51f, 97 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 24, 20, 24, 0, 0, DateTimeKind.Unspecified), 20, 43.61f, 13, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 11, 22, 22, 2, 0, 0, DateTimeKind.Unspecified), 19, 42.13f, 43 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 25, 0, 19, 0, 0, DateTimeKind.Unspecified), 17, 18.11f, 16, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 3, 22, 18, 10, 0, 0, DateTimeKind.Unspecified), 32, 30.15f, 7 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 2, 15, 8, 21, 0, 0, DateTimeKind.Unspecified), 29, 10.62f, 73 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 6, 4, 33, 0, 0, DateTimeKind.Unspecified), 5, 7.14f, 88, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 5, 2, 17, 0, 0, DateTimeKind.Unspecified), 29, 23.73f, 6, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 14, 11, 17, 0, 0, DateTimeKind.Unspecified), 79, 6.12f, 69, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 7, 17, 37, 0, 0, DateTimeKind.Unspecified), 89, 46.97f, 34, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 7, 21, 12, 0, 0, DateTimeKind.Unspecified), 55, 17.53f, 42, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 28, 16, 16, 0, 0, DateTimeKind.Unspecified), 19, 40.64f, 66, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 10, 16, 35, 0, 0, DateTimeKind.Unspecified), 98, 12.51f, 84, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 26, 3, 36, 0, 0, DateTimeKind.Unspecified), 5, 36.06f, 39, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 24, 5, 43, 0, 0, DateTimeKind.Unspecified), 70, 31.23f, 87, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 8, 15, 6, 3, 0, 0, DateTimeKind.Unspecified), 22, 25.79f, 28 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 21, 19, 29, 0, 0, DateTimeKind.Unspecified), 37, 12.94f, 83, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 20, 5, 23, 0, 0, DateTimeKind.Unspecified), 70, 30.25f, 33, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 6, 19, 12, 0, 0, DateTimeKind.Unspecified), 48, 41.51f, 86, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 9, 10, 8, 46, 0, 0, DateTimeKind.Unspecified), 55, 30.97f, 70 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 12, 9, 41, 0, 0, DateTimeKind.Unspecified), 18, 42.86f, 29, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 13, 20, 30, 0, 0, DateTimeKind.Unspecified), 92, 6.89f, 72, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 19, 14, 9, 0, 0, DateTimeKind.Unspecified), 69, 1.12f, 44, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 4, 11, 34, 0, 0, DateTimeKind.Unspecified), 75, 15.83f, 47, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 16, 4, 15, 0, 0, DateTimeKind.Unspecified), 44, 23.65f, 69, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 10, 4, 19, 0, 0, DateTimeKind.Unspecified), 87, 7.19f, 39, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 3, 14, 38, 0, 0, DateTimeKind.Unspecified), 62, 26.82f, 72, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 15, 11, 7, 0, 0, DateTimeKind.Unspecified), 51, 19.14f, 65, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 3, 12, 12, 0, 0, DateTimeKind.Unspecified), 58, 35.63f, 41, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 16, 13, 13, 0, 0, DateTimeKind.Unspecified), 47, 35.12f, 17, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 20, 13, 41, 0, 0, DateTimeKind.Unspecified), 26, 38.15f, 94, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 22, 8, 28, 0, 0, DateTimeKind.Unspecified), 71, 10.61f, 84, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 23, 6, 18, 0, 0, DateTimeKind.Unspecified), 79, 46.96f, 84, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 2, 2, 8, 44, 0, 0, DateTimeKind.Unspecified), 17, 10.88f, 82 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 1, 8, 38, 0, 0, DateTimeKind.Unspecified), 38, 8.87f, 96, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 4, 14, 4, 51, 0, 0, DateTimeKind.Unspecified), 73, 41.69f, 11 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 22, 9, 53, 0, 0, DateTimeKind.Unspecified), 18, 1.63f, 92, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 10, 16, 20, 8, 0, 0, DateTimeKind.Unspecified), 85, 19.54f, 47 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 9, 4, 3, 0, 0, DateTimeKind.Unspecified), 31, 38.73f, 94, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 1, 3, 19, 19, 0, 0, DateTimeKind.Unspecified), 66, 37.75f, 61 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 11, 3, 15, 10, 0, 0, DateTimeKind.Unspecified), 28, 41.4f, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 9, 26, 13, 55, 0, 0, DateTimeKind.Unspecified), 10, 44.74f, 57 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 3, 19, 23, 0, 0, DateTimeKind.Unspecified), 88, 26.53f, 12, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 5, 3, 8, 27, 0, 0, DateTimeKind.Unspecified), 79, 15.97f, 67 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 38, 0, 0, DateTimeKind.Unspecified), 61, 22.76f, 65, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 10, 5, 9, 0, 0, DateTimeKind.Unspecified), 97, 5.54f, 44, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 23, 23, 32, 0, 0, DateTimeKind.Unspecified), 36, 30.02f, 64, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 29, 21, 23, 0, 0, DateTimeKind.Unspecified), 95, 32.36f, 38, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 15, 0, 34, 0, 0, DateTimeKind.Unspecified), 79, 12.23f, 6, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 28, 4, 45, 0, 0, DateTimeKind.Unspecified), 37, 39.34f, 81, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 10, 30, 1, 44, 0, 0, DateTimeKind.Unspecified), 62, 16.61f, 21 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 27, 14, 26, 0, 0, DateTimeKind.Unspecified), 67, 7.95f, 96, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 30, 20, 42, 0, 0, DateTimeKind.Unspecified), 80, 48.45f, 14, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 15, 15, 57, 0, 0, DateTimeKind.Unspecified), 19, 14.55f, 31, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 20, 6, 41, 0, 0, DateTimeKind.Unspecified), 16, 15.22f, 2, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 3, 6, 15, 0, 0, DateTimeKind.Unspecified), 36, 10.32f, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 21, 10, 28, 0, 0, DateTimeKind.Unspecified), 20, 37.37f, 8, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 1, 9, 20, 4, 0, 0, DateTimeKind.Unspecified), 4, 49.07f, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 11, 13, 50, 0, 0, DateTimeKind.Unspecified), 82, 34.62f, 71, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 12, 17, 43, 0, 0, DateTimeKind.Unspecified), 81, 39.38f, 26, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 24, 17, 25, 0, 0, DateTimeKind.Unspecified), 10, 12.3f, 62, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 5, 4, 14, 4, 0, 0, DateTimeKind.Unspecified), 33, 5.88f, 6 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 2, 26, 22, 3, 0, 0, DateTimeKind.Unspecified), 47, 40.97f, 60 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 19, 3, 56, 0, 0, DateTimeKind.Unspecified), 6, 30.58f, 94, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 11, 14, 12, 44, 0, 0, DateTimeKind.Unspecified), 20, 10.1f, 27 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 4, 9, 58, 0, 0, DateTimeKind.Unspecified), 46, 33.09f, 20, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 8, 7, 51, 0, 0, DateTimeKind.Unspecified), 57, 40.19f, 5, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 9, 24, 18, 58, 0, 0, DateTimeKind.Unspecified), 96, 22.22f, 98 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 13, 0, 51, 0, 0, DateTimeKind.Unspecified), 94, 6.98f, 69, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 21, 20, 10, 0, 0, DateTimeKind.Unspecified), 2, 36.97f, 24, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 5, 23, 21, 0, 0, DateTimeKind.Unspecified), 21, 11.55f, 21, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 12, 1, 20, 0, 0, DateTimeKind.Unspecified), 89, 7.97f, 43, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 7, 3, 23, 52, 0, 0, DateTimeKind.Unspecified), 65, 1.41f, 59 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 5, 17, 36, 0, 0, DateTimeKind.Unspecified), 66, 31.62f, 4, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 14, 19, 45, 0, 0, DateTimeKind.Unspecified), 60, 20.76f, 98, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 2, 10, 1, 7, 0, 0, DateTimeKind.Unspecified), 9, 12.25f, 33 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 20, 5, 42, 0, 0, DateTimeKind.Unspecified), 74, 35.9f, 18, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 30, 18, 55, 0, 0, DateTimeKind.Unspecified), 36, 13.32f, 83, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 9, 9, 36, 0, 0, DateTimeKind.Unspecified), 83, 24.26f, 10, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 2, 23, 10, 0, 0, DateTimeKind.Unspecified), 92, 35.93f, 4, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 8, 13, 15, 5, 0, 0, DateTimeKind.Unspecified), 40, 6.3f, 57 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 14, 13, 43, 0, 0, DateTimeKind.Unspecified), 81, 23.41f, 60, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 19, 11, 37, 0, 0, DateTimeKind.Unspecified), 66, 44.88f, 35, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 9, 19, 8, 28, 0, 0, DateTimeKind.Unspecified), 95, 6.15f, 84 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 19, 11, 56, 0, 0, DateTimeKind.Unspecified), 40, 15.69f, 67, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 23, 18, 1, 0, 0, DateTimeKind.Unspecified), 14, 7.53f, 15, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 26, 9, 36, 0, 0, DateTimeKind.Unspecified), 38, 15.42f, 40, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 4, 17, 16, 46, 0, 0, DateTimeKind.Unspecified), 63, 20.69f, 77 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 6, 10, 1, 56, 0, 0, DateTimeKind.Unspecified), 90, 42.78f, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 9, 22, 36, 0, 0, DateTimeKind.Unspecified), 95, 29.48f, 43, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 3, 23, 24, 0, 0, DateTimeKind.Unspecified), 81, 27.72f, 9, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "IngredientId", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 8, 0, 3, 0, 0, DateTimeKind.Unspecified), 11, 21.72f, 18, 2 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 25, 2, 6, 0, 0, DateTimeKind.Unspecified), 10.53f, 4, 14f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 27, 16, 25, 0, 0, DateTimeKind.Unspecified), 38.49f, 1, 22f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 28, 12, 37, 0, 0, DateTimeKind.Unspecified), 10.76f, 3, 36f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 29, 19, 57, 0, 0, DateTimeKind.Unspecified), 15.81f, 3, 20f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 4, 4, 50, 0, 0, DateTimeKind.Unspecified), 7.27f, 2, 2f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 24, 4, 49, 0, 0, DateTimeKind.Unspecified), 29.79f, 3, 13f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 12, 17, 4, 0, 0, DateTimeKind.Unspecified), 39.93f, 4, 24f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 20, 17, 19, 0, 0, DateTimeKind.Unspecified), 45.85f, 2, 47f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 29, 22, 55, 0, 0, DateTimeKind.Unspecified), 13.8f, 15f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 6, 4, 26, 0, 0, DateTimeKind.Unspecified), 49.19f, 3, 32f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 28, 14, 58, 0, 0, DateTimeKind.Unspecified), 43.95f, 5, 31f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 9, 20, 38, 0, 0, DateTimeKind.Unspecified), 13.57f, 44f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 1, 15, 50, 0, 0, DateTimeKind.Unspecified), 23.59f, 43f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 9, 18, 10, 0, 0, DateTimeKind.Unspecified), 14.47f, 5, 26f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 30, 22, 43, 0, 0, DateTimeKind.Unspecified), 14.42f, 3, 47f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 28, 14, 36, 0, 0, DateTimeKind.Unspecified), 1.67f, 1, 23f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2021, 2, 28, 11, 34, 0, 0, DateTimeKind.Unspecified), 41.64f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 13, 17, 1, 0, 0, DateTimeKind.Unspecified), 26.86f, 3, 46f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 23, 6, 20, 0, 0, DateTimeKind.Unspecified), 31.13f, 4, 16f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 9, 12, 40, 0, 0, DateTimeKind.Unspecified), 9.75f, 1, 29f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 27, 20, 47, 0, 0, DateTimeKind.Unspecified), 3.5f, 1, 15f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 17, 5, 2, 0, 0, DateTimeKind.Unspecified), 49.55f, 4, 40f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 13, 8, 8, 0, 0, DateTimeKind.Unspecified), 14.88f, 5, 14f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 11, 1, 36, 0, 0, DateTimeKind.Unspecified), 12.8f, 1, 44f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 4, 6, 22, 0, 0, DateTimeKind.Unspecified), 25.25f, 4, 34f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 30, 13, 8, 0, 0, DateTimeKind.Unspecified), 45.38f, 4, 23f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 27, 3, 42, 0, 0, DateTimeKind.Unspecified), 32.92f, 39f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 17, 12, 18, 0, 0, DateTimeKind.Unspecified), 8.9f, 5, 12f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 8, 0, 6, 0, 0, DateTimeKind.Unspecified), 41.74f, 5, 39f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 26, 22, 17, 0, 0, DateTimeKind.Unspecified), 18.12f, 1, 19f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 22, 5, 4, 0, 0, DateTimeKind.Unspecified), 42.86f, 4, 11f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 30, 9, 7, 0, 0, DateTimeKind.Unspecified), 29.37f, 3, 35f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 10, 21, 35, 0, 0, DateTimeKind.Unspecified), 13.12f, 6f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 16, 19, 21, 0, 0, DateTimeKind.Unspecified), 4.97f, 4, 16f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 6, 1, 25, 0, 0, DateTimeKind.Unspecified), 3.7f, 2, 34f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 7, 15, 19, 0, 0, DateTimeKind.Unspecified), 38.66f, 1, 32f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 22, 5, 4, 0, 0, DateTimeKind.Unspecified), 32.74f, 37f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 12, 9, 43, 0, 0, DateTimeKind.Unspecified), 1.38f, 1, 42f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 16, 0, 33, 0, 0, DateTimeKind.Unspecified), 44.41f, 2, 39f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 13, 14, 24, 0, 0, DateTimeKind.Unspecified), 9.82f, 1, 1f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 16, 9, 49, 0, 0, DateTimeKind.Unspecified), 11.95f, 2, 44f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 18, 12, 2, 0, 0, DateTimeKind.Unspecified), 39.32f, 3, 23f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 19, 17, 42, 0, 0, DateTimeKind.Unspecified), 22.12f, 4, 23f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 1, 20, 47, 0, 0, DateTimeKind.Unspecified), 22.31f, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), 11.84f, 49f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 43, 0, 0, DateTimeKind.Unspecified), 31.21f, 3, 41f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 30, 19, 34, 0, 0, DateTimeKind.Unspecified), 14.75f, 4, 2f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 19, 7, 18, 0, 0, DateTimeKind.Unspecified), 10.26f, 1, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 9, 2, 35, 0, 0, DateTimeKind.Unspecified), 34.4f, 3, 42f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 14, 22, 8, 0, 0, DateTimeKind.Unspecified), 38.61f, 1, 30f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), 14.88f, 3, 4f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 27, 14, 29, 0, 0, DateTimeKind.Unspecified), 45.17f, 5, 46f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 10, 9, 55, 0, 0, DateTimeKind.Unspecified), 45.6f, 41f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 30, 4, 43, 0, 0, DateTimeKind.Unspecified), 41.16f, 33f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 31, 1, 41, 0, 0, DateTimeKind.Unspecified), 7.03f, 2, 37f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 8, 21, 4, 0, 0, DateTimeKind.Unspecified), 14.8f, 2, 34f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 15, 8, 16, 0, 0, DateTimeKind.Unspecified), 31.24f, 49f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 21, 11, 1, 0, 0, DateTimeKind.Unspecified), 23.69f, 4, 21f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 26, 13, 34, 0, 0, DateTimeKind.Unspecified), 12.65f, 4, 29f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 4, 15, 41, 0, 0, DateTimeKind.Unspecified), 8.94f, 47f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 26, 1, 7, 0, 0, DateTimeKind.Unspecified), 40.47f, 5, 37f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 27, 4, 46, 0, 0, DateTimeKind.Unspecified), 21.17f, 5, 20f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 15, 17, 13, 0, 0, DateTimeKind.Unspecified), 37.84f, 34f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 4, 0, 37, 0, 0, DateTimeKind.Unspecified), 43.56f, 5, 3f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 14, 23, 21, 0, 0, DateTimeKind.Unspecified), 10.89f, 4, 13f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 27, 5, 51, 0, 0, DateTimeKind.Unspecified), 9.89f, 1, 6f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 2, 23, 2, 0, 0, DateTimeKind.Unspecified), 9.23f, 5f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 14, 20, 29, 0, 0, DateTimeKind.Unspecified), 29.91f, 2, 43f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 4, 16, 45, 0, 0, DateTimeKind.Unspecified), 4.65f, 3, 11f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 25, 7, 24, 0, 0, DateTimeKind.Unspecified), 3.09f, 5, 38f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 7, 9, 32, 0, 0, DateTimeKind.Unspecified), 42.47f, 4, 15f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 17, 1, 51, 0, 0, DateTimeKind.Unspecified), 49.69f, 4, 37f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 26, 16, 27, 0, 0, DateTimeKind.Unspecified), 30.1f, 27f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 10, 15, 56, 0, 0, DateTimeKind.Unspecified), 34.28f, 3, 46f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 24, 2, 50, 0, 0, DateTimeKind.Unspecified), 18.53f, 2, 21f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 12, 8, 45, 0, 0, DateTimeKind.Unspecified), 4.21f, 3, 46f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 26, 11, 20, 0, 0, DateTimeKind.Unspecified), 48.5f, 1, 33f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 14, 11, 21, 0, 0, DateTimeKind.Unspecified), 17.25f, 2, 22f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 21, 13, 35, 0, 0, DateTimeKind.Unspecified), 7.8f, 4, 41f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 28, 9, 38, 0, 0, DateTimeKind.Unspecified), 30.49f, 5, 12f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 30, 17, 34, 0, 0, DateTimeKind.Unspecified), 24.42f, 5, 29f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 8, 20, 23, 0, 0, DateTimeKind.Unspecified), 18.61f, 3, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 10, 9, 43, 0, 0, DateTimeKind.Unspecified), 36.31f, 5, 23f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 22, 1, 57, 0, 0, DateTimeKind.Unspecified), 34.57f, 19f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 24, 13, 57, 0, 0, DateTimeKind.Unspecified), 27.47f, 5, 32f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 23, 14, 34, 0, 0, DateTimeKind.Unspecified), 2.53f, 1, 17f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 18, 23, 11, 0, 0, DateTimeKind.Unspecified), 33.44f, 3, 7f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 9, 16, 52, 0, 0, DateTimeKind.Unspecified), 22.21f, 16f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 16, 17, 39, 0, 0, DateTimeKind.Unspecified), 16.93f, 4, 35f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 28, 4, 21, 0, 0, DateTimeKind.Unspecified), 31.45f, 1, 23f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 24, 7, 2, 0, 0, DateTimeKind.Unspecified), 1.85f, 2, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 2, 18, 3, 0, 0, DateTimeKind.Unspecified), 39.92f, 22f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 17, 20, 8, 0, 0, DateTimeKind.Unspecified), 22.21f, 2, 9f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 11, 8, 52, 0, 0, DateTimeKind.Unspecified), 42.73f, 22f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 16, 13, 16, 0, 0, DateTimeKind.Unspecified), 5.24f, 3, 41f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 21, 5, 3, 0, 0, DateTimeKind.Unspecified), 24.62f, 5, 18f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 3, 18, 48, 0, 0, DateTimeKind.Unspecified), 49.58f, 4, 11f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Price", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 16, 17, 4, 0, 0, DateTimeKind.Unspecified), 43.71f, 49f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 15, 21, 25, 0, 0, DateTimeKind.Unspecified), 1.28f, 2, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 20, 6, 9, 0, 0, DateTimeKind.Unspecified), 2.3f, 4, 28f });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 1, 11, 35, 0, 0, DateTimeKind.Unspecified), "WsWslthb" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 25, 11, 34, 0, 0, DateTimeKind.Unspecified), "rWrLwBMW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 5, 4, 11, 0, 0, DateTimeKind.Unspecified), "dMrurIIo" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 2, 1, 1, 0, 0, DateTimeKind.Unspecified), "WWIwLvbK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), "fMrDbDAv" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 2, 19, 12, 0, 0, DateTimeKind.Unspecified), "WBSIosWA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 11, 18, 39, 0, 0, DateTimeKind.Unspecified), "giJAWJBJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 28, 9, 13, 0, 0, DateTimeKind.Unspecified), "BpAnDHiA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 12, 6, 49, 0, 0, DateTimeKind.Unspecified), "KKSKkpJA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 11, 1, 10, 0, 0, DateTimeKind.Unspecified), "WMIIiDaW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 26, 13, 42, 0, 0, DateTimeKind.Unspecified), "DorWHiKw" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 22, 7, 28, 0, 0, DateTimeKind.Unspecified), "sscAeSSA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 27, 3, 37, 0, 0, DateTimeKind.Unspecified), "sAmDSuoI" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 18, 23, 57, 0, 0, DateTimeKind.Unspecified), "vlJASJSK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 5, 4, 44, 0, 0, DateTimeKind.Unspecified), "pJnorAmt" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 12, 21, 40, 0, 0, DateTimeKind.Unspecified), "DljKnbvr" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 30, 4, 22, 0, 0, DateTimeKind.Unspecified), "eJzsJwSD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 23, 0, 0, DateTimeKind.Unspecified), "aDmvoJHJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 22, 9, 55, 0, 0, DateTimeKind.Unspecified), "SAujsBDA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 8, 7, 23, 0, 0, DateTimeKind.Unspecified), "sADukDBt" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 13, 18, 32, 0, 0, DateTimeKind.Unspecified), "SKWSpmIL" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 28, 19, 13, 0, 0, DateTimeKind.Unspecified), "AAoIlSef" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 30, 23, 56, 0, 0, DateTimeKind.Unspecified), "DDbWSkWB" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 20, 18, 29, 0, 0, DateTimeKind.Unspecified), "oKDASKtw" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 28, 3, 19, 0, 0, DateTimeKind.Unspecified), "DAWSeAow" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 18, 9, 32, 0, 0, DateTimeKind.Unspecified), "WKmHlWJJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 17, 10, 54, 0, 0, DateTimeKind.Unspecified), "KvSJAKJJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 2, 1, 23, 0, 0, DateTimeKind.Unspecified), "DlHJmAJt" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 25, 10, 47, 0, 0, DateTimeKind.Unspecified), "pSStlsaA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 17, 5, 15, 0, 0, DateTimeKind.Unspecified), "nKeeSopA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 5, 9, 35, 0, 0, DateTimeKind.Unspecified), "SteBJJDl" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 19, 11, 32, 0, 0, DateTimeKind.Unspecified), "gWgAcBkJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 19, 9, 47, 0, 0, DateTimeKind.Unspecified), "HJsvWmtv" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 8, 18, 15, 0, 0, DateTimeKind.Unspecified), "vSrAHSHo" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 21, 19, 21, 0, 0, DateTimeKind.Unspecified), "AhIJSsJK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 15, 4, 59, 0, 0, DateTimeKind.Unspecified), "LWlmkhSS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 13, 21, 6, 0, 0, DateTimeKind.Unspecified), "ssvdSJBW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 6, 23, 10, 0, 0, DateTimeKind.Unspecified), "DWgIvcKw" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 8, 7, 46, 0, 0, DateTimeKind.Unspecified), "pLAMJpAp" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 31, 21, 3, 0, 0, DateTimeKind.Unspecified), "mWDsagjm" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 10, 13, 10, 0, 0, DateTimeKind.Unspecified), "gWDokWrb" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 12, 5, 56, 0, 0, DateTimeKind.Unspecified), "WfJglShW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 25, 17, 50, 0, 0, DateTimeKind.Unspecified), "bKSskMDb" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 14, 8, 57, 0, 0, DateTimeKind.Unspecified), "zfIhpiWA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 4, 0, 38, 0, 0, DateTimeKind.Unspecified), "AAHIwmmS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 29, 23, 47, 0, 0, DateTimeKind.Unspecified), "DJpJvWdv" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 17, 1, 47, 0, 0, DateTimeKind.Unspecified), "SWrmiSck" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 26, 17, 12, 0, 0, DateTimeKind.Unspecified), "JBAfWiAv" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 19, 19, 42, 0, 0, DateTimeKind.Unspecified), "zbStispK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 3, 5, 23, 0, 0, DateTimeKind.Unspecified), "AlLpWsJS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), "buDBLvWH" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 8, 6, 41, 0, 0, DateTimeKind.Unspecified), "IzjSthSr" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 12, 6, 11, 0, 0, DateTimeKind.Unspecified), "jJjugAmo" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 28, 17, 8, 0, 0, DateTimeKind.Unspecified), "wDKSWSJm" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 5, 17, 2, 0, 0, DateTimeKind.Unspecified), "AldtHiDa" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), "rDKShttr" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 27, 11, 37, 0, 0, DateTimeKind.Unspecified), "nDgAilDr" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 18, 9, 41, 0, 0, DateTimeKind.Unspecified), "hlcnHJWe" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 7, 21, 42, 0, 0, DateTimeKind.Unspecified), "SAaheKWa" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 3, 6, 28, 0, 0, DateTimeKind.Unspecified), "pjchhDgf" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 19, 8, 18, 0, 0, DateTimeKind.Unspecified), "jvHsDAeA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 10, 17, 15, 0, 0, DateTimeKind.Unspecified), "ASlvgorW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 2, 22, 25, 0, 0, DateTimeKind.Unspecified), "owMlsklS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 24, 1, 34, 0, 0, DateTimeKind.Unspecified), "LgtWitjJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 6, 15, 34, 0, 0, DateTimeKind.Unspecified), "fSdldlAM" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 5, 2, 9, 0, 0, DateTimeKind.Unspecified), "LpstrmAb" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 3, 21, 41, 0, 0, DateTimeKind.Unspecified), "LzLHJJJD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 21, 9, 22, 0, 0, DateTimeKind.Unspecified), "jSJsBfDr" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 26, 4, 35, 0, 0, DateTimeKind.Unspecified), "BWpilfBd" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 21, 23, 44, 0, 0, DateTimeKind.Unspecified), "DatbJAtD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 28, 0, 33, 0, 0, DateTimeKind.Unspecified), "msgSDDak" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 26, 5, 11, 0, 0, DateTimeKind.Unspecified), "jecfWcsS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 24, 13, 36, 0, 0, DateTimeKind.Unspecified), "IgSSSWIJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 19, 12, 51, 0, 0, DateTimeKind.Unspecified), "MWWJDSlp" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 29, 18, 12, 0, 0, DateTimeKind.Unspecified), "DcjiDWIa" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 30, 12, 35, 0, 0, DateTimeKind.Unspecified), "WeDgczsS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 4, 1, 23, 0, 0, DateTimeKind.Unspecified), "SSlJbHJK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 15, 14, 58, 0, 0, DateTimeKind.Unspecified), "KtSJLtAs" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 14, 17, 51, 0, 0, DateTimeKind.Unspecified), "ASBKLiJa" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 27, 3, 31, 0, 0, DateTimeKind.Unspecified), "pSfAAHWw" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 4, 7, 44, 0, 0, DateTimeKind.Unspecified), "rJWAAWnM" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 19, 17, 41, 0, 0, DateTimeKind.Unspecified), "vJJWWdik" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 13, 5, 41, 0, 0, DateTimeKind.Unspecified), "uDnpJJes" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 21, 5, 23, 0, 0, DateTimeKind.Unspecified), "MkokBKAM" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 3, 19, 14, 0, 0, DateTimeKind.Unspecified), "WrvevSWm" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 26, 2, 54, 0, 0, DateTimeKind.Unspecified), "sJhkKhbm" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 8, 5, 21, 0, 0, DateTimeKind.Unspecified), "SMsiutDz" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 20, 16, 38, 0, 0, DateTimeKind.Unspecified), "SAWnodtH" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 7, 1, 13, 0, 0, DateTimeKind.Unspecified), "KSMSHdIK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 19, 2, 59, 0, 0, DateTimeKind.Unspecified), "BaAnJAMJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 16, 17, 22, 0, 0, DateTimeKind.Unspecified), "jcKSoWAp" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 29, 11, 24, 0, 0, DateTimeKind.Unspecified), "JWzMAWWt" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 28, 1, 28, 0, 0, DateTimeKind.Unspecified), "lwsLluWK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 6, 1, 18, 0, 0, DateTimeKind.Unspecified), "eJStApAW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 14, 12, 45, 0, 0, DateTimeKind.Unspecified), "WkelAJsd" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 2, 19, 54, 0, 0, DateTimeKind.Unspecified), "kWJWJJAA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 9, 7, 31, 0, 0, DateTimeKind.Unspecified), "cwcmvcDW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 4, 16, 15, 0, 0, DateTimeKind.Unspecified), "saBucgIz" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 8, 17, 23, 0, 0, DateTimeKind.Unspecified), "mHoHWSJw" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 27, 22, 29, 0, 0, DateTimeKind.Unspecified), "gtSJAMSk" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 5, 21, 40, 0, 0, DateTimeKind.Unspecified), "jKrbmstK", 7, 32.514862f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 14, 23, 5, 0, 0, DateTimeKind.Unspecified), "WoWAkSbe", 3, 94.2741f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 12, 14, 33, 0, 0, DateTimeKind.Unspecified), "IzvWWcnr", 44, 86.34001f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 12, 19, 10, 0, 0, DateTimeKind.Unspecified), "WKgbvJoK", 36, 41.31568f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 10, 12, 36, 0, 0, DateTimeKind.Unspecified), "drknWWjI", 29, 65.43908f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 18, 6, 29, 0, 0, DateTimeKind.Unspecified), "oJWoAuni", 8, 59.029125f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 29, 22, 2, 0, 0, DateTimeKind.Unspecified), "sKScwWWh", 33, 3.3758886f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 30, 17, 59, 0, 0, DateTimeKind.Unspecified), "AazArrhW", 14, 52.683975f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 5, 1, 52, 0, 0, DateTimeKind.Unspecified), "alzJJJob", 34, 19.272299f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 19, 16, 55, 0, 0, DateTimeKind.Unspecified), "mJHLdWuj", 3, 88.89675f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 13, 9, 43, 0, 0, DateTimeKind.Unspecified), "oSHLdlde", 29, 30.764618f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 29, 20, 55, 0, 0, DateTimeKind.Unspecified), "ScKWrwwS", 47, 72.361824f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 2, 21, 25, 0, 0, DateTimeKind.Unspecified), "DinAWtvW", 27.941961f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 27, 3, 55, 0, 0, DateTimeKind.Unspecified), "nIWApKdD", 35, 28.6681f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 2, 22, 6, 0, 0, DateTimeKind.Unspecified), "WlutHoSK", 14, 4.339546f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 20, 4, 44, 0, 0, DateTimeKind.Unspecified), "hsiADAWW", 28, 48.511936f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 16, 19, 3, 0, 0, DateTimeKind.Unspecified), "gAmMWAlM", 9, 75.05107f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 22, 15, 15, 0, 0, DateTimeKind.Unspecified), "DdDmskKW", 7, 16.889505f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 10, 10, 40, 0, 0, DateTimeKind.Unspecified), "Wmifeeno", 37, 28.845299f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 23, 8, 46, 0, 0, DateTimeKind.Unspecified), "zDBJkSJK", 41, 40.54107f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 9, 6, 39, 0, 0, DateTimeKind.Unspecified), "gaSWAiSM", 33, 4.8133245f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 22, 6, 10, 0, 0, DateTimeKind.Unspecified), "DwLWAwpS", 29, 52.888237f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 26, 2, 49, 0, 0, DateTimeKind.Unspecified), "DkSSrKWb", 26, 72.87301f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 8, 12, 24, 0, 0, DateTimeKind.Unspecified), "vWsiiJAI", 27, 86.59361f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 2, 0, 22, 0, 0, DateTimeKind.Unspecified), "sSfzwisW", 39, 40.446697f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 3, 15, 28, 0, 0, DateTimeKind.Unspecified), "vmfWmWDW", 34, 81.20821f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 28, 5, 42, 0, 0, DateTimeKind.Unspecified), "kDbDDJvK", 19, 24.408726f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 16, 7, 35, 0, 0, DateTimeKind.Unspecified), "pAjDSHJt", 22, 80.728935f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 26, 2, 39, 0, 0, DateTimeKind.Unspecified), "KbgJsAwv", 25, 40.379055f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 5, 21, 47, 0, 0, DateTimeKind.Unspecified), "JApdzeWS", 33, 52.792435f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 9, 13, 56, 0, 0, DateTimeKind.Unspecified), "twWDDSSD", 43, 64.02801f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 13, 18, 15, 0, 0, DateTimeKind.Unspecified), "uKfWDSdK", 14, 86.157814f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 28, 13, 55, 0, 0, DateTimeKind.Unspecified), "DJSkKAJr", 34, 74.0775f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 30, 7, 26, 0, 0, DateTimeKind.Unspecified), "fJmcDsgl", 47, 36.266457f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 23, 11, 58, 0, 0, DateTimeKind.Unspecified), "MsglAhWc", 41, 99.61236f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 16, 18, 29, 0, 0, DateTimeKind.Unspecified), "kKwIKWzI", 6, 47.9758f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 25, 5, 50, 0, 0, DateTimeKind.Unspecified), "ABBAnKiW", 49, 98.532364f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 26, 14, 32, 0, 0, DateTimeKind.Unspecified), "AJwSsKDc", 24, 6.4329305f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 9, 13, 20, 0, 0, DateTimeKind.Unspecified), "vJADILdt", 30, 78.316895f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 7, 7, 28, 0, 0, DateTimeKind.Unspecified), "SKaDkSKv", 39, 79.53849f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 25, 16, 32, 0, 0, DateTimeKind.Unspecified), "jzjbIvSs", 5, 51.73164f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 22, 5, 12, 0, 0, DateTimeKind.Unspecified), "nssdHLWz", 36, 31.929562f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), "KztAIMaa", 7, 54.709515f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 1, 0, 44, 0, 0, DateTimeKind.Unspecified), "wiJAKisc", 45, 46.54805f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 17, 18, 37, 0, 0, DateTimeKind.Unspecified), "ccJaDWla", 33, 32.42224f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 25, 10, 7, 0, 0, DateTimeKind.Unspecified), "ADmrwDAf", 17, 2.4153311f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 2, 20, 37, 0, 0, DateTimeKind.Unspecified), "iKvWzAWo", 16, 81.81866f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 23, 16, 12, 0, 0, DateTimeKind.Unspecified), "ziBSHzWe", 2, 24.050907f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 9, 10, 45, 0, 0, DateTimeKind.Unspecified), "aoaWeDLW", 23, 10.25192f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 30, 8, 32, 0, 0, DateTimeKind.Unspecified), "ksAoSHDA", 37, 29.978544f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 2, 9, 59, 0, 0, DateTimeKind.Unspecified), "sSraKHWs", 3, 40.011814f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 12, 3, 33, 0, 0, DateTimeKind.Unspecified), "ssKvzDrA", 18, 75.360245f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 8, 6, 24, 0, 0, DateTimeKind.Unspecified), "JhrjDebW", 12, 92.35779f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 21, 12, 39, 0, 0, DateTimeKind.Unspecified), "ASDdKpSW", 19, 25.181711f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 11, 23, 30, 0, 0, DateTimeKind.Unspecified), "ScibfWrr", 5, 11.372749f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 12, 15, 30, 0, 0, DateTimeKind.Unspecified), "WShJazhJ", 24, 76.09614f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 17, 20, 15, 0, 0, DateTimeKind.Unspecified), "bzKAprAt", 24, 68.22477f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 8, 2, 9, 0, 0, DateTimeKind.Unspecified), "JJoAeDWg", 11, 94.65673f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 13, 18, 48, 0, 0, DateTimeKind.Unspecified), "IWWuuptS", 17, 73.23608f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 7, 21, 7, 0, 0, DateTimeKind.Unspecified), "IaArAuDn", 1, 47.275448f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 19, 0, 47, 0, 0, DateTimeKind.Unspecified), "WScpKhso", 23, 67.9297f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 14, 14, 27, 0, 0, DateTimeKind.Unspecified), "BIvsAvlh", 44, 58.658585f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 5, 15, 19, 0, 0, DateTimeKind.Unspecified), "cbSlHKlA", 45, 19.500683f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 2, 4, 4, 0, 0, DateTimeKind.Unspecified), "cWWpLizk", 46, 6.2014413f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 10, 2, 58, 0, 0, DateTimeKind.Unspecified), "ialhwntH", 15, 12.45434f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 28, 15, 28, 0, 0, DateTimeKind.Unspecified), "pwAWMbsu", 27, 55.940903f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 30, 6, 59, 0, 0, DateTimeKind.Unspecified), "KrnMDsJM", 13, 97.12939f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 2, 13, 59, 0, 0, DateTimeKind.Unspecified), "Ssnishss", 1, 25.067883f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 4, 15, 57, 0, 0, DateTimeKind.Unspecified), "sjjwieWK", 41, 81.46624f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 17, 3, 37, 0, 0, DateTimeKind.Unspecified), "HiMiMJIb", 41, 97.0135f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 23, 22, 53, 0, 0, DateTimeKind.Unspecified), "goBAJBSI", 2, 2.8935733f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 24, 4, 30, 0, 0, DateTimeKind.Unspecified), "tpzfajji", 22, 3.4604354f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 14, 1, 54, 0, 0, DateTimeKind.Unspecified), "aAmASWkW", 27, 93.63545f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 2, 3, 11, 0, 0, DateTimeKind.Unspecified), "SDmvzzae", 1, 60.024628f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 30, 16, 14, 0, 0, DateTimeKind.Unspecified), "BlciWSwI", 36, 64.855316f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 18, 1, 27, 0, 0, DateTimeKind.Unspecified), "KufLSDKs", 23, 3.201968f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 19, 15, 10, 0, 0, DateTimeKind.Unspecified), "WJiutejh", 6, 87.803055f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 29, 2, 5, 0, 0, DateTimeKind.Unspecified), "dLLtolsA", 30, 39.46612f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 23, 17, 47, 0, 0, DateTimeKind.Unspecified), "prKKhaKc", 6, 55.650475f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 5, 14, 14, 0, 0, DateTimeKind.Unspecified), "azhzAscd", 33, 91.84053f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 3, 18, 50, 0, 0, DateTimeKind.Unspecified), "JWzAnWAs", 26, 85.10347f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 5, 13, 29, 0, 0, DateTimeKind.Unspecified), "cJfKeeDp", 30, 19.605173f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 7, 20, 49, 0, 0, DateTimeKind.Unspecified), "biBoaDoS", 39, 57.084194f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 28, 18, 6, 0, 0, DateTimeKind.Unspecified), "ifuSSJnA", 6, 12.455657f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 4, 11, 47, 0, 0, DateTimeKind.Unspecified), "IWJAWHHA", 40, 23.90871f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 31, 10, 23, 0, 0, DateTimeKind.Unspecified), "SfSmMISA", 11, 36.686058f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 3, 11, 51, 0, 0, DateTimeKind.Unspecified), "MLvASJdK", 24, 31.779764f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 5, 1, 16, 0, 0, DateTimeKind.Unspecified), "wADhkJAo", 47, 51.241947f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 16, 7, 56, 0, 0, DateTimeKind.Unspecified), "JuSpwaDt", 40, 61.38343f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 11, 20, 28, 0, 0, DateTimeKind.Unspecified), "ASHJmcbt", 45, 14.060277f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 30, 22, 13, 0, 0, DateTimeKind.Unspecified), "isbfrDJd", 14, 58.30929f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 18, 3, 41, 0, 0, DateTimeKind.Unspecified), "SAaogDwJ", 15, 28.201704f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 11, 19, 44, 0, 0, DateTimeKind.Unspecified), "JzSDLJzJ", 5, 65.701706f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 2, 16, 12, 0, 0, DateTimeKind.Unspecified), "pcjDdiAz", 1, 27.02063f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 17, 6, 41, 0, 0, DateTimeKind.Unspecified), "shWJAuWb", 8, 95.59672f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 10, 2, 4, 0, 0, DateTimeKind.Unspecified), "DAWWaklD", 20, 14.272219f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 14, 13, 52, 0, 0, DateTimeKind.Unspecified), "rKnSuDDB", 16, 27.391125f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 4, 10, 55, 0, 0, DateTimeKind.Unspecified), "bhWouJDB", 36, 85.08068f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 19, 21, 45, 0, 0, DateTimeKind.Unspecified), "tDLWBJik", 9, 97.30132f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 18, 3, 9, 0, 0, DateTimeKind.Unspecified), "wJDWbLJe", 3, 66.84396f });
        }
    }
}
