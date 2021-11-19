using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CreatedDate", "Name", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brasno", 1, 20f, 18f },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ulje", 4, 3f, 1f },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secer", 1, 1.5f, 1f },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jaja", 1, 10f, 30f },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maslac", 1, 25f, 2f }
                });

            migrationBuilder.InsertData(
                table: "MyUsers",
                columns: new[] { "Id", "CreatedDate", "FirstName", "LastName", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), "Adin", "Smajkic", 2 },
                    { 2, new DateTime(2018, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), "user", "user", 1 }
                });

            migrationBuilder.InsertData(
                table: "RecipeCategories",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), "Pizza kategorijaa", "Pizza" },
                    { 2, new DateTime(2009, 6, 12, 8, 30, 52, 0, DateTimeKind.Unspecified), "Pizza kategorija", "Palacinke" },
                    { 3, new DateTime(2018, 12, 21, 8, 30, 52, 0, DateTimeKind.Unspecified), "Kolac kategorija", "Kolac" },
                    { 4, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Hamburger kategorija", "Hamburger" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedDate", "Description", "MyUserId", "Name", "RecipeCategoryId", "TotalCost" },
                values: new object[] { 3, new DateTime(2018, 12, 21, 8, 30, 52, 0, DateTimeKind.Unspecified), "Vrhunski specijalitet", 1, "Palacinke sa nutelom", 2, 0f });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedDate", "Description", "MyUserId", "Name", "RecipeCategoryId", "TotalCost" },
                values: new object[] { 1, new DateTime(2018, 12, 21, 8, 30, 52, 0, DateTimeKind.Unspecified), "Ukusni kolac", 1, "Rafaelo", 3, 0f });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedDate", "Description", "MyUserId", "Name", "RecipeCategoryId", "TotalCost" },
                values: new object[] { 2, new DateTime(2016, 12, 21, 8, 30, 52, 0, DateTimeKind.Unspecified), "Predobar kolac", 2, "Snickers", 3, 0f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MyUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MyUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
