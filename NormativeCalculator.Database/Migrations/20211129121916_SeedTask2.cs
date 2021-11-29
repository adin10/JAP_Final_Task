using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class SeedTask2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 8, 16, 13, 47, 0, 0, DateTimeKind.Unspecified), "Ulje1", 2, 37.72f, 46f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 9, 3, 5, 31, 0, 0, DateTimeKind.Unspecified), "Secer2", 3, 4.46f, 32f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 1, 25, 7, 27, 0, 0, DateTimeKind.Unspecified), "Jaja3", 3, 26.53f, 28f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Name", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 5, 6, 7, 17, 0, 0, DateTimeKind.Unspecified), "Maslac4", 2, 28.29f, 6f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(2021, 4, 17, 14, 40, 0, 0, DateTimeKind.Unspecified), "Cokolada5", 22.28f, 40f });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CreatedDate", "Name", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[,]
                {
                    { 6, new DateTime(2021, 2, 22, 17, 55, 0, 0, DateTimeKind.Unspecified), "Brasno6", 4, 24.36f, 5f },
                    { 76, new DateTime(2021, 4, 16, 4, 9, 0, 0, DateTimeKind.Unspecified), "Maslac76", 4, 41.52f, 29f },
                    { 75, new DateTime(2021, 2, 4, 18, 34, 0, 0, DateTimeKind.Unspecified), "Jaja75", 5, 24.7f, 29f },
                    { 74, new DateTime(2021, 5, 6, 12, 47, 0, 0, DateTimeKind.Unspecified), "Secer74", 4, 9.82f, 36f },
                    { 73, new DateTime(2021, 7, 15, 7, 9, 0, 0, DateTimeKind.Unspecified), "Ulje73", 4, 25.56f, 47f },
                    { 72, new DateTime(2021, 11, 14, 17, 24, 0, 0, DateTimeKind.Unspecified), "Brasno72", 5, 43.72f, 31f },
                    { 71, new DateTime(2021, 1, 29, 4, 49, 0, 0, DateTimeKind.Unspecified), "Cokolada71", 2, 9.24f, 23f },
                    { 70, new DateTime(2021, 2, 24, 9, 46, 0, 0, DateTimeKind.Unspecified), "Maslac70", 5, 36.35f, 25f },
                    { 69, new DateTime(2021, 1, 17, 6, 53, 0, 0, DateTimeKind.Unspecified), "Jaja69", 2, 43.02f, 43f },
                    { 68, new DateTime(2021, 4, 6, 0, 27, 0, 0, DateTimeKind.Unspecified), "Secer68", 1, 12.57f, 32f },
                    { 66, new DateTime(2021, 11, 15, 7, 17, 0, 0, DateTimeKind.Unspecified), "Brasno66", 4, 15.65f, 4f },
                    { 77, new DateTime(2021, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Cokolada77", 1, 13.08f, 22f },
                    { 65, new DateTime(2021, 8, 20, 1, 38, 0, 0, DateTimeKind.Unspecified), "Cokolada65", 2, 15.11f, 8f },
                    { 64, new DateTime(2021, 7, 31, 15, 17, 0, 0, DateTimeKind.Unspecified), "Maslac64", 4, 20.17f, 14f },
                    { 63, new DateTime(2021, 9, 27, 21, 27, 0, 0, DateTimeKind.Unspecified), "Jaja63", 1, 18.91f, 22f },
                    { 62, new DateTime(2021, 10, 11, 10, 21, 0, 0, DateTimeKind.Unspecified), "Secer62", 3, 8.59f, 1f },
                    { 61, new DateTime(2021, 8, 25, 12, 15, 0, 0, DateTimeKind.Unspecified), "Ulje61", 3, 15.56f, 16f },
                    { 60, new DateTime(2021, 7, 23, 10, 39, 0, 0, DateTimeKind.Unspecified), "Brasno60", 2, 41.32f, 44f },
                    { 59, new DateTime(2021, 1, 26, 8, 58, 0, 0, DateTimeKind.Unspecified), "Cokolada59", 1, 33.79f, 10f },
                    { 58, new DateTime(2021, 11, 1, 13, 29, 0, 0, DateTimeKind.Unspecified), "Maslac58", 2, 4.31f, 2f },
                    { 67, new DateTime(2021, 3, 18, 15, 40, 0, 0, DateTimeKind.Unspecified), "Ulje67", 5, 15.62f, 38f },
                    { 78, new DateTime(2021, 5, 18, 17, 7, 0, 0, DateTimeKind.Unspecified), "Brasno78", 3, 16.18f, 45f },
                    { 81, new DateTime(2021, 3, 8, 6, 20, 0, 0, DateTimeKind.Unspecified), "Jaja81", 4, 1.27f, 48f },
                    { 80, new DateTime(2021, 8, 4, 15, 50, 0, 0, DateTimeKind.Unspecified), "Secer80", 5, 10.91f, 37f },
                    { 100, new DateTime(2021, 3, 27, 9, 10, 0, 0, DateTimeKind.Unspecified), "Maslac100", 4, 8.09f, 38f },
                    { 99, new DateTime(2021, 2, 18, 19, 54, 0, 0, DateTimeKind.Unspecified), "Jaja99", 3, 25.59f, 45f },
                    { 98, new DateTime(2021, 3, 6, 10, 36, 0, 0, DateTimeKind.Unspecified), "Secer98", 4, 23.12f, 5f },
                    { 97, new DateTime(2021, 6, 21, 15, 45, 0, 0, DateTimeKind.Unspecified), "Ulje97", 4, 38.03f, 4f },
                    { 96, new DateTime(2021, 8, 17, 7, 5, 0, 0, DateTimeKind.Unspecified), "Brasno96", 4, 42.67f, 7f },
                    { 95, new DateTime(2021, 8, 8, 18, 45, 0, 0, DateTimeKind.Unspecified), "Cokolada95", 4, 5.64f, 1f },
                    { 94, new DateTime(2021, 11, 22, 7, 44, 0, 0, DateTimeKind.Unspecified), "Maslac94", 4, 1.95f, 15f },
                    { 93, new DateTime(2021, 10, 3, 22, 52, 0, 0, DateTimeKind.Unspecified), "Jaja93", 5, 48.25f, 20f },
                    { 92, new DateTime(2021, 10, 21, 20, 45, 0, 0, DateTimeKind.Unspecified), "Secer92", 4, 28.88f, 9f },
                    { 91, new DateTime(2021, 11, 8, 13, 35, 0, 0, DateTimeKind.Unspecified), "Ulje91", 2, 44.39f, 5f },
                    { 90, new DateTime(2021, 11, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), "Brasno90", 1, 27.91f, 9f },
                    { 89, new DateTime(2021, 2, 5, 1, 55, 0, 0, DateTimeKind.Unspecified), "Cokolada89", 5, 48f, 26f },
                    { 88, new DateTime(2021, 6, 19, 17, 40, 0, 0, DateTimeKind.Unspecified), "Maslac88", 5, 46.68f, 23f }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CreatedDate", "Name", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[,]
                {
                    { 87, new DateTime(2021, 8, 16, 2, 19, 0, 0, DateTimeKind.Unspecified), "Jaja87", 5, 33.01f, 5f },
                    { 86, new DateTime(2021, 9, 26, 8, 29, 0, 0, DateTimeKind.Unspecified), "Secer86", 1, 14.24f, 10f },
                    { 85, new DateTime(2021, 4, 19, 20, 7, 0, 0, DateTimeKind.Unspecified), "Ulje85", 4, 33.66f, 45f },
                    { 84, new DateTime(2021, 11, 23, 8, 21, 0, 0, DateTimeKind.Unspecified), "Brasno84", 4, 39.98f, 33f },
                    { 83, new DateTime(2021, 3, 28, 16, 41, 0, 0, DateTimeKind.Unspecified), "Cokolada83", 2, 14.21f, 31f },
                    { 82, new DateTime(2021, 5, 29, 5, 58, 0, 0, DateTimeKind.Unspecified), "Maslac82", 2, 31.94f, 10f },
                    { 79, new DateTime(2021, 11, 9, 1, 29, 0, 0, DateTimeKind.Unspecified), "Ulje79", 2, 30.65f, 45f },
                    { 56, new DateTime(2021, 10, 11, 3, 53, 0, 0, DateTimeKind.Unspecified), "Secer56", 4, 33.04f, 11f },
                    { 57, new DateTime(2021, 6, 9, 14, 51, 0, 0, DateTimeKind.Unspecified), "Jaja57", 3, 5.17f, 3f },
                    { 54, new DateTime(2021, 10, 22, 3, 49, 0, 0, DateTimeKind.Unspecified), "Brasno54", 5, 14.42f, 41f },
                    { 27, new DateTime(2021, 5, 29, 5, 40, 0, 0, DateTimeKind.Unspecified), "Jaja27", 4, 15.83f, 6f },
                    { 26, new DateTime(2021, 8, 24, 4, 0, 0, 0, DateTimeKind.Unspecified), "Secer26", 2, 22.67f, 3f },
                    { 25, new DateTime(2021, 4, 10, 22, 18, 0, 0, DateTimeKind.Unspecified), "Ulje25", 5, 11.47f, 7f },
                    { 24, new DateTime(2021, 2, 21, 17, 57, 0, 0, DateTimeKind.Unspecified), "Brasno24", 5, 26.87f, 22f },
                    { 23, new DateTime(2021, 3, 27, 14, 39, 0, 0, DateTimeKind.Unspecified), "Cokolada23", 2, 19.93f, 42f },
                    { 22, new DateTime(2021, 10, 4, 9, 54, 0, 0, DateTimeKind.Unspecified), "Maslac22", 1, 13.45f, 36f },
                    { 21, new DateTime(2021, 8, 3, 17, 22, 0, 0, DateTimeKind.Unspecified), "Jaja21", 2, 6.35f, 28f },
                    { 20, new DateTime(2021, 8, 3, 12, 2, 0, 0, DateTimeKind.Unspecified), "Secer20", 1, 37.74f, 11f },
                    { 19, new DateTime(2021, 9, 7, 19, 48, 0, 0, DateTimeKind.Unspecified), "Ulje19", 5, 37.27f, 23f },
                    { 18, new DateTime(2021, 3, 2, 1, 33, 0, 0, DateTimeKind.Unspecified), "Brasno18", 1, 48.65f, 37f },
                    { 17, new DateTime(2021, 10, 15, 1, 16, 0, 0, DateTimeKind.Unspecified), "Cokolada17", 4, 11.83f, 33f },
                    { 16, new DateTime(2021, 10, 22, 15, 4, 0, 0, DateTimeKind.Unspecified), "Maslac16", 2, 5.36f, 41f },
                    { 15, new DateTime(2021, 7, 13, 14, 13, 0, 0, DateTimeKind.Unspecified), "Jaja15", 4, 31.32f, 32f },
                    { 14, new DateTime(2021, 10, 8, 2, 47, 0, 0, DateTimeKind.Unspecified), "Secer14", 1, 1.91f, 28f },
                    { 13, new DateTime(2021, 10, 6, 18, 7, 0, 0, DateTimeKind.Unspecified), "Ulje13", 3, 35.05f, 6f },
                    { 12, new DateTime(2021, 7, 28, 13, 10, 0, 0, DateTimeKind.Unspecified), "Brasno12", 2, 19.09f, 15f },
                    { 11, new DateTime(2021, 2, 13, 18, 48, 0, 0, DateTimeKind.Unspecified), "Cokolada11", 1, 39.05f, 30f },
                    { 10, new DateTime(2021, 1, 19, 14, 19, 0, 0, DateTimeKind.Unspecified), "Maslac10", 5, 18.15f, 27f },
                    { 9, new DateTime(2021, 11, 12, 13, 41, 0, 0, DateTimeKind.Unspecified), "Jaja9", 5, 12.93f, 16f },
                    { 8, new DateTime(2021, 10, 24, 7, 23, 0, 0, DateTimeKind.Unspecified), "Secer8", 4, 6.38f, 15f },
                    { 7, new DateTime(2021, 1, 1, 18, 25, 0, 0, DateTimeKind.Unspecified), "Ulje7", 1, 20.42f, 19f },
                    { 28, new DateTime(2021, 2, 19, 8, 4, 0, 0, DateTimeKind.Unspecified), "Maslac28", 3, 23.13f, 32f },
                    { 55, new DateTime(2021, 5, 29, 15, 43, 0, 0, DateTimeKind.Unspecified), "Ulje55", 2, 34.77f, 3f },
                    { 29, new DateTime(2021, 1, 27, 9, 55, 0, 0, DateTimeKind.Unspecified), "Cokolada29", 4, 5.32f, 27f },
                    { 31, new DateTime(2021, 4, 30, 12, 41, 0, 0, DateTimeKind.Unspecified), "Ulje31", 2, 6.33f, 13f },
                    { 53, new DateTime(2021, 6, 12, 9, 11, 0, 0, DateTimeKind.Unspecified), "Cokolada53", 5, 46.34f, 32f },
                    { 52, new DateTime(2021, 7, 3, 4, 12, 0, 0, DateTimeKind.Unspecified), "Maslac52", 2, 12.35f, 23f },
                    { 51, new DateTime(2021, 11, 24, 2, 17, 0, 0, DateTimeKind.Unspecified), "Jaja51", 1, 33.52f, 38f },
                    { 50, new DateTime(2021, 2, 2, 1, 34, 0, 0, DateTimeKind.Unspecified), "Secer50", 3, 5.44f, 17f },
                    { 49, new DateTime(2021, 10, 22, 15, 22, 0, 0, DateTimeKind.Unspecified), "Ulje49", 2, 12.18f, 19f },
                    { 48, new DateTime(2021, 11, 28, 23, 41, 0, 0, DateTimeKind.Unspecified), "Brasno48", 1, 11.78f, 1f },
                    { 47, new DateTime(2021, 6, 18, 21, 40, 0, 0, DateTimeKind.Unspecified), "Cokolada47", 1, 19.76f, 35f }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CreatedDate", "Name", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[,]
                {
                    { 46, new DateTime(2021, 8, 5, 6, 27, 0, 0, DateTimeKind.Unspecified), "Maslac46", 2, 38.58f, 27f },
                    { 45, new DateTime(2021, 3, 13, 16, 28, 0, 0, DateTimeKind.Unspecified), "Jaja45", 3, 24f, 37f },
                    { 30, new DateTime(2021, 4, 14, 22, 24, 0, 0, DateTimeKind.Unspecified), "Brasno30", 4, 39.76f, 44f },
                    { 43, new DateTime(2021, 10, 4, 1, 54, 0, 0, DateTimeKind.Unspecified), "Ulje43", 1, 22.1f, 23f },
                    { 44, new DateTime(2021, 10, 7, 21, 32, 0, 0, DateTimeKind.Unspecified), "Secer44", 2, 49.45f, 21f },
                    { 41, new DateTime(2021, 6, 29, 17, 27, 0, 0, DateTimeKind.Unspecified), "Cokolada41", 5, 3.23f, 45f },
                    { 40, new DateTime(2021, 5, 5, 7, 1, 0, 0, DateTimeKind.Unspecified), "Maslac40", 5, 21.01f, 14f },
                    { 39, new DateTime(2021, 7, 16, 18, 24, 0, 0, DateTimeKind.Unspecified), "Jaja39", 2, 29.36f, 23f },
                    { 38, new DateTime(2021, 10, 29, 7, 51, 0, 0, DateTimeKind.Unspecified), "Secer38", 5, 17.69f, 32f },
                    { 37, new DateTime(2021, 9, 24, 10, 15, 0, 0, DateTimeKind.Unspecified), "Ulje37", 2, 15.95f, 47f },
                    { 36, new DateTime(2021, 5, 20, 4, 27, 0, 0, DateTimeKind.Unspecified), "Brasno36", 1, 17.99f, 43f },
                    { 35, new DateTime(2021, 9, 21, 19, 53, 0, 0, DateTimeKind.Unspecified), "Cokolada35", 5, 15.5f, 38f },
                    { 34, new DateTime(2021, 7, 3, 17, 39, 0, 0, DateTimeKind.Unspecified), "Maslac34", 5, 30.66f, 44f },
                    { 33, new DateTime(2021, 5, 12, 21, 30, 0, 0, DateTimeKind.Unspecified), "Jaja33", 1, 41.02f, 11f },
                    { 32, new DateTime(2021, 2, 27, 11, 31, 0, 0, DateTimeKind.Unspecified), "Secer32", 3, 40.71f, 38f },
                    { 42, new DateTime(2021, 4, 20, 13, 13, 0, 0, DateTimeKind.Unspecified), "Brasno42", 5, 45.36f, 15f }
                });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2021, 6, 12, 5, 36, 0, 0, DateTimeKind.Unspecified), "lJuefKhA", "Palacinke1" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2021, 3, 11, 7, 40, 0, 0, DateTimeKind.Unspecified), "zDDASwLm", "Kolac2" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2021, 2, 2, 22, 42, 0, 0, DateTimeKind.Unspecified), "JDKIsmJW", "Hamburger3" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2021, 2, 4, 13, 28, 0, 0, DateTimeKind.Unspecified), "fmAsfpAS", "Sendvic4" });

            migrationBuilder.InsertData(
                table: "RecipeCategories",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 6, new DateTime(2021, 3, 13, 15, 10, 0, 0, DateTimeKind.Unspecified), "JwvAduSK", "Waffle6" },
                    { 76, new DateTime(2021, 1, 31, 18, 26, 0, 0, DateTimeKind.Unspecified), "ADLwaBDW", "Sendvic76" },
                    { 75, new DateTime(2021, 2, 24, 1, 58, 0, 0, DateTimeKind.Unspecified), "ScHfaIjW", "Hamburger75" },
                    { 74, new DateTime(2021, 1, 22, 2, 34, 0, 0, DateTimeKind.Unspecified), "SdHfMKsJ", "Kolac74" },
                    { 73, new DateTime(2021, 7, 25, 13, 40, 0, 0, DateTimeKind.Unspecified), "SAsBsnvD", "Palacinke73" },
                    { 72, new DateTime(2021, 4, 7, 8, 9, 0, 0, DateTimeKind.Unspecified), "lJskISAW", "Pizza72" },
                    { 71, new DateTime(2021, 1, 19, 19, 48, 0, 0, DateTimeKind.Unspecified), "sWsJKDHc", "Salata71" },
                    { 70, new DateTime(2021, 7, 12, 17, 56, 0, 0, DateTimeKind.Unspecified), "JvWALDeB", "Waffle70" },
                    { 69, new DateTime(2021, 6, 17, 5, 14, 0, 0, DateTimeKind.Unspecified), "ttcdtsKt", "Pitta69" },
                    { 68, new DateTime(2021, 2, 22, 2, 32, 0, 0, DateTimeKind.Unspecified), "vSDfMsAS", "Sendvic68" },
                    { 77, new DateTime(2021, 5, 18, 16, 31, 0, 0, DateTimeKind.Unspecified), "AtKsdBii", "Pitta77" },
                    { 67, new DateTime(2021, 7, 24, 1, 30, 0, 0, DateTimeKind.Unspecified), "SvsoDAnk", "Hamburger67" },
                    { 65, new DateTime(2021, 3, 4, 23, 55, 0, 0, DateTimeKind.Unspecified), "AAfKbtKJ", "Palacinke65" },
                    { 64, new DateTime(2021, 4, 5, 20, 45, 0, 0, DateTimeKind.Unspecified), "AIWookAj", "Pizza64" },
                    { 63, new DateTime(2021, 2, 1, 10, 37, 0, 0, DateTimeKind.Unspecified), "KtbAsosa", "Salata63" },
                    { 62, new DateTime(2021, 2, 19, 16, 25, 0, 0, DateTimeKind.Unspecified), "imDWDAgI", "Waffle62" },
                    { 61, new DateTime(2021, 9, 11, 8, 46, 0, 0, DateTimeKind.Unspecified), "DKLDMAHa", "Pitta61" },
                    { 60, new DateTime(2021, 9, 4, 0, 12, 0, 0, DateTimeKind.Unspecified), "odklHBIS", "Sendvic60" },
                    { 59, new DateTime(2021, 4, 18, 12, 28, 0, 0, DateTimeKind.Unspecified), "fWSJdAtA", "Hamburger59" },
                    { 58, new DateTime(2021, 6, 11, 20, 52, 0, 0, DateTimeKind.Unspecified), "JShJBJMW", "Kolac58" },
                    { 56, new DateTime(2021, 7, 1, 11, 20, 0, 0, DateTimeKind.Unspecified), "WWdgBaAz", "Pizza56" },
                    { 66, new DateTime(2021, 10, 16, 13, 58, 0, 0, DateTimeKind.Unspecified), "SSsSAurI", "Kolac66" }
                });

            migrationBuilder.InsertData(
                table: "RecipeCategories",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 55, new DateTime(2021, 2, 19, 8, 46, 0, 0, DateTimeKind.Unspecified), "DJWpASfW", "Salata55" },
                    { 78, new DateTime(2021, 11, 5, 13, 21, 0, 0, DateTimeKind.Unspecified), "tKmWMKhH", "Waffle78" },
                    { 80, new DateTime(2021, 6, 9, 9, 41, 0, 0, DateTimeKind.Unspecified), "pHLszADe", "Pizza80" },
                    { 100, new DateTime(2021, 2, 1, 9, 6, 0, 0, DateTimeKind.Unspecified), "DsJuWIDK", "Sendvic100" },
                    { 99, new DateTime(2021, 6, 26, 15, 51, 0, 0, DateTimeKind.Unspecified), "ArIWsSvp", "Hamburger99" },
                    { 98, new DateTime(2021, 3, 22, 5, 0, 0, 0, DateTimeKind.Unspecified), "WApaBJaA", "Kolac98" },
                    { 97, new DateTime(2021, 9, 1, 5, 45, 0, 0, DateTimeKind.Unspecified), "SWWlKWhW", "Palacinke97" },
                    { 96, new DateTime(2021, 10, 10, 3, 33, 0, 0, DateTimeKind.Unspecified), "SMmSggrH", "Pizza96" },
                    { 95, new DateTime(2021, 11, 23, 16, 38, 0, 0, DateTimeKind.Unspecified), "cnjJIwWn", "Salata95" },
                    { 94, new DateTime(2021, 6, 6, 5, 36, 0, 0, DateTimeKind.Unspecified), "WnSDgmSj", "Waffle94" },
                    { 93, new DateTime(2021, 10, 8, 2, 29, 0, 0, DateTimeKind.Unspecified), "IKJKokDg", "Pitta93" },
                    { 92, new DateTime(2021, 4, 26, 15, 47, 0, 0, DateTimeKind.Unspecified), "gDDLJHDk", "Sendvic92" },
                    { 79, new DateTime(2021, 8, 4, 2, 45, 0, 0, DateTimeKind.Unspecified), "BswJWWDh", "Salata79" },
                    { 91, new DateTime(2021, 4, 3, 19, 37, 0, 0, DateTimeKind.Unspecified), "akJaowsh", "Hamburger91" },
                    { 89, new DateTime(2021, 10, 26, 11, 52, 0, 0, DateTimeKind.Unspecified), "JoctoHDl", "Palacinke89" },
                    { 88, new DateTime(2021, 9, 17, 15, 35, 0, 0, DateTimeKind.Unspecified), "AoSjWvAd", "Pizza88" },
                    { 87, new DateTime(2021, 3, 15, 20, 36, 0, 0, DateTimeKind.Unspecified), "WWDmDbbS", "Salata87" },
                    { 86, new DateTime(2021, 6, 30, 11, 52, 0, 0, DateTimeKind.Unspecified), "SoLwArWS", "Waffle86" },
                    { 85, new DateTime(2021, 6, 27, 0, 57, 0, 0, DateTimeKind.Unspecified), "jhkkhJAB", "Pitta85" },
                    { 84, new DateTime(2021, 10, 31, 9, 4, 0, 0, DateTimeKind.Unspecified), "WWbuAIJz", "Sendvic84" },
                    { 83, new DateTime(2021, 4, 5, 15, 8, 0, 0, DateTimeKind.Unspecified), "LiSBdLDf", "Hamburger83" },
                    { 82, new DateTime(2021, 10, 18, 17, 42, 0, 0, DateTimeKind.Unspecified), "JAJlBAJh", "Kolac82" },
                    { 81, new DateTime(2021, 2, 22, 9, 59, 0, 0, DateTimeKind.Unspecified), "wAuDIaSj", "Palacinke81" },
                    { 90, new DateTime(2021, 4, 26, 11, 17, 0, 0, DateTimeKind.Unspecified), "puMKDDlz", "Kolac90" },
                    { 54, new DateTime(2021, 2, 7, 15, 40, 0, 0, DateTimeKind.Unspecified), "SzksLSub", "Waffle54" },
                    { 57, new DateTime(2021, 7, 5, 2, 32, 0, 0, DateTimeKind.Unspecified), "DpSJtDsB", "Palacinke57" },
                    { 52, new DateTime(2021, 7, 26, 8, 6, 0, 0, DateTimeKind.Unspecified), "pAJimAId", "Sendvic52" },
                    { 27, new DateTime(2021, 5, 31, 6, 24, 0, 0, DateTimeKind.Unspecified), "Asbzkvij", "Hamburger27" },
                    { 53, new DateTime(2021, 11, 14, 9, 57, 0, 0, DateTimeKind.Unspecified), "SuJMASWr", "Pitta53" },
                    { 25, new DateTime(2021, 9, 17, 0, 59, 0, 0, DateTimeKind.Unspecified), "AkJSJWWK", "Palacinke25" },
                    { 24, new DateTime(2021, 7, 23, 1, 50, 0, 0, DateTimeKind.Unspecified), "spiiDJrJ", "Pizza24" },
                    { 23, new DateTime(2021, 8, 5, 5, 8, 0, 0, DateTimeKind.Unspecified), "WtWJJStw", "Salata23" },
                    { 22, new DateTime(2021, 11, 9, 18, 16, 0, 0, DateTimeKind.Unspecified), "SuMvLnSJ", "Waffle22" },
                    { 21, new DateTime(2021, 11, 2, 10, 49, 0, 0, DateTimeKind.Unspecified), "AvMcsSop", "Pitta21" },
                    { 20, new DateTime(2021, 2, 23, 21, 57, 0, 0, DateTimeKind.Unspecified), "sDDSSSpI", "Sendvic20" },
                    { 19, new DateTime(2021, 9, 27, 3, 59, 0, 0, DateTimeKind.Unspecified), "jcvSeLJS", "Hamburger19" },
                    { 18, new DateTime(2021, 10, 3, 19, 29, 0, 0, DateTimeKind.Unspecified), "KabWdBHS", "Kolac18" },
                    { 17, new DateTime(2021, 6, 1, 23, 7, 0, 0, DateTimeKind.Unspecified), "rDhDWKzh", "Palacinke17" },
                    { 16, new DateTime(2021, 10, 24, 8, 28, 0, 0, DateTimeKind.Unspecified), "hzrWScKs", "Pizza16" },
                    { 15, new DateTime(2021, 5, 19, 16, 6, 0, 0, DateTimeKind.Unspecified), "JnBszASA", "Salata15" },
                    { 14, new DateTime(2021, 5, 13, 3, 52, 0, 0, DateTimeKind.Unspecified), "AwJmbAhW", "Waffle14" },
                    { 13, new DateTime(2021, 3, 9, 23, 11, 0, 0, DateTimeKind.Unspecified), "AokhnhWm", "Pitta13" }
                });

            migrationBuilder.InsertData(
                table: "RecipeCategories",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 12, new DateTime(2021, 6, 19, 8, 46, 0, 0, DateTimeKind.Unspecified), "ssboeSoc", "Sendvic12" },
                    { 11, new DateTime(2021, 1, 16, 20, 32, 0, 0, DateTimeKind.Unspecified), "pimJiSWW", "Hamburger11" },
                    { 10, new DateTime(2021, 4, 28, 19, 53, 0, 0, DateTimeKind.Unspecified), "eJcASJAA", "Kolac10" },
                    { 9, new DateTime(2021, 3, 30, 23, 47, 0, 0, DateTimeKind.Unspecified), "SAgIhWsH", "Palacinke9" },
                    { 8, new DateTime(2021, 5, 9, 6, 10, 0, 0, DateTimeKind.Unspecified), "AWDLJWKf", "Pizza8" },
                    { 7, new DateTime(2021, 5, 11, 8, 47, 0, 0, DateTimeKind.Unspecified), "kkgDAetD", "Salata7" },
                    { 28, new DateTime(2021, 3, 22, 16, 22, 0, 0, DateTimeKind.Unspecified), "czWbwgJk", "Sendvic28" },
                    { 29, new DateTime(2021, 4, 7, 19, 32, 0, 0, DateTimeKind.Unspecified), "dhSSDaaj", "Pitta29" },
                    { 26, new DateTime(2021, 1, 18, 18, 3, 0, 0, DateTimeKind.Unspecified), "JeDASjDe", "Kolac26" },
                    { 31, new DateTime(2021, 2, 24, 19, 58, 0, 0, DateTimeKind.Unspecified), "reokWJDo", "Salata31" },
                    { 51, new DateTime(2021, 5, 30, 2, 5, 0, 0, DateTimeKind.Unspecified), "nzdWcKlJ", "Hamburger51" },
                    { 50, new DateTime(2021, 5, 6, 10, 28, 0, 0, DateTimeKind.Unspecified), "orttofvt", "Kolac50" },
                    { 49, new DateTime(2021, 11, 15, 1, 13, 0, 0, DateTimeKind.Unspecified), "zAztSiii", "Palacinke49" },
                    { 48, new DateTime(2021, 7, 11, 12, 42, 0, 0, DateTimeKind.Unspecified), "hSadJKDi", "Pizza48" },
                    { 47, new DateTime(2021, 10, 25, 8, 4, 0, 0, DateTimeKind.Unspecified), "DSWAWkaW", "Salata47" },
                    { 30, new DateTime(2021, 11, 23, 3, 2, 0, 0, DateTimeKind.Unspecified), "WcgBJHBi", "Waffle30" },
                    { 45, new DateTime(2021, 11, 16, 23, 5, 0, 0, DateTimeKind.Unspecified), "WpjWgmAK", "Pitta45" },
                    { 44, new DateTime(2021, 8, 28, 15, 46, 0, 0, DateTimeKind.Unspecified), "JtKDJHmA", "Sendvic44" },
                    { 43, new DateTime(2021, 6, 25, 1, 45, 0, 0, DateTimeKind.Unspecified), "vlJlDApm", "Hamburger43" },
                    { 42, new DateTime(2021, 10, 2, 16, 23, 0, 0, DateTimeKind.Unspecified), "SAAvWLSp", "Kolac42" },
                    { 46, new DateTime(2021, 4, 10, 15, 18, 0, 0, DateTimeKind.Unspecified), "LhDjSsfr", "Waffle46" },
                    { 40, new DateTime(2021, 9, 6, 1, 25, 0, 0, DateTimeKind.Unspecified), "isgbSDsB", "Pizza40" },
                    { 41, new DateTime(2021, 11, 28, 19, 58, 0, 0, DateTimeKind.Unspecified), "KskJsDsg", "Palacinke41" },
                    { 33, new DateTime(2021, 10, 25, 7, 16, 0, 0, DateTimeKind.Unspecified), "rWJWwrKA", "Palacinke33" },
                    { 34, new DateTime(2021, 1, 16, 20, 39, 0, 0, DateTimeKind.Unspecified), "sSHinSsu", "Kolac34" },
                    { 35, new DateTime(2021, 10, 24, 22, 37, 0, 0, DateTimeKind.Unspecified), "JDWtLBWi", "Hamburger35" },
                    { 32, new DateTime(2021, 3, 1, 6, 33, 0, 0, DateTimeKind.Unspecified), "bBDjMDeJ", "Pizza32" },
                    { 37, new DateTime(2021, 10, 5, 12, 40, 0, 0, DateTimeKind.Unspecified), "WDjSbKAD", "Pitta37" },
                    { 38, new DateTime(2021, 2, 25, 14, 58, 0, 0, DateTimeKind.Unspecified), "DvLKlrat", "Waffle38" },
                    { 39, new DateTime(2021, 3, 12, 5, 49, 0, 0, DateTimeKind.Unspecified), "djouJAWI", "Salata39" },
                    { 36, new DateTime(2021, 10, 5, 22, 10, 0, 0, DateTimeKind.Unspecified), "SzWWvSnj", "Sendvic36" },
                    { 5, new DateTime(2021, 9, 21, 18, 16, 0, 0, DateTimeKind.Unspecified), "WLrJMewA", "Pitta5" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedDate", "Description", "MyUserId", "Name", "RecipeCategoryId", "TotalCost" },
                values: new object[,]
                {
                    { 73, new DateTime(2021, 10, 13, 1, 29, 0, 0, DateTimeKind.Unspecified), "dIJWAkAs", 1, "Rafaelo73", 4, 26.73879f },
                    { 53, new DateTime(2021, 10, 21, 15, 27, 0, 0, DateTimeKind.Unspecified), "SrWwoAWh", 1, "Saher torta53", 3, 11.461549f },
                    { 51, new DateTime(2021, 2, 1, 13, 26, 0, 0, DateTimeKind.Unspecified), "fJtWtAwJ", 1, "Baklava51", 4, 92.67166f },
                    { 42, new DateTime(2021, 7, 10, 5, 55, 0, 0, DateTimeKind.Unspecified), "KKJjItdb", 1, "Snickers42", 3, 44.597187f },
                    { 40, new DateTime(2021, 4, 10, 11, 15, 0, 0, DateTimeKind.Unspecified), "oSDiWWJJ", 1, "Pizza sa sirom 40", 4, 52.6544f },
                    { 25, new DateTime(2021, 3, 16, 20, 10, 0, 0, DateTimeKind.Unspecified), "vKWzjSLd", 1, "Rafaelo25", 2, 92.73125f },
                    { 24, new DateTime(2021, 2, 5, 14, 53, 0, 0, DateTimeKind.Unspecified), "KleSDaIJ", 1, "Pizza sa sirom 24", 4, 57.3957f },
                    { 15, new DateTime(2021, 5, 18, 4, 19, 0, 0, DateTimeKind.Unspecified), "scgiDoes", 1, "Ferrero15", 3, 3.862806f }
                });

            migrationBuilder.InsertData(
                table: "IngredientRecipes",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 8, new DateTime(2021, 10, 18, 7, 33, 0, 0, DateTimeKind.Unspecified), 17, 0f, 13.01f, 1, 1 },
                    { 90, new DateTime(2021, 11, 27, 3, 48, 0, 0, DateTimeKind.Unspecified), 8, 0f, 43.7f, 73, 5 },
                    { 12, new DateTime(2021, 10, 5, 14, 29, 0, 0, DateTimeKind.Unspecified), 66, 0f, 42.57f, 73, 4 },
                    { 56, new DateTime(2021, 4, 5, 9, 13, 0, 0, DateTimeKind.Unspecified), 17, 0f, 25.57f, 42, 2 },
                    { 45, new DateTime(2021, 9, 29, 5, 1, 0, 0, DateTimeKind.Unspecified), 85, 0f, 40.15f, 40, 2 },
                    { 49, new DateTime(2021, 8, 1, 9, 33, 0, 0, DateTimeKind.Unspecified), 98, 0f, 34.3f, 25, 5 },
                    { 30, new DateTime(2021, 7, 3, 15, 54, 0, 0, DateTimeKind.Unspecified), 42, 0f, 23.95f, 73, 5 },
                    { 87, new DateTime(2021, 4, 10, 15, 52, 0, 0, DateTimeKind.Unspecified), 44, 0f, 4f, 15, 2 },
                    { 65, new DateTime(2021, 9, 9, 9, 38, 0, 0, DateTimeKind.Unspecified), 26, 0f, 34.01f, 15, 1 },
                    { 60, new DateTime(2021, 6, 18, 13, 31, 0, 0, DateTimeKind.Unspecified), 6, 0f, 34.74f, 15, 2 },
                    { 26, new DateTime(2021, 2, 9, 5, 50, 0, 0, DateTimeKind.Unspecified), 52, 0f, 21.7f, 2, 2 },
                    { 85, new DateTime(2021, 5, 6, 3, 44, 0, 0, DateTimeKind.Unspecified), 24, 0f, 15.48f, 1, 5 },
                    { 81, new DateTime(2021, 4, 8, 1, 44, 0, 0, DateTimeKind.Unspecified), 40, 0f, 14.81f, 24, 5 }
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Name", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 5, 20, 14, 47, 0, 0, DateTimeKind.Unspecified), "SoJsnvvt", "Rafaelo1", 12, 19.814907f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "MyUserId", "Name", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 3, 15, 21, 12, 0, 0, DateTimeKind.Unspecified), "gvdohKJS", 1, "Snickers2", 35, 20.88259f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Name", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2021, 11, 12, 16, 47, 0, 0, DateTimeKind.Unspecified), "JtWIrSka", "Baklava3", 38, 50.303394f });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedDate", "Description", "MyUserId", "Name", "RecipeCategoryId", "TotalCost" },
                values: new object[,]
                {
                    { 67, new DateTime(2021, 9, 23, 0, 32, 0, 0, DateTimeKind.Unspecified), "MlnWdcmA", 1, "Baklava67", 33, 33.37194f },
                    { 79, new DateTime(2021, 1, 6, 18, 45, 0, 0, DateTimeKind.Unspecified), "DbfJoSkD", 1, "Ferrero79", 35, 67.10311f },
                    { 23, new DateTime(2021, 3, 1, 22, 32, 0, 0, DateTimeKind.Unspecified), "AJMdvADA", 1, "Ferrero23", 35, 82.64198f },
                    { 7, new DateTime(2021, 11, 16, 21, 2, 0, 0, DateTimeKind.Unspecified), "SWADbjkk", 1, "Ferrero7", 34, 55.03979f },
                    { 91, new DateTime(2021, 11, 7, 10, 27, 0, 0, DateTimeKind.Unspecified), "IAaJeKJJ", 1, "Baklava91", 33, 90.33508f },
                    { 78, new DateTime(2021, 3, 10, 8, 10, 0, 0, DateTimeKind.Unspecified), "bWtsjWDH", 1, "Cokoladni kolac78", 33, 47.039993f },
                    { 44, new DateTime(2021, 11, 20, 14, 21, 0, 0, DateTimeKind.Unspecified), "SSDbifMr", 1, "Palacinke sa nutelom44", 33, 35.252678f },
                    { 77, new DateTime(2021, 11, 25, 13, 32, 0, 0, DateTimeKind.Unspecified), "HSJzDSIn", 1, "Saher torta77", 30, 29.799994f },
                    { 92, new DateTime(2021, 8, 5, 11, 15, 0, 0, DateTimeKind.Unspecified), "aMWaufpW", 1, "Palacinke sa nutelom92", 32, 18.017471f },
                    { 29, new DateTime(2021, 8, 26, 18, 1, 0, 0, DateTimeKind.Unspecified), "WSKDDweW", 1, "Saher torta29", 32, 68.56873f },
                    { 59, new DateTime(2021, 6, 15, 9, 25, 0, 0, DateTimeKind.Unspecified), "bLshzwrr", 1, "Baklava59", 31, 28.812088f },
                    { 14, new DateTime(2021, 5, 22, 17, 8, 0, 0, DateTimeKind.Unspecified), "DhIWppWM", 1, "Cokoladni kolac14", 31, 88.32203f },
                    { 43, new DateTime(2021, 8, 31, 8, 26, 0, 0, DateTimeKind.Unspecified), "zIJcakLA", 1, "Baklava43", 36, 64.01558f },
                    { 72, new DateTime(2021, 1, 19, 6, 34, 0, 0, DateTimeKind.Unspecified), "DKIsdKsl", 1, "Pizza sa sirom 72", 30, 79.90058f },
                    { 32, new DateTime(2021, 9, 25, 21, 23, 0, 0, DateTimeKind.Unspecified), "tDzakArB", 1, "Pizza sa sirom 32", 29, 34.819176f },
                    { 21, new DateTime(2021, 4, 2, 4, 58, 0, 0, DateTimeKind.Unspecified), "hDJntSjS", 1, "Saher torta21", 29, 1.8205385f },
                    { 20, new DateTime(2021, 10, 22, 17, 9, 0, 0, DateTimeKind.Unspecified), "bdjSMSMW", 1, "Palacinke sa nutelom20", 28, 10.378784f },
                    { 19, new DateTime(2021, 4, 13, 19, 9, 0, 0, DateTimeKind.Unspecified), "MmWoSjoW", 1, "Baklava19", 33, 66.573784f },
                    { 71, new DateTime(2021, 9, 13, 17, 6, 0, 0, DateTimeKind.Unspecified), "wMlAibas", 1, "Ferrero71", 36, 9.436601f },
                    { 30, new DateTime(2021, 5, 19, 11, 29, 0, 0, DateTimeKind.Unspecified), "WLaiSKkS", 1, "Cokoladni kolac30", 40, 36.613552f },
                    { 60, new DateTime(2021, 9, 27, 12, 40, 0, 0, DateTimeKind.Unspecified), "mHKMvLWs", 1, "Palacinke sa nutelom60", 37, 73.79445f },
                    { 8, new DateTime(2021, 2, 6, 20, 24, 0, 0, DateTimeKind.Unspecified), "dSjJifzs", 1, "Pizza sa sirom 8", 49, 64.20592f },
                    { 68, new DateTime(2021, 4, 8, 19, 42, 0, 0, DateTimeKind.Unspecified), "AWWSvliS", 1, "Palacinke sa nutelom68", 47, 87.24299f },
                    { 49, new DateTime(2021, 7, 8, 3, 24, 0, 0, DateTimeKind.Unspecified), "AuaKkwAe", 1, "Rafaelo49", 47, 81.84625f },
                    { 54, new DateTime(2021, 3, 28, 2, 45, 0, 0, DateTimeKind.Unspecified), "DSSALBsi", 1, "Cokoladni kolac54", 46, 76.41571f },
                    { 100, new DateTime(2021, 1, 15, 21, 39, 0, 0, DateTimeKind.Unspecified), "fnfkrAuA", 1, "Palacinke sa nutelom100", 45, 40.956535f }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedDate", "Description", "MyUserId", "Name", "RecipeCategoryId", "TotalCost" },
                values: new object[,]
                {
                    { 75, new DateTime(2021, 1, 15, 5, 42, 0, 0, DateTimeKind.Unspecified), "rswDawWJ", 1, "Baklava75", 45, 64.05253f },
                    { 9, new DateTime(2021, 9, 17, 9, 14, 0, 0, DateTimeKind.Unspecified), "WjIuWAIr", 1, "Rafaelo9", 45, 2.4608607f },
                    { 89, new DateTime(2021, 8, 21, 12, 5, 0, 0, DateTimeKind.Unspecified), "WDnDdjmA", 1, "Rafaelo89", 43, 19.754776f },
                    { 88, new DateTime(2021, 1, 3, 18, 26, 0, 0, DateTimeKind.Unspecified), "SKlguSAw", 1, "Pizza sa sirom 88", 43, 3.494494f },
                    { 85, new DateTime(2021, 4, 17, 22, 2, 0, 0, DateTimeKind.Unspecified), "SDmADSlA", 1, "Saher torta85", 43, 91.042854f },
                    { 69, new DateTime(2021, 3, 7, 16, 4, 0, 0, DateTimeKind.Unspecified), "AIKzdzMD", 1, "Saher torta69", 43, 58.19251f },
                    { 5, new DateTime(2021, 1, 4, 20, 44, 0, 0, DateTimeKind.Unspecified), "AKdmgKWD", 1, "Saher torta5", 41, 38.212975f },
                    { 65, new DateTime(2021, 4, 20, 23, 9, 0, 0, DateTimeKind.Unspecified), "DmmovcSW", 1, "Rafaelo65", 40, 92.57481f },
                    { 48, new DateTime(2021, 5, 15, 5, 44, 0, 0, DateTimeKind.Unspecified), "KDvfzHds", 1, "Pizza sa sirom 48", 40, 97.86227f },
                    { 10, new DateTime(2021, 2, 13, 11, 33, 0, 0, DateTimeKind.Unspecified), "WmAMming", 1, "Snickers10", 27, 93.72522f },
                    { 57, new DateTime(2021, 1, 14, 22, 40, 0, 0, DateTimeKind.Unspecified), "WfseIAsm", 1, "Rafaelo57", 39, 40.26725f },
                    { 31, new DateTime(2021, 9, 23, 12, 24, 0, 0, DateTimeKind.Unspecified), "WbAWWDSD", 1, "Ferrero31", 39, 25.6f },
                    { 94, new DateTime(2021, 2, 22, 22, 55, 0, 0, DateTimeKind.Unspecified), "SlvHAJvc", 1, "Cokoladni kolac94", 38, 45.86882f },
                    { 80, new DateTime(2021, 4, 28, 4, 20, 0, 0, DateTimeKind.Unspecified), "bLaJJBSA", 1, "Pizza sa sirom 80", 37, 81.76913f },
                    { 37, new DateTime(2021, 6, 14, 13, 10, 0, 0, DateTimeKind.Unspecified), "AshSJWoA", 1, "Saher torta37", 37, 68.8685f },
                    { 99, new DateTime(2021, 8, 2, 15, 11, 0, 0, DateTimeKind.Unspecified), "AJAMWSWS", 1, "Baklava99", 26, 85.65397f },
                    { 58, new DateTime(2021, 10, 8, 1, 54, 0, 0, DateTimeKind.Unspecified), "AkAJjWKW", 1, "Snickers58", 25, 67.45653f },
                    { 62, new DateTime(2021, 4, 28, 21, 38, 0, 0, DateTimeKind.Unspecified), "uKJdWrJr", 1, "Cokoladni kolac62", 26, 87.681046f },
                    { 98, new DateTime(2021, 5, 2, 10, 41, 0, 0, DateTimeKind.Unspecified), "ddWLgdJn", 1, "Snickers98", 15, 50.244366f },
                    { 96, new DateTime(2021, 6, 12, 13, 48, 0, 0, DateTimeKind.Unspecified), "mDKhDlsz", 1, "Pizza sa sirom 96", 15, 14.029121f },
                    { 17, new DateTime(2021, 7, 16, 17, 39, 0, 0, DateTimeKind.Unspecified), "JcAgSSSS", 1, "Rafaelo17", 15, 74.27336f },
                    { 93, new DateTime(2021, 1, 14, 1, 40, 0, 0, DateTimeKind.Unspecified), "JAvsSMSA", 1, "Saher torta93", 14, 41.37796f },
                    { 33, new DateTime(2021, 3, 30, 21, 12, 0, 0, DateTimeKind.Unspecified), "bSIDsDdH", 1, "Rafaelo33", 14, 97.11706f },
                    { 64, new DateTime(2021, 5, 1, 21, 45, 0, 0, DateTimeKind.Unspecified), "KgSgAsSe", 1, "Pizza sa sirom 64", 12, 85.207146f },
                    { 52, new DateTime(2021, 8, 17, 2, 38, 0, 0, DateTimeKind.Unspecified), "puaSAzoS", 1, "Palacinke sa nutelom52", 12, 59.02001f },
                    { 87, new DateTime(2021, 11, 3, 5, 55, 0, 0, DateTimeKind.Unspecified), "gjfWJkAr", 1, "Ferrero87", 11, 36.129776f },
                    { 27, new DateTime(2021, 2, 11, 18, 31, 0, 0, DateTimeKind.Unspecified), "hMpoILiz", 1, "Baklava27", 11, 24.685972f },
                    { 26, new DateTime(2021, 3, 8, 8, 3, 0, 0, DateTimeKind.Unspecified), "dlcvwfKd", 1, "Snickers26", 11, 66.86689f },
                    { 11, new DateTime(2021, 10, 10, 19, 52, 0, 0, DateTimeKind.Unspecified), "AaDhnlLp", 1, "Baklava11", 11, 31.04328f },
                    { 47, new DateTime(2021, 10, 29, 8, 45, 0, 0, DateTimeKind.Unspecified), "SwSDADSW", 1, "Ferrero47", 9, 44.331715f },
                    { 36, new DateTime(2021, 11, 21, 9, 7, 0, 0, DateTimeKind.Unspecified), "aijscdKe", 1, "Palacinke sa nutelom36", 9, 1.722713f },
                    { 18, new DateTime(2021, 10, 3, 13, 6, 0, 0, DateTimeKind.Unspecified), "srhgzdDl", 1, "Snickers18", 9, 22.852417f },
                    { 74, new DateTime(2021, 1, 4, 7, 53, 0, 0, DateTimeKind.Unspecified), "pALcJpmK", 1, "Snickers74", 8, 96.25708f },
                    { 16, new DateTime(2021, 3, 30, 6, 16, 0, 0, DateTimeKind.Unspecified), "sALSptDI", 1, "Pizza sa sirom 16", 8, 62.27899f },
                    { 82, new DateTime(2021, 8, 28, 12, 47, 0, 0, DateTimeKind.Unspecified), "HjwlepAS", 1, "Snickers82", 7, 42.623978f },
                    { 35, new DateTime(2021, 3, 18, 1, 3, 0, 0, DateTimeKind.Unspecified), "SAsAbWBe", 1, "Baklava35", 7, 59.70133f },
                    { 56, new DateTime(2021, 8, 21, 16, 47, 0, 0, DateTimeKind.Unspecified), "AuzSwBhS", 1, "Pizza sa sirom 56", 6, 53.12489f },
                    { 4, new DateTime(2021, 8, 29, 5, 36, 0, 0, DateTimeKind.Unspecified), "mSlpAKSA", 1, "Palacinke sa nutelom4", 16, 63.916904f },
                    { 28, new DateTime(2021, 7, 21, 23, 24, 0, 0, DateTimeKind.Unspecified), "aiAhSBkl", 1, "Palacinke sa nutelom28", 16, 18.075897f },
                    { 39, new DateTime(2021, 11, 19, 11, 36, 0, 0, DateTimeKind.Unspecified), "SDdslSAv", 1, "Ferrero39", 16, 30.88939f },
                    { 50, new DateTime(2021, 5, 12, 12, 28, 0, 0, DateTimeKind.Unspecified), "mDJjvuWH", 1, "Snickers50", 16, 39.46512f },
                    { 55, new DateTime(2021, 11, 23, 4, 12, 0, 0, DateTimeKind.Unspecified), "WKaSoudS", 1, "Ferrero55", 26, 66.15864f }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedDate", "Description", "MyUserId", "Name", "RecipeCategoryId", "TotalCost" },
                values: new object[,]
                {
                    { 45, new DateTime(2021, 1, 30, 20, 7, 0, 0, DateTimeKind.Unspecified), "jciDBsBJ", 1, "Saher torta45", 26, 8.592354f },
                    { 95, new DateTime(2021, 5, 12, 20, 54, 0, 0, DateTimeKind.Unspecified), "dApWSdtg", 1, "Ferrero95", 25, 97.466324f },
                    { 76, new DateTime(2021, 8, 21, 23, 3, 0, 0, DateTimeKind.Unspecified), "WespSsAh", 1, "Palacinke sa nutelom76", 25, 3.2299244f },
                    { 38, new DateTime(2021, 6, 28, 11, 5, 0, 0, DateTimeKind.Unspecified), "SSWhaDJt", 1, "Cokoladni kolac38", 49, 25.7992f },
                    { 22, new DateTime(2021, 8, 27, 21, 59, 0, 0, DateTimeKind.Unspecified), "lvAjgWAn", 1, "Cokoladni kolac22", 25, 86.95367f },
                    { 97, new DateTime(2021, 3, 1, 3, 32, 0, 0, DateTimeKind.Unspecified), "KJJvsgDM", 1, "Rafaelo97", 23, 73.9886f },
                    { 46, new DateTime(2021, 10, 17, 15, 50, 0, 0, DateTimeKind.Unspecified), "oIWsJoJM", 1, "Cokoladni kolac46", 23, 43.087337f },
                    { 6, new DateTime(2021, 1, 10, 8, 52, 0, 0, DateTimeKind.Unspecified), "AvwbJfhl", 1, "Cokoladni kolac6", 23, 60.125317f },
                    { 70, new DateTime(2021, 5, 25, 19, 12, 0, 0, DateTimeKind.Unspecified), "AaiSlSJA", 1, "Cokoladni kolac70", 26, 42.229397f },
                    { 90, new DateTime(2021, 6, 25, 8, 16, 0, 0, DateTimeKind.Unspecified), "BesKMKwS", 1, "Snickers90", 22, 54.39117f },
                    { 13, new DateTime(2021, 11, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), "DfzBpKBl", 1, "Saher torta13", 22, 8.134824f },
                    { 61, new DateTime(2021, 10, 27, 14, 20, 0, 0, DateTimeKind.Unspecified), "wJiSdmtf", 1, "Saher torta61", 21, 37.019714f },
                    { 41, new DateTime(2021, 10, 8, 11, 26, 0, 0, DateTimeKind.Unspecified), "DvstLWWm", 1, "Rafaelo41", 21, 60.681747f },
                    { 12, new DateTime(2021, 1, 22, 21, 44, 0, 0, DateTimeKind.Unspecified), "BAivsWsS", 1, "Palacinke sa nutelom12", 21, 50.958755f },
                    { 63, new DateTime(2021, 5, 12, 2, 23, 0, 0, DateTimeKind.Unspecified), "JSWJjDuk", 1, "Ferrero63", 20, 85.06796f },
                    { 84, new DateTime(2021, 4, 17, 5, 32, 0, 0, DateTimeKind.Unspecified), "SovhSjDA", 1, "Palacinke sa nutelom84", 18, 5.3984475f },
                    { 34, new DateTime(2021, 8, 15, 16, 18, 0, 0, DateTimeKind.Unspecified), "SBASLDIz", 1, "Snickers34", 18, 70.95845f },
                    { 83, new DateTime(2021, 1, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), "AWIWsJAS", 1, "Baklava83", 16, 95.82758f },
                    { 66, new DateTime(2021, 1, 15, 22, 28, 0, 0, DateTimeKind.Unspecified), "slJWWmSA", 1, "Snickers66", 16, 19.462399f },
                    { 81, new DateTime(2021, 4, 7, 23, 18, 0, 0, DateTimeKind.Unspecified), "kWuSzIWD", 1, "Rafaelo81", 22, 61.580055f },
                    { 86, new DateTime(2021, 2, 7, 9, 45, 0, 0, DateTimeKind.Unspecified), "mDWerDwA", 1, "Cokoladni kolac86", 49, 25.104528f }
                });

            migrationBuilder.InsertData(
                table: "IngredientRecipes",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 19, new DateTime(2021, 1, 14, 23, 42, 0, 0, DateTimeKind.Unspecified), 32, 0f, 34.27f, 35, 3 },
                    { 95, new DateTime(2021, 3, 27, 13, 14, 0, 0, DateTimeKind.Unspecified), 56, 0f, 18.3f, 19, 4 },
                    { 86, new DateTime(2021, 5, 20, 12, 49, 0, 0, DateTimeKind.Unspecified), 68, 0f, 38.53f, 14, 2 },
                    { 57, new DateTime(2021, 1, 7, 5, 26, 0, 0, DateTimeKind.Unspecified), 84, 0f, 5.86f, 14, 2 },
                    { 44, new DateTime(2021, 5, 20, 6, 56, 0, 0, DateTimeKind.Unspecified), 18, 0f, 27.06f, 21, 4 },
                    { 63, new DateTime(2021, 3, 28, 20, 34, 0, 0, DateTimeKind.Unspecified), 33, 0f, 11.99f, 10, 3 },
                    { 92, new DateTime(2021, 11, 21, 17, 14, 0, 0, DateTimeKind.Unspecified), 11, 0f, 40.24f, 99, 1 },
                    { 61, new DateTime(2021, 1, 9, 1, 57, 0, 0, DateTimeKind.Unspecified), 20, 0f, 33.35f, 99, 1 },
                    { 50, new DateTime(2021, 3, 13, 19, 21, 0, 0, DateTimeKind.Unspecified), 26, 0f, 29.68f, 99, 5 },
                    { 94, new DateTime(2021, 3, 3, 20, 38, 0, 0, DateTimeKind.Unspecified), 63, 0f, 23.54f, 44, 3 },
                    { 11, new DateTime(2021, 8, 25, 3, 14, 0, 0, DateTimeKind.Unspecified), 74, 0f, 6.26f, 99, 5 },
                    { 77, new DateTime(2021, 11, 28, 8, 41, 0, 0, DateTimeKind.Unspecified), 64, 0f, 9.21f, 55, 1 },
                    { 48, new DateTime(2021, 10, 24, 20, 35, 0, 0, DateTimeKind.Unspecified), 14, 0f, 13.81f, 95, 4 },
                    { 28, new DateTime(2021, 8, 21, 2, 34, 0, 0, DateTimeKind.Unspecified), 50, 0f, 2.85f, 58, 3 },
                    { 31, new DateTime(2021, 6, 23, 19, 30, 0, 0, DateTimeKind.Unspecified), 59, 0f, 12.22f, 22, 2 },
                    { 35, new DateTime(2021, 4, 3, 13, 1, 0, 0, DateTimeKind.Unspecified), 10, 0f, 36.98f, 97, 2 },
                    { 54, new DateTime(2021, 5, 22, 1, 47, 0, 0, DateTimeKind.Unspecified), 1, 0f, 3.92f, 46, 1 },
                    { 97, new DateTime(2021, 9, 19, 1, 47, 0, 0, DateTimeKind.Unspecified), 80, 0f, 4.01f, 6, 3 },
                    { 43, new DateTime(2021, 9, 20, 21, 24, 0, 0, DateTimeKind.Unspecified), 63, 0f, 17.08f, 81, 1 },
                    { 27, new DateTime(2021, 1, 6, 4, 54, 0, 0, DateTimeKind.Unspecified), 47, 0f, 49.12f, 70, 4 },
                    { 71, new DateTime(2021, 8, 10, 2, 26, 0, 0, DateTimeKind.Unspecified), 98, 0f, 43.45f, 13, 3 },
                    { 22, new DateTime(2021, 9, 20, 6, 5, 0, 0, DateTimeKind.Unspecified), 6, 0f, 25.9f, 78, 5 },
                    { 70, new DateTime(2021, 10, 7, 3, 6, 0, 0, DateTimeKind.Unspecified), 16, 0f, 8.81f, 79, 2 },
                    { 84, new DateTime(2021, 5, 12, 15, 37, 0, 0, DateTimeKind.Unspecified), 93, 0f, 5.71f, 54, 4 },
                    { 51, new DateTime(2021, 2, 28, 12, 9, 0, 0, DateTimeKind.Unspecified), 83, 0f, 2.89f, 88, 3 },
                    { 82, new DateTime(2021, 2, 10, 8, 19, 0, 0, DateTimeKind.Unspecified), 40, 0f, 14.32f, 85, 5 },
                    { 53, new DateTime(2021, 4, 18, 10, 59, 0, 0, DateTimeKind.Unspecified), 10, 0f, 46.01f, 69, 5 },
                    { 29, new DateTime(2021, 7, 23, 10, 59, 0, 0, DateTimeKind.Unspecified), 18, 0f, 48.57f, 69, 3 },
                    { 21, new DateTime(2021, 2, 10, 16, 32, 0, 0, DateTimeKind.Unspecified), 83, 0f, 23.36f, 69, 3 },
                    { 99, new DateTime(2021, 8, 8, 21, 17, 0, 0, DateTimeKind.Unspecified), 56, 0f, 7.37f, 5, 1 },
                    { 80, new DateTime(2021, 5, 14, 12, 47, 0, 0, DateTimeKind.Unspecified), 35, 0f, 21.75f, 5, 2 },
                    { 40, new DateTime(2021, 4, 4, 15, 11, 0, 0, DateTimeKind.Unspecified), 38, 0f, 5.68f, 7, 1 },
                    { 36, new DateTime(2021, 8, 14, 10, 15, 0, 0, DateTimeKind.Unspecified), 45, 0f, 16.58f, 48, 1 },
                    { 6, new DateTime(2021, 1, 14, 6, 51, 0, 0, DateTimeKind.Unspecified), 99, 0f, 6f, 31, 4 },
                    { 37, new DateTime(2021, 6, 20, 23, 6, 0, 0, DateTimeKind.Unspecified), 6, 0f, 23.26f, 60, 3 },
                    { 78, new DateTime(2021, 2, 28, 0, 40, 0, 0, DateTimeKind.Unspecified), 61, 0f, 16.47f, 37, 1 },
                    { 5, new DateTime(2021, 7, 27, 19, 22, 0, 0, DateTimeKind.Unspecified), 39, 0f, 34.09f, 37, 1 },
                    { 66, new DateTime(2021, 1, 30, 0, 23, 0, 0, DateTimeKind.Unspecified), 78, 0f, 49.37f, 71, 1 },
                    { 79, new DateTime(2021, 10, 11, 2, 46, 0, 0, DateTimeKind.Unspecified), 53, 0f, 30.82f, 43, 2 },
                    { 13, new DateTime(2021, 10, 2, 7, 9, 0, 0, DateTimeKind.Unspecified), 50, 0f, 17.63f, 43, 5 },
                    { 2, new DateTime(2021, 7, 23, 13, 3, 0, 0, DateTimeKind.Unspecified), 59, 0f, 16.34f, 43, 2 },
                    { 24, new DateTime(2021, 8, 11, 7, 48, 0, 0, DateTimeKind.Unspecified), 12, 0f, 29.91f, 48, 3 }
                });

            migrationBuilder.InsertData(
                table: "IngredientRecipes",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 7, new DateTime(2021, 10, 3, 1, 8, 0, 0, DateTimeKind.Unspecified), 78, 0f, 7.64f, 49, 4 },
                    { 59, new DateTime(2021, 7, 28, 23, 28, 0, 0, DateTimeKind.Unspecified), 36, 0f, 7.74f, 13, 2 },
                    { 74, new DateTime(2021, 9, 10, 8, 30, 0, 0, DateTimeKind.Unspecified), 56, 0f, 38.87f, 61, 3 },
                    { 93, new DateTime(2021, 4, 4, 12, 19, 0, 0, DateTimeKind.Unspecified), 63, 0f, 37.23f, 17, 1 },
                    { 69, new DateTime(2021, 10, 15, 16, 3, 0, 0, DateTimeKind.Unspecified), 65, 0f, 20.88f, 17, 3 },
                    { 68, new DateTime(2021, 10, 11, 10, 3, 0, 0, DateTimeKind.Unspecified), 18, 0f, 37.48f, 93, 1 },
                    { 34, new DateTime(2021, 11, 19, 21, 6, 0, 0, DateTimeKind.Unspecified), 62, 0f, 39.55f, 64, 4 },
                    { 98, new DateTime(2021, 2, 12, 16, 16, 0, 0, DateTimeKind.Unspecified), 71, 0f, 4.8f, 87, 2 },
                    { 83, new DateTime(2021, 1, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 70, 0f, 23.72f, 87, 2 },
                    { 16, new DateTime(2021, 3, 2, 1, 33, 0, 0, DateTimeKind.Unspecified), 62, 0f, 3.94f, 87, 1 },
                    { 58, new DateTime(2021, 6, 28, 5, 52, 0, 0, DateTimeKind.Unspecified), 32, 0f, 37.37f, 27, 3 },
                    { 62, new DateTime(2021, 2, 12, 22, 34, 0, 0, DateTimeKind.Unspecified), 11, 0f, 33.35f, 96, 5 },
                    { 33, new DateTime(2021, 7, 6, 16, 58, 0, 0, DateTimeKind.Unspecified), 63, 0f, 40.87f, 27, 3 },
                    { 52, new DateTime(2021, 2, 4, 6, 41, 0, 0, DateTimeKind.Unspecified), 83, 0f, 38.11f, 26, 2 },
                    { 47, new DateTime(2021, 10, 2, 4, 6, 0, 0, DateTimeKind.Unspecified), 35, 0f, 32.27f, 11, 2 },
                    { 41, new DateTime(2021, 4, 5, 8, 36, 0, 0, DateTimeKind.Unspecified), 64, 0f, 46.22f, 11, 5 },
                    { 67, new DateTime(2021, 4, 1, 21, 30, 0, 0, DateTimeKind.Unspecified), 48, 0f, 38.45f, 36, 2 },
                    { 73, new DateTime(2021, 5, 7, 10, 40, 0, 0, DateTimeKind.Unspecified), 12, 0f, 15.96f, 18, 2 },
                    { 72, new DateTime(2021, 5, 14, 13, 50, 0, 0, DateTimeKind.Unspecified), 51, 0f, 32.14f, 74, 4 },
                    { 18, new DateTime(2021, 1, 25, 20, 50, 0, 0, DateTimeKind.Unspecified), 67, 0f, 43.17f, 74, 2 },
                    { 88, new DateTime(2021, 2, 15, 15, 10, 0, 0, DateTimeKind.Unspecified), 36, 0f, 19.72f, 16, 5 },
                    { 32, new DateTime(2021, 7, 27, 2, 51, 0, 0, DateTimeKind.Unspecified), 94, 0f, 45.36f, 27, 3 },
                    { 1, new DateTime(2021, 1, 25, 15, 18, 0, 0, DateTimeKind.Unspecified), 34, 0f, 46.91f, 13, 2 },
                    { 89, new DateTime(2021, 1, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 34, 0f, 2f, 96, 5 },
                    { 46, new DateTime(2021, 2, 2, 19, 57, 0, 0, DateTimeKind.Unspecified), 43, 0f, 38.32f, 39, 2 },
                    { 17, new DateTime(2021, 4, 15, 1, 38, 0, 0, DateTimeKind.Unspecified), 95, 0f, 19.75f, 41, 4 },
                    { 91, new DateTime(2021, 8, 8, 4, 49, 0, 0, DateTimeKind.Unspecified), 27, 0f, 36.99f, 12, 2 },
                    { 42, new DateTime(2021, 1, 16, 22, 22, 0, 0, DateTimeKind.Unspecified), 86, 0f, 13.08f, 12, 4 },
                    { 38, new DateTime(2021, 10, 30, 11, 47, 0, 0, DateTimeKind.Unspecified), 24, 0f, 38.97f, 12, 1 },
                    { 23, new DateTime(2021, 7, 17, 7, 36, 0, 0, DateTimeKind.Unspecified), 61, 0f, 45.22f, 12, 1 },
                    { 3, new DateTime(2021, 3, 10, 13, 40, 0, 0, DateTimeKind.Unspecified), 43, 0f, 35.39f, 12, 1 },
                    { 39, new DateTime(2021, 8, 19, 10, 10, 0, 0, DateTimeKind.Unspecified), 59, 0f, 33.97f, 63, 4 },
                    { 64, new DateTime(2021, 8, 9, 5, 7, 0, 0, DateTimeKind.Unspecified), 2, 0f, 4.82f, 84, 1 },
                    { 10, new DateTime(2021, 4, 4, 5, 9, 0, 0, DateTimeKind.Unspecified), 89, 0f, 3.71f, 98, 1 },
                    { 100, new DateTime(2021, 8, 31, 4, 38, 0, 0, DateTimeKind.Unspecified), 59, 0f, 38.67f, 34, 2 },
                    { 15, new DateTime(2021, 6, 22, 13, 21, 0, 0, DateTimeKind.Unspecified), 21, 0f, 34.61f, 34, 1 },
                    { 14, new DateTime(2021, 2, 18, 5, 5, 0, 0, DateTimeKind.Unspecified), 30, 0f, 3.6f, 34, 1 },
                    { 9, new DateTime(2021, 3, 13, 21, 2, 0, 0, DateTimeKind.Unspecified), 50, 0f, 38.63f, 83, 2 },
                    { 96, new DateTime(2021, 2, 21, 10, 2, 0, 0, DateTimeKind.Unspecified), 24, 0f, 15.98f, 66, 3 },
                    { 75, new DateTime(2021, 11, 7, 4, 47, 0, 0, DateTimeKind.Unspecified), 28, 0f, 29.59f, 66, 2 },
                    { 25, new DateTime(2021, 6, 16, 8, 44, 0, 0, DateTimeKind.Unspecified), 42, 0f, 44.53f, 66, 2 },
                    { 76, new DateTime(2021, 1, 25, 18, 10, 0, 0, DateTimeKind.Unspecified), 86, 0f, 40.2f, 50, 5 }
                });

            migrationBuilder.InsertData(
                table: "IngredientRecipes",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { 4, new DateTime(2021, 2, 13, 8, 12, 0, 0, DateTimeKind.Unspecified), 47, 0f, 35.95f, 50, 1 });

            migrationBuilder.InsertData(
                table: "IngredientRecipes",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { 20, new DateTime(2021, 3, 14, 13, 24, 0, 0, DateTimeKind.Unspecified), 17, 0f, 8.05f, 34, 3 });

            migrationBuilder.InsertData(
                table: "IngredientRecipes",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[] { 55, new DateTime(2021, 11, 3, 5, 6, 0, 0, DateTimeKind.Unspecified), 92, 0f, 36.37f, 8, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brasno", 1, 20f, 18f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ulje", 4, 3f, 1f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secer", 1, 1.5f, 1f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Name", "UnitMeasure", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jaja", 1, 10f, 30f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Name", "UnitPrice", "UnitQuantity" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maslac", 25f, 2f });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), "Pizza kategorijaa", "Pizza" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2009, 6, 12, 8, 30, 52, 0, DateTimeKind.Unspecified), "Pizza kategorija", "Palacinke" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2018, 12, 21, 8, 30, 52, 0, DateTimeKind.Unspecified), "Kolac kategorija", "Kolac" });

            migrationBuilder.UpdateData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Hamburger kategorija", "Hamburger" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Name", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2018, 12, 21, 8, 30, 52, 0, DateTimeKind.Unspecified), "Ukusni kolac", "Rafaelo", 3, 0f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "MyUserId", "Name", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2016, 12, 21, 8, 30, 52, 0, DateTimeKind.Unspecified), "Predobar kolac", 2, "Snickers", 3, 0f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Name", "RecipeCategoryId", "TotalCost" },
                values: new object[] { new DateTime(2018, 12, 21, 8, 30, 52, 0, DateTimeKind.Unspecified), "Vrhunski specijalitet", "Palacinke sa nutelom", 2, 0f });
        }
    }
}
