using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 16, 19, 45, 0, 0, DateTimeKind.Unspecified), 30, 53f, 43.03f, 60, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 26, 17, 58, 0, 0, DateTimeKind.Unspecified), 91, 43f, 11.45f, 47, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 1, 2, 44, 0, 0, DateTimeKind.Unspecified), 89, 91f, 13.1f, 22, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 7, 12, 18, 0, 0, DateTimeKind.Unspecified), 15, 46f, 30.3f, 39, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 56, 0, 0, DateTimeKind.Unspecified), 58, 25f, 8.5f, 19, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 6, 17, 15, 0, 0, DateTimeKind.Unspecified), 31, 34f, 6.81f, 30, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 6, 18, 9, 0, 0, DateTimeKind.Unspecified), 19, 65f, 14.98f, 64, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 12, 12, 4, 0, 0, DateTimeKind.Unspecified), 82, 87f, 34.41f, 41, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 18, 17, 7, 0, 0, DateTimeKind.Unspecified), 41, 37f, 42.83f, 33, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 4, 12, 43, 0, 0, DateTimeKind.Unspecified), 30, 87f, 45.41f, 98, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 6, 15, 17, 21, 0, 0, DateTimeKind.Unspecified), 97, 53f, 44.97f, 39 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 2, 6, 54, 0, 0, DateTimeKind.Unspecified), 41, 18f, 43.91f, 31, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 4, 16, 16, 0, 0, DateTimeKind.Unspecified), 41, 57f, 40.95f, 63, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 1, 2, 36, 0, 0, DateTimeKind.Unspecified), 77, 61f, 42.27f, 77, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 5, 23, 1, 0, 0, DateTimeKind.Unspecified), 46, 73f, 40.75f, 40, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 22, 2, 48, 0, 0, DateTimeKind.Unspecified), 23, 36f, 18.41f, 44, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 5, 29, 5, 8, 0, 0, DateTimeKind.Unspecified), 44, 33f, 33.15f, 77 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 4, 11, 35, 0, 0, DateTimeKind.Unspecified), 42, 10f, 47.67f, 99, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 21, 9, 28, 0, 0, DateTimeKind.Unspecified), 4, 7f, 20.33f, 55, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 2, 14, 42, 0, 0, DateTimeKind.Unspecified), 11, 69f, 40.28f, 3, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 14, 8, 39, 0, 0, DateTimeKind.Unspecified), 56, 23f, 29.14f, 73, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 7, 7, 47, 0, 0, DateTimeKind.Unspecified), 23, 45f, 41.45f, 83, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 27, 9, 44, 0, 0, DateTimeKind.Unspecified), 62, 75f, 34.52f, 90, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 19, 7, 30, 0, 0, DateTimeKind.Unspecified), 73, 79f, 13.7f, 66, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 7, 20, 5, 52, 0, 0, DateTimeKind.Unspecified), 11, 48f, 29.29f, 33 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 9, 13, 11, 43, 0, 0, DateTimeKind.Unspecified), 49, 54f, 43.98f, 55 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 5, 14, 21, 12, 0, 0, DateTimeKind.Unspecified), 85, 97f, 47.72f, 74 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 28, 5, 1, 0, 0, DateTimeKind.Unspecified), 10, 3f, 42.95f, 28, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 14, 12, 57, 0, 0, DateTimeKind.Unspecified), 50, 83f, 41.06f, 38, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 3, 21, 21, 41, 0, 0, DateTimeKind.Unspecified), 4, 37f, 18.79f, 43 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 10, 9, 48, 0, 0, DateTimeKind.Unspecified), 54, 68f, 42.34f, 64, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 20, 20, 45, 0, 0, DateTimeKind.Unspecified), 91, 43f, 10.14f, 58, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 7, 11, 13, 30, 0, 0, DateTimeKind.Unspecified), 93, 10f, 44.28f, 80 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 10, 11, 32, 0, 0, DateTimeKind.Unspecified), 37, 88f, 33.56f, 93, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 12, 6, 27, 0, 0, DateTimeKind.Unspecified), 49, 39f, 44.04f, 65, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 1, 5, 8, 0, 0, DateTimeKind.Unspecified), 95, 30f, 2.58f, 17, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 15, 11, 20, 0, 0, DateTimeKind.Unspecified), 94, 51f, 10.17f, 14, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 24, 2, 53, 0, 0, DateTimeKind.Unspecified), 24, 68f, 36.41f, 83, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 6, 12, 9, 0, 0, DateTimeKind.Unspecified), 14, 45f, 31.27f, 94, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 18, 5, 16, 0, 0, DateTimeKind.Unspecified), 9, 42f, 32.96f, 69, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 11, 2, 38, 0, 0, DateTimeKind.Unspecified), 54, 82f, 18.81f, 80, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 3, 6, 40, 0, 0, DateTimeKind.Unspecified), 23, 48f, 43.6f, 39, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 4, 6, 36, 0, 0, DateTimeKind.Unspecified), 76, 66f, 49.16f, 90, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 5, 1, 5, 46, 0, 0, DateTimeKind.Unspecified), 24, 42f, 12.2f, 15 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 17, 1, 36, 0, 0, DateTimeKind.Unspecified), 90, 99f, 5.59f, 77, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 23, 2, 18, 0, 0, DateTimeKind.Unspecified), 18, 83f, 13.78f, 65, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 2, 4, 23, 4, 0, 0, DateTimeKind.Unspecified), 2, 4f, 13.91f, 16 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 25, 18, 20, 0, 0, DateTimeKind.Unspecified), 35, 9f, 49.14f, 81, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 3, 3, 2, 0, 0, DateTimeKind.Unspecified), 53, 45f, 18.98f, 45, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 5, 19, 0, 12, 0, 0, DateTimeKind.Unspecified), 60, 8f, 23.94f, 19 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 3, 6, 33, 0, 0, DateTimeKind.Unspecified), 80, 96f, 17.87f, 72, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 8, 17, 26, 0, 0, DateTimeKind.Unspecified), 13, 71f, 20.16f, 23, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 30, 15, 17, 0, 0, DateTimeKind.Unspecified), 25, 75f, 11.2f, 40, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 3, 5, 59, 0, 0, DateTimeKind.Unspecified), 63, 35f, 27.01f, 42, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 16, 18, 6, 0, 0, DateTimeKind.Unspecified), 68, 76f, 19.8f, 64, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 8, 11, 58, 0, 0, DateTimeKind.Unspecified), 21, 22f, 48.19f, 39, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 28, 8, 13, 0, 0, DateTimeKind.Unspecified), 94, 25f, 20.03f, 69, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 13, 19, 14, 0, 0, DateTimeKind.Unspecified), 30, 57f, 26.64f, 68, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 19, 6, 26, 0, 0, DateTimeKind.Unspecified), 98, 41f, 11.7f, 23, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 14, 9, 12, 0, 0, DateTimeKind.Unspecified), 70, 27f, 33.99f, 54, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 2, 22, 20, 2, 0, 0, DateTimeKind.Unspecified), 43, 80f, 26.64f, 60 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 7, 13, 8, 0, 0, DateTimeKind.Unspecified), 21, 44f, 3.01f, 74, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 11, 26, 23, 7, 0, 0, DateTimeKind.Unspecified), 40, 84f, 36.29f, 35 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 30, 19, 25, 0, 0, DateTimeKind.Unspecified), 1, 61f, 5.8f, 82, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 24, 2, 55, 0, 0, DateTimeKind.Unspecified), 68, 48f, 34.57f, 54, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 1, 26, 20, 35, 0, 0, DateTimeKind.Unspecified), 71, 48f, 36.14f, 55 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 10, 20, 17, 23, 0, 0, DateTimeKind.Unspecified), 5, 37f, 26.73f, 72 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 25, 4, 43, 0, 0, DateTimeKind.Unspecified), 22, 13f, 24.78f, 51, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 17, 20, 8, 0, 0, DateTimeKind.Unspecified), 25, 23f, 19.83f, 67, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 6, 2, 17, 52, 0, 0, DateTimeKind.Unspecified), 79, 10f, 43.91f, 17 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 7, 15, 28, 0, 0, DateTimeKind.Unspecified), 17, 79f, 28.57f, 11, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 2, 5, 2, 15, 0, 0, DateTimeKind.Unspecified), 21, 29f, 48.25f, 71 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 2, 26, 23, 25, 0, 0, DateTimeKind.Unspecified), 10, 35f, 6.73f, 33 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 6, 4, 11, 0, 0, DateTimeKind.Unspecified), 76, 41f, 17.57f, 13, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 25, 12, 3, 0, 0, DateTimeKind.Unspecified), 72, 63f, 27.5f, 11, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 11, 1, 58, 0, 0, DateTimeKind.Unspecified), 80, 73f, 47.43f, 62, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 1, 4, 1, 11, 0, 0, DateTimeKind.Unspecified), 94, 15f, 38.7f, 82 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 27, 3, 57, 0, 0, DateTimeKind.Unspecified), 42, 7f, 34.09f, 16, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 2, 5, 53, 0, 0, DateTimeKind.Unspecified), 44, 34f, 25.5f, 12, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 26, 3, 33, 0, 0, DateTimeKind.Unspecified), 54, 74f, 14.14f, 76, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 9, 12, 38, 0, 0, DateTimeKind.Unspecified), 22, 76f, 12.34f, 25, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 20, 2, 52, 0, 0, DateTimeKind.Unspecified), 89, 35f, 24.37f, 34, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 24, 1, 58, 0, 0, DateTimeKind.Unspecified), 43, 47f, 34.18f, 59, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 27, 12, 45, 0, 0, DateTimeKind.Unspecified), 2, 53f, 11.48f, 72, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 16, 15, 7, 0, 0, DateTimeKind.Unspecified), 12, 9f, 1.61f, 13, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 4, 16, 22, 0, 0, DateTimeKind.Unspecified), 67, 85f, 24.02f, 46, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 9, 19, 5, 27, 0, 0, DateTimeKind.Unspecified), 81, 60f, 39.92f, 90 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 10, 7, 31, 0, 0, DateTimeKind.Unspecified), 75, 37f, 26.15f, 58, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 25, 17, 25, 0, 0, DateTimeKind.Unspecified), 58, 45f, 6.8f, 64, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 4, 18, 29, 0, 0, DateTimeKind.Unspecified), 76, 52f, 41.71f, 52, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 4, 20, 54, 0, 0, DateTimeKind.Unspecified), 73, 24f, 12.4f, 75, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 7, 2, 16, 6, 0, 0, DateTimeKind.Unspecified), 57, 60f, 48.84f, 87 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 3, 20, 26, 0, 0, DateTimeKind.Unspecified), 81, 63f, 13.61f, 68, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 24, 2, 56, 0, 0, DateTimeKind.Unspecified), 97, 8f, 10.65f, 2, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 26, 9, 14, 0, 0, DateTimeKind.Unspecified), 66, 69f, 13.02f, 96, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 1, 13, 30, 0, 0, DateTimeKind.Unspecified), 20, 3f, 30.27f, 3, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 5, 7, 33, 0, 0, DateTimeKind.Unspecified), 19, 34f, 41.29f, 37, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 10, 2, 11, 10, 0, 0, DateTimeKind.Unspecified), 81, 61f, 15.52f, 40 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 9, 6, 2, 51, 0, 0, DateTimeKind.Unspecified), 90, 24f, 43.2f, 20 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 22, 5, 0, 0, 0, DateTimeKind.Unspecified), 11, 25f, 38.16f, 32, 5 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 11, 19, 37, 0, 0, DateTimeKind.Unspecified), 12.89f, 2, 0.46035716f, 28f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 20, 18, 30, 0, 0, DateTimeKind.Unspecified), 45f, 1, 1.1538461f, 39f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 27, 10, 54, 0, 0, DateTimeKind.Unspecified), 20.84f, 5, 2.605f, 8f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 17, 8, 24, 0, 0, DateTimeKind.Unspecified), 8.39f, 0.36478263f, 23f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 28, 21, 4, 0, 0, DateTimeKind.Unspecified), 20.46f, 0.49902436f, 41f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 20, 11, 7, 0, 0, DateTimeKind.Unspecified), 34.76f, 1.2414285f, 28f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 7, 0, 57, 0, 0, DateTimeKind.Unspecified), 42.6f, 5, 2.6625f, 16f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 1.28f, 3, 0.21333332f, 6f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 3, 5, 4, 0, 0, DateTimeKind.Unspecified), 8.91f, 2, 8.91f, 1f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 20, 21, 52, 0, 0, DateTimeKind.Unspecified), 33.5f, 5, 1.34f, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 1, 23, 28, 0, 0, DateTimeKind.Unspecified), 42.72f, 4, 0.89000005f, 48f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 17, 23, 0, 0, 0, DateTimeKind.Unspecified), 29.59f, 4, 1.7405882f, 17f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 25, 22, 11, 0, 0, DateTimeKind.Unspecified), 13.9f, 0.36578947f, 38f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 16, 6, 17, 0, 0, DateTimeKind.Unspecified), 48.89f, 5, 1.4815152f, 33f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 15, 15, 30, 0, 0, DateTimeKind.Unspecified), 17.81f, 1, 1.113125f, 16f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 22, 18, 56, 0, 0, DateTimeKind.Unspecified), 35.2f, 2, 2.0705884f, 17f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 8, 1, 34, 0, 0, DateTimeKind.Unspecified), 36.3f, 1, 1.8149999f, 20f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 3, 19, 44, 0, 0, DateTimeKind.Unspecified), 19.44f, 3, 1.023158f, 19f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 8, 13, 12, 0, 0, DateTimeKind.Unspecified), 47.41f, 3, 15.803333f, 3f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 24, 8, 42, 0, 0, DateTimeKind.Unspecified), 40.9f, 1, 4.5444446f, 9f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 3, 18, 7, 0, 0, DateTimeKind.Unspecified), 13.59f, 2, 0.7994118f, 17f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 21, 2, 39, 0, 0, DateTimeKind.Unspecified), 25.64f, 0.58272725f, 44f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 23, 10, 34, 0, 0, DateTimeKind.Unspecified), 13.54f, 3, 0.3982353f, 34f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 1, 14, 23, 0, 0, DateTimeKind.Unspecified), 9.21f, 4, 0.25583333f, 36f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 3, 13, 8, 0, 0, DateTimeKind.Unspecified), 19.85f, 1, 0.43152174f, 46f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 5, 13, 41, 0, 0, DateTimeKind.Unspecified), 10.1f, 0.56111115f, 18f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 3, 9, 3, 0, 0, DateTimeKind.Unspecified), 26.86f, 5, 1.033077f, 26f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 7, 16, 55, 0, 0, DateTimeKind.Unspecified), 42.69f, 5, 1.2555882f, 34f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 30, 13, 1, 0, 0, DateTimeKind.Unspecified), 32.07f, 2, 16.035f, 2f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 26, 9, 5, 0, 0, DateTimeKind.Unspecified), 43.22f, 2, 1.3941935f, 31f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 23, 5, 26, 0, 0, DateTimeKind.Unspecified), 21.13f, 3, 0.43122447f, 49f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 31, 23, 25, 0, 0, DateTimeKind.Unspecified), 37.53f, 4, 1.0143243f, 37f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), 34.4f, 1.1466668f, 30f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 18, 9, 58, 0, 0, DateTimeKind.Unspecified), 48.89f, 2, 16.296667f, 3f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 14, 1, 22, 0, 0, DateTimeKind.Unspecified), 12.54f, 4, 0.418f, 30f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 17, 20, 58, 0, 0, DateTimeKind.Unspecified), 6.32f, 5, 0.30095237f, 21f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 14, 21, 4, 0, 0, DateTimeKind.Unspecified), 43.26f, 2, 3.932727f, 11f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 23, 12, 46, 0, 0, DateTimeKind.Unspecified), 9.62f, 2, 0.24666667f, 39f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 8, 4, 15, 0, 0, DateTimeKind.Unspecified), 12.85f, 2, 0.2988372f, 43f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 29, 3, 5, 0, 0, DateTimeKind.Unspecified), 6.51f, 3, 2.17f, 3f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 10, 15, 23, 0, 0, DateTimeKind.Unspecified), 7.78f, 5, 0.17681819f, 44f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 25, 11, 31, 0, 0, DateTimeKind.Unspecified), 5.72f, 4, 0.24869564f, 23f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 21, 11, 55, 0, 0, DateTimeKind.Unspecified), 2.88f, 1, 0.06697675f, 43f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 25, 12, 23, 0, 0, DateTimeKind.Unspecified), 31.97f, 0.6660417f, 48f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 31, 20, 10, 0, 0, DateTimeKind.Unspecified), 36.43f, 5, 0.75895834f, 48f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 2, 6, 9, 0, 0, DateTimeKind.Unspecified), 16.64f, 0.57379305f, 29f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 1, 23, 46, 0, 0, DateTimeKind.Unspecified), 30.45f, 0.84583336f, 36f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 6, 8, 1, 0, 0, DateTimeKind.Unspecified), 1.98f, 4, 0.66f, 3f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 8, 4, 50, 0, 0, DateTimeKind.Unspecified), 25.61f, 1, 0.985f, 26f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 2, 17, 20, 0, 0, DateTimeKind.Unspecified), 22.96f, 2, 0.99826086f, 23f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 27, 0, 58, 0, 0, DateTimeKind.Unspecified), 40.46f, 1, 10.115f, 4f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 13, 6, 26, 0, 0, DateTimeKind.Unspecified), 37.47f, 1, 1.4411539f, 26f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 10, 15, 55, 0, 0, DateTimeKind.Unspecified), 44.77f, 4, 2.4872222f, 18f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 2, 11, 16, 0, 0, DateTimeKind.Unspecified), 27.56f, 5, 0.81058824f, 34f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 16, 16, 10, 0, 0, DateTimeKind.Unspecified), 11.82f, 0.28142858f, 42f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 19, 16, 57, 0, 0, DateTimeKind.Unspecified), 1.35f, 2, 0.036486488f, 37f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Price", "UnitPrice" },
                values: new object[] { new DateTime(2021, 7, 1, 7, 56, 0, 0, DateTimeKind.Unspecified), 42.14f, 1.0278049f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 26, 20, 31, 0, 0, DateTimeKind.Unspecified), 22.64f, 4, 0.6860606f, 33f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 14, 19, 16, 0, 0, DateTimeKind.Unspecified), 48.83f, 1.4361765f, 34f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 26, 7, 22, 0, 0, DateTimeKind.Unspecified), 28.29f, 1.768125f, 16f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 19, 2, 3, 0, 0, DateTimeKind.Unspecified), 45.45f, 1, 3.7875001f, 12f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 28, 8, 1, 0, 0, DateTimeKind.Unspecified), 31.36f, 3, 3.1360002f, 10f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 8, 2, 58, 0, 0, DateTimeKind.Unspecified), 46.03f, 6.575714f, 7f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 7, 19, 59, 0, 0, DateTimeKind.Unspecified), 7.81f, 5, 1.1157143f, 7f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 28, 16, 26, 0, 0, DateTimeKind.Unspecified), 36.02f, 4, 1.566087f, 23f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 2, 0, 3, 0, 0, DateTimeKind.Unspecified), 32.51f, 1, 0.7929268f, 41f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 30, 9, 0, 0, 0, DateTimeKind.Unspecified), 6.6f, 4, 0.18857142f, 35f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 8, 12, 13, 0, 0, DateTimeKind.Unspecified), 43.83f, 3, 0.95282614f, 46f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 3, 4, 55, 0, 0, DateTimeKind.Unspecified), 25.7f, 5, 0.7138889f, 36f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 30, 18, 31, 0, 0, DateTimeKind.Unspecified), 6.49f, 5, 0.3090476f, 21f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 10, 21, 52, 0, 0, DateTimeKind.Unspecified), 47.9f, 5, 9.58f, 5f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 15, 12, 47, 0, 0, DateTimeKind.Unspecified), 26.04f, 0.84000003f, 31f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 29, 15, 29, 0, 0, DateTimeKind.Unspecified), 34.23f, 5, 5.705f, 6f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 10, 10, 7, 0, 0, DateTimeKind.Unspecified), 41.71f, 5, 1.6683999f, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 14, 17, 19, 0, 0, DateTimeKind.Unspecified), 32f, 2, 4.571429f, 7f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 7, 6, 36, 0, 0, DateTimeKind.Unspecified), 33.48f, 2, 11.16f, 3f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 2, 14, 44, 0, 0, DateTimeKind.Unspecified), 6.2f, 5, 1.0333333f, 6f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 28, 22, 11, 0, 0, DateTimeKind.Unspecified), 4.59f, 0.27f, 17f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 29, 18, 12, 0, 0, DateTimeKind.Unspecified), 30.97f, 4, 0.93848485f, 33f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 30, 6, 59, 0, 0, DateTimeKind.Unspecified), 21.41f, 0.5947222f, 36f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 2, 13, 54, 0, 0, DateTimeKind.Unspecified), 48.53f, 4, 48.53f, 1f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 26, 1, 2, 0, 0, DateTimeKind.Unspecified), 35.37f, 4, 7.074f, 5f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 30, 12, 5, 0, 0, DateTimeKind.Unspecified), 10.33f, 2, 0.22955555f, 45f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 30, 19, 40, 0, 0, DateTimeKind.Unspecified), 18.4f, 5, 0.44878048f, 41f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 28, 8, 6, 0, 0, DateTimeKind.Unspecified), 43f, 1, 2.8666666f, 15f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 12, 22, 59, 0, 0, DateTimeKind.Unspecified), 46.21f, 2, 9.242f, 5f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 21, 7, 30, 0, 0, DateTimeKind.Unspecified), 44.89f, 3, 0.9551064f, 47f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice" },
                values: new object[] { new DateTime(2021, 11, 17, 2, 43, 0, 0, DateTimeKind.Unspecified), 3.77f, 1, 0.078541666f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 31, 17, 47, 0, 0, DateTimeKind.Unspecified), 14.07f, 3.5175f, 4f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 23, 8, 24, 0, 0, DateTimeKind.Unspecified), 23.41f, 4, 1.2321053f, 19f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 15, 13, 1, 0, 0, DateTimeKind.Unspecified), 6.33f, 4, 0.5275f, 12f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 22, 0, 32, 0, 0, DateTimeKind.Unspecified), 33.22f, 2, 0.77255815f, 43f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 9, 17, 29, 0, 0, DateTimeKind.Unspecified), 8.18f, 0.18590909f, 44f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 11, 20, 52, 0, 0, DateTimeKind.Unspecified), 6.42f, 4, 0.91714287f, 7f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 13, 1, 1, 0, 0, DateTimeKind.Unspecified), 22.92f, 3, 0.61945945f, 37f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 11, 7, 21, 0, 0, DateTimeKind.Unspecified), 21.22f, 5, 0.5735135f, 37f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 18, 8, 32, 0, 0, DateTimeKind.Unspecified), 18.69f, 1, 0.44500002f, 42f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 14, 15, 56, 0, 0, DateTimeKind.Unspecified), 17.69f, 5, 17.69f, 1f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 25, 19, 56, 0, 0, DateTimeKind.Unspecified), 31.56f, 5, 3.156f, 10f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 1, 20, 7, 0, 0, DateTimeKind.Unspecified), 48.35f, 4, 2.1977272f, 22f });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 28, 17, 10, 0, 0, DateTimeKind.Unspecified), "eAKJWJAA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 20, 16, 2, 0, 0, DateTimeKind.Unspecified), "KzSwJdHp" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 28, 22, 40, 0, 0, DateTimeKind.Unspecified), "aSAWADuA" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 2, 15, 33, 0, 0, DateTimeKind.Unspecified), "JanHiAlW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 26, 13, 49, 0, 0, DateTimeKind.Unspecified), "JmtmJMJH" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 10, 7, 51, 0, 0, DateTimeKind.Unspecified), "kSAcwLib" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 31, 22, 39, 0, 0, DateTimeKind.Unspecified), "DpsASsSK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 12, 7, 7, 0, 0, DateTimeKind.Unspecified), "wJLKJkrd" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 27, 4, 6, 0, 0, DateTimeKind.Unspecified), "kDSsWvvf" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 7, 7, 37, 0, 0, DateTimeKind.Unspecified), "rmuKaruc" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 7, 18, 30, 0, 0, DateTimeKind.Unspecified), "LleAlBlu" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 16, 5, 24, 0, 0, DateTimeKind.Unspecified), "oIWacLca" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 16, 12, 35, 0, 0, DateTimeKind.Unspecified), "JzLAfIri" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 30, 9, 45, 0, 0, DateTimeKind.Unspecified), "JsswSiKh" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 12, 8, 26, 0, 0, DateTimeKind.Unspecified), "wWAtfsSW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 24, 4, 5, 0, 0, DateTimeKind.Unspecified), "JrcASvcw" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 24, 16, 56, 0, 0, DateTimeKind.Unspecified), "juhKwMAb" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 18, 16, 35, 0, 0, DateTimeKind.Unspecified), "JAWJiJzf" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 21, 16, 31, 0, 0, DateTimeKind.Unspecified), "mJDnAHJh" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 19, 12, 57, 0, 0, DateTimeKind.Unspecified), "JiJWKsBw" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 6, 6, 52, 0, 0, DateTimeKind.Unspecified), "oJnKbDHK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 4, 13, 7, 0, 0, DateTimeKind.Unspecified), "AJwjAAAD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 18, 7, 2, 0, 0, DateTimeKind.Unspecified), "MAJaMWKB" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 28, 4, 13, 0, 0, DateTimeKind.Unspecified), "AaSpignv" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 22, 12, 16, 0, 0, DateTimeKind.Unspecified), "uwWowAen" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 5, 6, 49, 0, 0, DateTimeKind.Unspecified), "WSubiASW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 9, 4, 56, 0, 0, DateTimeKind.Unspecified), "HJJSLBDD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 15, 23, 54, 0, 0, DateTimeKind.Unspecified), "pJcbbruS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 5, 10, 3, 0, 0, DateTimeKind.Unspecified), "WdIarkDb" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 31, 0, 41, 0, 0, DateTimeKind.Unspecified), "LsbStDsI" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 26, 6, 33, 0, 0, DateTimeKind.Unspecified), "snHvmsDL" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 3, 20, 51, 0, 0, DateTimeKind.Unspecified), "MdWSSdlJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 1, 9, 43, 0, 0, DateTimeKind.Unspecified), "BWzfMSrz" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 13, 15, 45, 0, 0, DateTimeKind.Unspecified), "kLDAAJgW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 25, 23, 42, 0, 0, DateTimeKind.Unspecified), "umWKHWwh" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 21, 14, 8, 0, 0, DateTimeKind.Unspecified), "wSfmmIkW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 25, 16, 25, 0, 0, DateTimeKind.Unspecified), "guvAelMS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 31, 17, 34, 0, 0, DateTimeKind.Unspecified), "Aljuwdsn" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 16, 3, 19, 0, 0, DateTimeKind.Unspecified), "SirDtsSK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 26, 15, 12, 0, 0, DateTimeKind.Unspecified), "knJWDdjv" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 19, 1, 19, 0, 0, DateTimeKind.Unspecified), "SjtekvAh" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 27, 23, 14, 0, 0, DateTimeKind.Unspecified), "rSLzKdHv" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 17, 8, 33, 0, 0, DateTimeKind.Unspecified), "DLpdwSuH" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 2, 0, 0, DateTimeKind.Unspecified), "sLAIWSjL" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 24, 7, 57, 0, 0, DateTimeKind.Unspecified), "bWJnAncB" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 26, 15, 17, 0, 0, DateTimeKind.Unspecified), "wilvWAWg" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 26, 15, 20, 0, 0, DateTimeKind.Unspecified), "JktWKgSa" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 31, 20, 57, 0, 0, DateTimeKind.Unspecified), "IAStAJKu" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 8, 2, 42, 0, 0, DateTimeKind.Unspecified), "KDvDpuAo" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 29, 8, 44, 0, 0, DateTimeKind.Unspecified), "WWWouWcS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 13, 10, 29, 0, 0, DateTimeKind.Unspecified), "csjtKDeM" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 10, 14, 13, 0, 0, DateTimeKind.Unspecified), "LJwDSWWD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 2, 17, 19, 0, 0, DateTimeKind.Unspecified), "JSHJeIIk" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 3, 16, 43, 0, 0, DateTimeKind.Unspecified), "DdMDDSWL" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 30, 5, 29, 0, 0, DateTimeKind.Unspecified), "SWrKWiSl" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 22, 4, 2, 0, 0, DateTimeKind.Unspecified), "MAhDAAHe" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 31, 8, 59, 0, 0, DateTimeKind.Unspecified), "iaWKozLl" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 7, 30, 18, 27, 0, 0, DateTimeKind.Unspecified), "KWAAJetk" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 12, 3, 16, 0, 0, DateTimeKind.Unspecified), "hJsSscJs" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 22, 6, 59, 0, 0, DateTimeKind.Unspecified), "avSDHloI" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 2, 2, 55, 0, 0, DateTimeKind.Unspecified), "uISDSbBk" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 15, 22, 45, 0, 0, DateTimeKind.Unspecified), "LeDSorJI" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 3, 0, 0, DateTimeKind.Unspecified), "gAzosSJf" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 28, 3, 25, 0, 0, DateTimeKind.Unspecified), "flKJSnDp" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 10, 1, 3, 0, 0, DateTimeKind.Unspecified), "HdeInAmf" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 39, 0, 0, DateTimeKind.Unspecified), "ehfmcihH" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 15, 19, 40, 0, 0, DateTimeKind.Unspecified), "IAsSIazW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 3, 20, 49, 0, 0, DateTimeKind.Unspecified), "dAuSsHAD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 5, 10, 2, 0, 0, DateTimeKind.Unspecified), "DWclmSDn" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 19, 18, 17, 0, 0, DateTimeKind.Unspecified), "WpjkWwcS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 1, 11, 39, 0, 0, DateTimeKind.Unspecified), "eMdWILDH" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 22, 23, 21, 0, 0, DateTimeKind.Unspecified), "JuJDsDSz" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 1, 13, 16, 0, 0, DateTimeKind.Unspecified), "HBJtgMuW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 24, 1, 18, 0, 0, DateTimeKind.Unspecified), "vibwSleW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 1, 11, 38, 0, 0, DateTimeKind.Unspecified), "SzSKDAKW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 10, 7, 37, 0, 0, DateTimeKind.Unspecified), "htWAdAIh" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 21, 4, 33, 0, 0, DateTimeKind.Unspecified), "HKKdSWSi" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 14, 9, 59, 0, 0, DateTimeKind.Unspecified), "AetJIbLu" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 6, 20, 16, 0, 0, DateTimeKind.Unspecified), "phSaJeAS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 24, 20, 59, 0, 0, DateTimeKind.Unspecified), "KdlJpBMw" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 9, 15, 29, 0, 0, DateTimeKind.Unspecified), "tJScHaAW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 8, 7, 58, 0, 0, DateTimeKind.Unspecified), "JscwpgAf" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 8, 21, 11, 0, 0, DateTimeKind.Unspecified), "BkBADWnK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 5, 1, 19, 0, 0, DateTimeKind.Unspecified), "MWoHsdAS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 20, 14, 12, 0, 0, DateTimeKind.Unspecified), "jMmAkWJo" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 2, 16, 16, 20, 0, 0, DateTimeKind.Unspecified), "nDtvctSS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 4, 3, 31, 0, 0, DateTimeKind.Unspecified), "jfkfDWAD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), "WmhcAjAK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 14, 10, 15, 0, 0, DateTimeKind.Unspecified), "WenvASJJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 1, 4, 19, 39, 0, 0, DateTimeKind.Unspecified), "smSauLDD" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 19, 5, 9, 0, 0, DateTimeKind.Unspecified), "WSsrAKSl" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 10, 24, 21, 58, 0, 0, DateTimeKind.Unspecified), "uHpWJWDe" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 5, 22, 14, 18, 0, 0, DateTimeKind.Unspecified), "wSSSfkKm" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 8, 22, 20, 20, 0, 0, DateTimeKind.Unspecified), "ksSJpAjK" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 27, 12, 17, 0, 0, DateTimeKind.Unspecified), "JSedJiWS" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 3, 6, 2, 33, 0, 0, DateTimeKind.Unspecified), "hbakJAfW" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 4, 18, 2, 10, 0, 0, DateTimeKind.Unspecified), "HKDKaKuJ" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 18, 5, 8, 0, 0, DateTimeKind.Unspecified), "JkgvgkMM" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 9, 23, 19, 59, 0, 0, DateTimeKind.Unspecified), "wBlDDDrp" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 11, 17, 10, 18, 0, 0, DateTimeKind.Unspecified), "hDIdkKJn" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 3, 21, 9, 0, 0, DateTimeKind.Unspecified), "rLdJWJKi", 17, 86.64206f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 24, 11, 33, 0, 0, DateTimeKind.Unspecified), "lriDbmAA", 2, 44.742138f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 2, 3, 6, 0, 0, DateTimeKind.Unspecified), "geSeAgjh", 2, 23.898802f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 9, 10, 18, 0, 0, DateTimeKind.Unspecified), "kkvaKrBp", 47, 40.128407f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 20, 19, 28, 0, 0, DateTimeKind.Unspecified), "DLengiSA", 12, 63.43112f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 14, 12, 11, 0, 0, DateTimeKind.Unspecified), "WcKmrSnJ", 33, 68.491394f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 13, 14, 57, 0, 0, DateTimeKind.Unspecified), "nASfSBDj", 11, 94.74876f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 4, 5, 47, 0, 0, DateTimeKind.Unspecified), "HADJkJvJ", 1, 78.0764f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 16, 17, 57, 0, 0, DateTimeKind.Unspecified), "ILAjizIW", 83.62943f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 7, 9, 34, 0, 0, DateTimeKind.Unspecified), "hAoStSIu", 4, 2.893791f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 21, 2, 13, 0, 0, DateTimeKind.Unspecified), "SDSJuvwc", 29, 25.786161f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 3, 9, 45, 0, 0, DateTimeKind.Unspecified), "nJJjSjHc", 22, 38.98796f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 26, 2, 19, 0, 0, DateTimeKind.Unspecified), "SAzwJeSL", 39, 56.262688f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 15, 12, 17, 0, 0, DateTimeKind.Unspecified), "dDWWlASA", 10, 15.232336f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 21, 17, 27, 0, 0, DateTimeKind.Unspecified), "ggIAaDAu", 19, 67.265976f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 22, 1, 0, 0, 0, DateTimeKind.Unspecified), "tJAoIWrS", 34, 91.07982f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 26, 19, 56, 0, 0, DateTimeKind.Unspecified), "kmDAApDL", 8, 33.268383f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 9, 7, 17, 0, 0, DateTimeKind.Unspecified), "WJSvzDSr", 38, 4.2644815f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 8, 11, 53, 0, 0, DateTimeKind.Unspecified), "cMdAtWcg", 37, 59.587498f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 16, 17, 26, 0, 0, DateTimeKind.Unspecified), "tcfaizbs", 45, 30.52692f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 9, 16, 33, 0, 0, DateTimeKind.Unspecified), "SaKDSrkI", 47, 81.03663f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 11, 6, 16, 0, 0, DateTimeKind.Unspecified), "WSMgAdSL", 26, 44.37171f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 25, 0, 0, DateTimeKind.Unspecified), "dDlMBSDl", 30, 97.72798f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 13, 20, 30, 0, 0, DateTimeKind.Unspecified), "jAgzjDWs", 37, 81.15267f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 13, 5, 29, 0, 0, DateTimeKind.Unspecified), "LsKzJStS", 9, 54.045193f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 22, 21, 19, 0, 0, DateTimeKind.Unspecified), "WmMvcMvo", 6, 87.1641f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 17, 0, 0, DateTimeKind.Unspecified), "fmADjgAS", 15, 5.8974338f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 18, 18, 36, 0, 0, DateTimeKind.Unspecified), "zDWdjWJe", 28, 81.75772f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 26, 9, 6, 0, 0, DateTimeKind.Unspecified), "nBorpAfl", 8, 43.12394f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 5, 9, 57, 0, 0, DateTimeKind.Unspecified), "kAknMhio", 44, 64.72171f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 22, 22, 3, 0, 0, DateTimeKind.Unspecified), "zLpADfhA", 47, 5.515864f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 20, 22, 48, 0, 0, DateTimeKind.Unspecified), "zAakbpDM", 15, 85.47021f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 4, 2, 14, 0, 0, DateTimeKind.Unspecified), "SShDJeWJ", 22, 92.2469f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 27, 22, 4, 0, 0, DateTimeKind.Unspecified), "hAtWMHMn", 13, 41.727196f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 27, 9, 49, 0, 0, DateTimeKind.Unspecified), "rASssWAh", 32, 28.143661f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 12, 2, 21, 0, 0, DateTimeKind.Unspecified), "uDMtAJkJ", 27, 76.66419f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 27, 21, 56, 0, 0, DateTimeKind.Unspecified), "WoJeaHHs", 11, 65.267746f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 20, 1, 46, 0, 0, DateTimeKind.Unspecified), "AAWJJwWK", 34, 28.784206f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 8, 0, 12, 0, 0, DateTimeKind.Unspecified), "aJABHisW", 41, 34.15601f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 16, 19, 54, 0, 0, DateTimeKind.Unspecified), "pDfcjWfn", 18, 37.45485f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 28, 8, 2, 0, 0, DateTimeKind.Unspecified), "AwAJbSmW", 29, 97.172874f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 19, 1, 42, 0, 0, DateTimeKind.Unspecified), "LoAJMJvA", 28, 40.827515f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 1, 8, 45, 0, 0, DateTimeKind.Unspecified), "WgsKaHkI", 35, 4.2211614f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 22, 8, 12, 0, 0, DateTimeKind.Unspecified), "LHWaBJhn", 25, 25.16691f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 1, 6, 11, 0, 0, DateTimeKind.Unspecified), "WAtmKiJj", 19, 73.578766f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 16, 3, 16, 0, 0, DateTimeKind.Unspecified), "wjWtWAcW", 29, 15.23656f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 24, 22, 12, 0, 0, DateTimeKind.Unspecified), "KjmclsmS", 7, 71.53264f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 23, 5, 12, 0, 0, DateTimeKind.Unspecified), "mMKsbmgk", 13, 66.730225f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 19, 3, 24, 0, 0, DateTimeKind.Unspecified), "glhulhhJ", 41, 70.90285f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "tioIWLfg", 29, 4.2199564f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 13, 11, 25, 0, 0, DateTimeKind.Unspecified), "Jesstfbl", 41, 54.622932f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 8, 1, 14, 0, 0, DateTimeKind.Unspecified), "mKaLuuil", 3, 19.041882f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 4, 4, 2, 0, 0, DateTimeKind.Unspecified), "dwmsKHzu", 9, 96.680374f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 9, 2, 30, 0, 0, DateTimeKind.Unspecified), "cJWcdzLv", 39, 80.86046f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 24, 3, 34, 0, 0, DateTimeKind.Unspecified), "WSJAWWLb", 37, 2.4951057f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 23, 14, 52, 0, 0, DateTimeKind.Unspecified), "jMgWhokD", 43, 91.474686f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 16, 17, 7, 0, 0, DateTimeKind.Unspecified), "adSADHKS", 16, 93.77735f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 17, 6, 35, 0, 0, DateTimeKind.Unspecified), "HcoJvDiI", 17, 59.60504f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 29, 4, 49, 0, 0, DateTimeKind.Unspecified), "SWdKSlzo", 25, 76.82633f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 1, 22, 8, 0, 0, DateTimeKind.Unspecified), "JlnSDKmJ", 26, 59.098656f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 8, 16, 54, 0, 0, DateTimeKind.Unspecified), "vWcaArSf", 33, 95.74702f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 25, 20, 20, 0, 0, DateTimeKind.Unspecified), "dWnJwfWk", 49, 11.492152f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 6, 20, 41, 0, 0, DateTimeKind.Unspecified), "JrWKlsrK", 42, 48.835846f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 13, 8, 0, 0, 0, DateTimeKind.Unspecified), "JzJruAzJ", 27, 37.942123f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 18, 11, 30, 0, 0, DateTimeKind.Unspecified), "IKrJAiet", 4, 59.34261f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 31, 3, 24, 0, 0, DateTimeKind.Unspecified), "KSAASWSA", 20, 25.234814f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 30, 7, 31, 0, 0, DateTimeKind.Unspecified), "SdJjIWAS", 18, 33.117516f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 29, 4, 14, 0, 0, DateTimeKind.Unspecified), "sntnzASg", 81.900536f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 22, 2, 27, 0, 0, DateTimeKind.Unspecified), "suSMWAnD", 45, 54.18482f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 12, 15, 6, 0, 0, DateTimeKind.Unspecified), "lDInJwSS", 9, 18.05375f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 24, 3, 4, 0, 0, DateTimeKind.Unspecified), "WuArbldf", 22, 75.958336f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 7, 18, 10, 0, 0, DateTimeKind.Unspecified), "dttSWSAm", 38, 4.8176146f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 4, 7, 5, 0, 0, DateTimeKind.Unspecified), "lKAKJASW", 41, 91.986855f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 23, 15, 58, 0, 0, DateTimeKind.Unspecified), "WpSkJljJ", 12, 97.55053f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 19, 9, 23, 0, 0, DateTimeKind.Unspecified), "szWcItfg", 36, 18.940086f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 22, 14, 50, 0, 0, DateTimeKind.Unspecified), "pLLvwSWv", 49, 47.04238f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 8, 21, 31, 0, 0, DateTimeKind.Unspecified), "HBbjWmkW", 29, 68.65635f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 15, 10, 12, 0, 0, DateTimeKind.Unspecified), "HMBSnLkS", 3.7450392f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 11, 14, 19, 0, 0, DateTimeKind.Unspecified), "iAisgAsL", 27, 14.673566f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 29, 2, 12, 0, 0, DateTimeKind.Unspecified), "stlMepph", 15, 37.812687f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 26, 23, 7, 0, 0, DateTimeKind.Unspecified), "DBKsjaMk", 25, 97.20065f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 15, 14, 5, 0, 0, DateTimeKind.Unspecified), "lauJStLs", 41, 96.9062f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 30, 15, 11, 0, 0, DateTimeKind.Unspecified), "JalWsznW", 49, 76.19395f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 5, 9, 5, 0, 0, DateTimeKind.Unspecified), "djJDapDs", 12, 40.218124f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 20, 22, 31, 0, 0, DateTimeKind.Unspecified), "WujJoASh", 36, 93.28846f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 13, 20, 48, 0, 0, DateTimeKind.Unspecified), "WWggwDad", 82.9638f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 17, 18, 45, 0, 0, DateTimeKind.Unspecified), "BWnddrAd", 9, 11.405597f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 6, 23, 23, 43, 0, 0, DateTimeKind.Unspecified), "mKnampjM", 15, 90.1356f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 8, 2, 18, 30, 0, 0, DateTimeKind.Unspecified), "vbozieiJ", 18, 61.145824f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 4, 3, 18, 57, 0, 0, DateTimeKind.Unspecified), "tdtwogpA", 14, 97.20086f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 1, 24, 9, 13, 0, 0, DateTimeKind.Unspecified), "iWclbAom", 39, 72.00748f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 8, 15, 20, 0, 0, DateTimeKind.Unspecified), "AgwDWSMn", 41, 75.64413f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 24, 20, 57, 0, 0, DateTimeKind.Unspecified), "WkSsoDJz", 46, 69.93323f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 5, 2, 4, 0, 0, DateTimeKind.Unspecified), "WBADWkKg", 4, 74.94989f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 9, 3, 0, 0, 0, DateTimeKind.Unspecified), "sWSDnSJM", 1, 40.892582f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 1, 11, 42, 0, 0, DateTimeKind.Unspecified), "SbScJShS", 28, 80.63323f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 10, 5, 1, 0, 0, DateTimeKind.Unspecified), "ifAevAjW", 31, 84.62899f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 22, 0, 45, 0, 0, DateTimeKind.Unspecified), "IWJAIpoA", 13, 21.711735f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 2, 4, 20, 41, 0, 0, DateTimeKind.Unspecified), "ssdIIpaS", 36, 67.2933f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 9, 1, 2, 46, 0, 0, DateTimeKind.Unspecified), "pSSnLSSW", 40, 54.963352f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 7, 23, 25, 0, 0, DateTimeKind.Unspecified), 13, 0f, 34.62f, 17, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 7, 0, 10, 0, 0, DateTimeKind.Unspecified), 50, 0f, 33.06f, 24, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 5, 11, 3, 0, 0, DateTimeKind.Unspecified), 32, 0f, 33.74f, 32, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 24, 4, 27, 0, 0, DateTimeKind.Unspecified), 39, 0f, 25.35f, 26, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 8, 6, 16, 0, 0, DateTimeKind.Unspecified), 72, 0f, 30.23f, 62, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 27, 8, 13, 0, 0, DateTimeKind.Unspecified), 25, 0f, 20.76f, 99, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 4, 20, 8, 0, 0, DateTimeKind.Unspecified), 5, 0f, 8.52f, 99, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 9, 9, 19, 0, 0, DateTimeKind.Unspecified), 42, 0f, 23.43f, 51, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 17, 11, 22, 0, 0, DateTimeKind.Unspecified), 48, 0f, 28.34f, 22, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 5, 13, 35, 0, 0, DateTimeKind.Unspecified), 56, 0f, 10.02f, 13, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 8, 21, 8, 23, 0, 0, DateTimeKind.Unspecified), 74, 0f, 13.18f, 38 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 24, 3, 41, 0, 0, DateTimeKind.Unspecified), 52, 0f, 23.63f, 45, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 26, 12, 42, 0, 0, DateTimeKind.Unspecified), 9, 0f, 45.54f, 98, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 29, 7, 42, 0, 0, DateTimeKind.Unspecified), 16, 0f, 7.72f, 27, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 28, 8, 55, 0, 0, DateTimeKind.Unspecified), 93, 0f, 5.44f, 84, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 10, 18, 13, 0, 0, DateTimeKind.Unspecified), 16, 0f, 14.02f, 14, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 11, 5, 8, 11, 0, 0, DateTimeKind.Unspecified), 7, 0f, 19.56f, 43 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 8, 22, 10, 0, 0, DateTimeKind.Unspecified), 79, 0f, 49.43f, 25, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 17, 20, 16, 0, 0, DateTimeKind.Unspecified), 95, 0f, 41.43f, 99, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 5, 10, 44, 0, 0, DateTimeKind.Unspecified), 58, 0f, 2.27f, 13, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 23, 9, 21, 0, 0, DateTimeKind.Unspecified), 42, 0f, 24.68f, 96, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 20, 2, 2, 0, 0, DateTimeKind.Unspecified), 66, 0f, 40.5f, 45, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 29, 2, 11, 0, 0, DateTimeKind.Unspecified), 25, 0f, 22.76f, 30, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 24, 13, 32, 0, 0, DateTimeKind.Unspecified), 70, 0f, 17.41f, 92, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 7, 16, 20, 32, 0, 0, DateTimeKind.Unspecified), 18, 0f, 35.15f, 48 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 3, 10, 20, 36, 0, 0, DateTimeKind.Unspecified), 11, 0f, 33.53f, 88 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 10, 13, 21, 30, 0, 0, DateTimeKind.Unspecified), 13, 0f, 1.09f, 55 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 29, 12, 1, 0, 0, DateTimeKind.Unspecified), 59, 0f, 35.22f, 1, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 2, 4, 37, 0, 0, DateTimeKind.Unspecified), 97, 0f, 24.48f, 59, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 8, 23, 21, 23, 0, 0, DateTimeKind.Unspecified), 53, 0f, 4.86f, 75 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 30, 14, 32, 0, 0, DateTimeKind.Unspecified), 24, 0f, 31.46f, 42, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 14, 0, 48, 0, 0, DateTimeKind.Unspecified), 71, 0f, 16.33f, 79, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 8, 23, 17, 29, 0, 0, DateTimeKind.Unspecified), 1, 0f, 15.95f, 34 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 30, 21, 14, 0, 0, DateTimeKind.Unspecified), 24, 0f, 17.87f, 17, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 8, 20, 9, 0, 0, DateTimeKind.Unspecified), 99, 0f, 6.72f, 34, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 23, 4, 28, 0, 0, DateTimeKind.Unspecified), 70, 0f, 12.87f, 50, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 20, 2, 58, 0, 0, DateTimeKind.Unspecified), 5, 0f, 39.54f, 36, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 8, 22, 10, 0, 0, DateTimeKind.Unspecified), 51, 0f, 27.63f, 31, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 25, 15, 42, 0, 0, DateTimeKind.Unspecified), 27, 0f, 19.75f, 29, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 9, 7, 10, 0, 0, DateTimeKind.Unspecified), 68, 0f, 26.07f, 58, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 1, 23, 19, 0, 0, DateTimeKind.Unspecified), 18, 0f, 10.29f, 51, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 9, 11, 21, 0, 0, DateTimeKind.Unspecified), 12, 0f, 45.23f, 43, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 3, 11, 25, 0, 0, DateTimeKind.Unspecified), 48, 0f, 23.72f, 9, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 9, 7, 7, 18, 0, 0, DateTimeKind.Unspecified), 21, 0f, 37.83f, 29 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 8, 17, 26, 0, 0, DateTimeKind.Unspecified), 70, 0f, 35.76f, 66, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 25, 19, 56, 0, 0, DateTimeKind.Unspecified), 61, 0f, 19.36f, 7, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 11, 4, 8, 9, 0, 0, DateTimeKind.Unspecified), 18, 0f, 8.76f, 82 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 5, 19, 33, 0, 0, DateTimeKind.Unspecified), 85, 0f, 25.88f, 18, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 15, 19, 45, 0, 0, DateTimeKind.Unspecified), 60, 0f, 16.68f, 20, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 8, 22, 9, 27, 0, 0, DateTimeKind.Unspecified), 81, 0f, 33.65f, 80 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 4, 9, 18, 0, 0, DateTimeKind.Unspecified), 93, 0f, 35.98f, 37, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 16, 18, 11, 0, 0, DateTimeKind.Unspecified), 47, 0f, 22.01f, 81, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 7, 16, 31, 0, 0, DateTimeKind.Unspecified), 75, 0f, 27.59f, 81, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 2, 0, 5, 0, 0, DateTimeKind.Unspecified), 33, 0f, 34.63f, 91, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 5, 0, 14, 0, 0, DateTimeKind.Unspecified), 71, 0f, 43.13f, 44, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 18, 21, 23, 0, 0, DateTimeKind.Unspecified), 39, 0f, 2.74f, 7, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 6, 21, 59, 0, 0, DateTimeKind.Unspecified), 95, 0f, 36.3f, 25, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 12, 21, 30, 0, 0, DateTimeKind.Unspecified), 48, 0f, 9.32f, 89, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 6, 7, 55, 0, 0, DateTimeKind.Unspecified), 42, 0f, 24.29f, 71, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 28, 9, 40, 0, 0, DateTimeKind.Unspecified), 6, 0f, 36.55f, 44, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 3, 14, 10, 43, 0, 0, DateTimeKind.Unspecified), 13, 0f, 2.72f, 48 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 9, 8, 7, 0, 0, DateTimeKind.Unspecified), 6, 0f, 28.09f, 66, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 3, 11, 4, 42, 0, 0, DateTimeKind.Unspecified), 44, 0f, 35.54f, 42 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 25, 13, 59, 0, 0, DateTimeKind.Unspecified), 3, 0f, 12.31f, 86, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 3, 23, 3, 0, 0, DateTimeKind.Unspecified), 15, 0f, 19.35f, 44, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 11, 5, 7, 35, 0, 0, DateTimeKind.Unspecified), 22, 0f, 29.25f, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 1, 1, 10, 11, 0, 0, DateTimeKind.Unspecified), 66, 0f, 24.64f, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 24, 15, 28, 0, 0, DateTimeKind.Unspecified), 92, 0f, 1.68f, 13, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 5, 19, 11, 33, 0, 0, DateTimeKind.Unspecified), 90, 0f, 5.94f, 83, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 1, 6, 4, 26, 0, 0, DateTimeKind.Unspecified), 72, 0f, 47.95f, 28 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 20, 15, 15, 0, 0, DateTimeKind.Unspecified), 81, 0f, 21.31f, 41, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 5, 30, 10, 1, 0, 0, DateTimeKind.Unspecified), 74, 0f, 34.5f, 34 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 3, 14, 6, 28, 0, 0, DateTimeKind.Unspecified), 47, 0f, 16.63f, 44 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 9, 13, 5, 0, 0, DateTimeKind.Unspecified), 95, 0f, 3.56f, 76, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 3, 7, 11, 24, 0, 0, DateTimeKind.Unspecified), 3, 0f, 28.7f, 94, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 11, 21, 59, 0, 0, DateTimeKind.Unspecified), 7, 0f, 22.49f, 54, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 8, 17, 14, 37, 0, 0, DateTimeKind.Unspecified), 28, 0f, 32.23f, 31 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 19, 18, 52, 0, 0, DateTimeKind.Unspecified), 25, 0f, 9.98f, 19, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 14, 20, 6, 0, 0, DateTimeKind.Unspecified), 25, 0f, 25.09f, 38, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 22, 0, 35, 0, 0, DateTimeKind.Unspecified), 58, 0f, 23.56f, 37, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 4, 12, 26, 0, 0, DateTimeKind.Unspecified), 67, 0f, 20.73f, 32, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 57, 0, 0, DateTimeKind.Unspecified), 25, 0f, 36.9f, 39, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 2, 13, 16, 15, 0, 0, DateTimeKind.Unspecified), 30, 0f, 10.55f, 27, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 8, 19, 10, 0, 0, DateTimeKind.Unspecified), 82, 0f, 5.59f, 16, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 1, 20, 12, 4, 0, 0, DateTimeKind.Unspecified), 77, 0f, 4.9f, 52, 3 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 12, 20, 20, 0, 0, DateTimeKind.Unspecified), 52, 0f, 24.52f, 70, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 7, 10, 8, 17, 0, 0, DateTimeKind.Unspecified), 60, 0f, 44.39f, 95 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 22, 17, 23, 0, 0, DateTimeKind.Unspecified), 89, 0f, 45.15f, 64, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 23, 20, 59, 0, 0, DateTimeKind.Unspecified), 52, 0f, 14.87f, 93, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 20, 22, 45, 0, 0, DateTimeKind.Unspecified), 5, 0f, 47.8f, 8, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 10, 15, 6, 29, 0, 0, DateTimeKind.Unspecified), 49, 0f, 43.38f, 54, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 10, 6, 5, 27, 0, 0, DateTimeKind.Unspecified), 60, 0f, 24.9f, 54 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 7, 1, 14, 15, 0, 0, DateTimeKind.Unspecified), 77, 0f, 10.86f, 86, 2 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 11, 26, 6, 1, 0, 0, DateTimeKind.Unspecified), 42, 0f, 40.92f, 66, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 8, 28, 20, 27, 0, 0, DateTimeKind.Unspecified), 91, 0f, 47.93f, 27, 1 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 4, 25, 15, 11, 0, 0, DateTimeKind.Unspecified), 50, 0f, 10.52f, 99, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 1, 6, 39, 0, 0, DateTimeKind.Unspecified), 56, 0f, 34.5f, 65, 5 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 7, 9, 21, 25, 0, 0, DateTimeKind.Unspecified), 74, 0f, 25.82f, 47 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId" },
                values: new object[] { new DateTime(2021, 11, 2, 8, 15, 0, 0, DateTimeKind.Unspecified), 41, 0f, 1.77f, 4 });

            migrationBuilder.UpdateData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { new DateTime(2021, 9, 1, 9, 50, 0, 0, DateTimeKind.Unspecified), 32, 0f, 21.7f, 17, 4 });

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
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 18, 5, 41, 0, 0, DateTimeKind.Unspecified), 15.43f, 0.964375f, 16f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 11, 16, 8, 0, 0, DateTimeKind.Unspecified), 33.67f, 5.611666f, 6f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 8, 11, 22, 0, 0, DateTimeKind.Unspecified), 11.68f, 0.4672f, 25f });

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
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 7, 8, 21, 0, 0, DateTimeKind.Unspecified), 31.87f, 5, 0.79675f, 40f });

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
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 11, 19, 59, 0, 0, DateTimeKind.Unspecified), 16.49f, 3, 0.5686207f, 29f });

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
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 11, 6, 49, 0, 0, DateTimeKind.Unspecified), 14.31f, 5, 0.4471875f, 32f });

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
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 12, 3, 3, 0, 0, DateTimeKind.Unspecified), 36.42f, 1.0711764f, 34f });

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
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 24, 23, 19, 0, 0, DateTimeKind.Unspecified), 42.17f, 2.8113332f, 15f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 8, 15, 1, 0, 0, DateTimeKind.Unspecified), 48.46f, 2, 1.514375f, 32f });

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
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 22, 17, 33, 0, 0, DateTimeKind.Unspecified), 35.87f, 5, 1.6304545f, 22f });

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
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 3, 13, 17, 44, 0, 0, DateTimeKind.Unspecified), 33.14f, 3, 1.4408696f, 23f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 18, 14, 41, 0, 0, DateTimeKind.Unspecified), 2.46f, 0.098400004f, 25f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 27, 10, 18, 0, 0, DateTimeKind.Unspecified), 44.95f, 2.6441176f, 17f });

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
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 8, 1, 13, 0, 0, DateTimeKind.Unspecified), 4.28f, 1, 0.093043484f, 46f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 17, 4, 48, 0, 0, DateTimeKind.Unspecified), 35.03f, 2, 1.5230434f, 23f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 28, 22, 39, 0, 0, DateTimeKind.Unspecified), 32.81f, 16.405f, 2f });

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
                columns: new[] { "CreatedDate", "Price", "UnitPrice" },
                values: new object[] { new DateTime(2021, 3, 17, 0, 32, 0, 0, DateTimeKind.Unspecified), 2.51f, 0.061219513f });

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
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 11, 3, 6, 0, 0, DateTimeKind.Unspecified), 11.55f, 11.55f, 1f });

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
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 11, 23, 2, 37, 0, 0, DateTimeKind.Unspecified), 38.94f, 2, 9.735f, 4f });

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
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 11, 10, 5, 0, 0, DateTimeKind.Unspecified), 20.73f, 1.2194117f, 17f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 14, 7, 40, 0, 0, DateTimeKind.Unspecified), 6.81f, 1, 0.681f, 10f });

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
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 23, 22, 36, 0, 0, DateTimeKind.Unspecified), 27.28f, 1.1366667f, 24f });

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
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 7, 21, 11, 54, 0, 0, DateTimeKind.Unspecified), 21.22f, 1.5157143f, 14f });

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
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 6, 23, 11, 42, 0, 0, DateTimeKind.Unspecified), 26.69f, 4, 0.76257145f, 35f });

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
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice" },
                values: new object[] { new DateTime(2021, 5, 1, 12, 33, 0, 0, DateTimeKind.Unspecified), 41.54f, 3, 0.8654167f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 2, 21, 7, 34, 0, 0, DateTimeKind.Unspecified), 5.99f, 0.14609756f, 41f });

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
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 10, 9, 15, 44, 0, 0, DateTimeKind.Unspecified), 9.15f, 5, 0.26911762f, 34f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Price", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 19, 17, 38, 0, 0, DateTimeKind.Unspecified), 48.21f, 2.8358822f, 17f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 15, 4, 25, 0, 0, DateTimeKind.Unspecified), 32.24f, 3, 0.6859575f, 47f });

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
                columns: new[] { "CreatedDate", "Price", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 18, 13, 54, 0, 0, DateTimeKind.Unspecified), 43.62f, 2, 2.181f, 20f });

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
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 12, 12, 5, 0, 0, DateTimeKind.Unspecified), "tJeIsWBK", 92.8927f });

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
                columns: new[] { "CreatedDate", "Description", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 25, 16, 29, 0, 0, DateTimeKind.Unspecified), "BruAJJAS", 49, 50.708652f });

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
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 10, 9, 23, 5, 0, 0, DateTimeKind.Unspecified), "oDzJDwSI", 5.748323f });

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
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 7, 2, 4, 19, 0, 0, DateTimeKind.Unspecified), "kJBoDMSS", 84.10059f });

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
                columns: new[] { "CreatedDate", "Description", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 7, 19, 28, 0, 0, DateTimeKind.Unspecified), "SgLpWiJA", 17.73407f });

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
    }
}
