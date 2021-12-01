using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Database.Migrations
{
    public partial class SeedDataToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CreatedDate", "Name", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 25, 2, 6, 0, 0, DateTimeKind.Unspecified), "Ulje1", 10.53f, 4, 14f },
                    { 73, new DateTime(2021, 2, 26, 16, 27, 0, 0, DateTimeKind.Unspecified), "Ulje73", 30.1f, 1, 27f },
                    { 72, new DateTime(2021, 1, 17, 1, 51, 0, 0, DateTimeKind.Unspecified), "Brasno72", 49.69f, 4, 37f },
                    { 71, new DateTime(2021, 3, 7, 9, 32, 0, 0, DateTimeKind.Unspecified), "Cokolada71", 42.47f, 4, 15f },
                    { 70, new DateTime(2021, 4, 25, 7, 24, 0, 0, DateTimeKind.Unspecified), "Maslac70", 3.09f, 5, 38f },
                    { 69, new DateTime(2021, 2, 4, 16, 45, 0, 0, DateTimeKind.Unspecified), "Jaja69", 4.65f, 3, 11f },
                    { 68, new DateTime(2021, 7, 14, 20, 29, 0, 0, DateTimeKind.Unspecified), "Secer68", 29.91f, 2, 43f },
                    { 67, new DateTime(2021, 7, 2, 23, 2, 0, 0, DateTimeKind.Unspecified), "Ulje67", 9.23f, 2, 5f },
                    { 66, new DateTime(2021, 11, 27, 5, 51, 0, 0, DateTimeKind.Unspecified), "Brasno66", 9.89f, 1, 6f },
                    { 65, new DateTime(2021, 9, 14, 23, 21, 0, 0, DateTimeKind.Unspecified), "Cokolada65", 10.89f, 4, 13f },
                    { 64, new DateTime(2021, 1, 4, 0, 37, 0, 0, DateTimeKind.Unspecified), "Maslac64", 43.56f, 5, 3f },
                    { 63, new DateTime(2021, 4, 15, 17, 13, 0, 0, DateTimeKind.Unspecified), "Jaja63", 37.84f, 4, 34f },
                    { 62, new DateTime(2021, 1, 27, 4, 46, 0, 0, DateTimeKind.Unspecified), "Secer62", 21.17f, 5, 20f },
                    { 61, new DateTime(2021, 8, 26, 1, 7, 0, 0, DateTimeKind.Unspecified), "Ulje61", 40.47f, 5, 37f },
                    { 60, new DateTime(2021, 9, 4, 15, 41, 0, 0, DateTimeKind.Unspecified), "Brasno60", 8.94f, 2, 47f },
                    { 59, new DateTime(2021, 3, 26, 13, 34, 0, 0, DateTimeKind.Unspecified), "Cokolada59", 12.65f, 4, 29f },
                    { 58, new DateTime(2021, 7, 21, 11, 1, 0, 0, DateTimeKind.Unspecified), "Maslac58", 23.69f, 4, 21f },
                    { 57, new DateTime(2021, 3, 15, 8, 16, 0, 0, DateTimeKind.Unspecified), "Jaja57", 31.24f, 2, 49f },
                    { 56, new DateTime(2021, 1, 8, 21, 4, 0, 0, DateTimeKind.Unspecified), "Secer56", 14.8f, 2, 34f },
                    { 55, new DateTime(2021, 1, 31, 1, 41, 0, 0, DateTimeKind.Unspecified), "Ulje55", 7.03f, 2, 37f },
                    { 54, new DateTime(2021, 6, 30, 4, 43, 0, 0, DateTimeKind.Unspecified), "Brasno54", 41.16f, 2, 33f },
                    { 53, new DateTime(2021, 10, 10, 9, 55, 0, 0, DateTimeKind.Unspecified), "Cokolada53", 45.6f, 1, 41f },
                    { 74, new DateTime(2021, 2, 10, 15, 56, 0, 0, DateTimeKind.Unspecified), "Secer74", 34.28f, 3, 46f },
                    { 75, new DateTime(2021, 8, 24, 2, 50, 0, 0, DateTimeKind.Unspecified), "Jaja75", 18.53f, 2, 21f },
                    { 76, new DateTime(2021, 6, 12, 8, 45, 0, 0, DateTimeKind.Unspecified), "Maslac76", 4.21f, 3, 46f },
                    { 77, new DateTime(2021, 9, 26, 11, 20, 0, 0, DateTimeKind.Unspecified), "Cokolada77", 48.5f, 1, 33f },
                    { 99, new DateTime(2021, 7, 15, 21, 25, 0, 0, DateTimeKind.Unspecified), "Jaja99", 1.28f, 2, 25f },
                    { 98, new DateTime(2021, 7, 16, 17, 4, 0, 0, DateTimeKind.Unspecified), "Secer98", 43.71f, 2, 49f },
                    { 97, new DateTime(2021, 1, 3, 18, 48, 0, 0, DateTimeKind.Unspecified), "Ulje97", 49.58f, 4, 11f },
                    { 96, new DateTime(2021, 3, 21, 5, 3, 0, 0, DateTimeKind.Unspecified), "Brasno96", 24.62f, 5, 18f },
                    { 95, new DateTime(2021, 6, 16, 13, 16, 0, 0, DateTimeKind.Unspecified), "Cokolada95", 5.24f, 3, 41f },
                    { 94, new DateTime(2021, 2, 11, 8, 52, 0, 0, DateTimeKind.Unspecified), "Maslac94", 42.73f, 3, 22f },
                    { 93, new DateTime(2021, 10, 17, 20, 8, 0, 0, DateTimeKind.Unspecified), "Jaja93", 22.21f, 2, 9f },
                    { 92, new DateTime(2021, 7, 2, 18, 3, 0, 0, DateTimeKind.Unspecified), "Secer92", 39.92f, 5, 22f },
                    { 91, new DateTime(2021, 1, 24, 7, 2, 0, 0, DateTimeKind.Unspecified), "Ulje91", 1.85f, 2, 25f },
                    { 90, new DateTime(2021, 6, 28, 4, 21, 0, 0, DateTimeKind.Unspecified), "Brasno90", 31.45f, 1, 23f },
                    { 52, new DateTime(2021, 1, 27, 14, 29, 0, 0, DateTimeKind.Unspecified), "Maslac52", 45.17f, 5, 46f },
                    { 89, new DateTime(2021, 9, 16, 17, 39, 0, 0, DateTimeKind.Unspecified), "Cokolada89", 16.93f, 4, 35f },
                    { 87, new DateTime(2021, 11, 18, 23, 11, 0, 0, DateTimeKind.Unspecified), "Jaja87", 33.44f, 3, 7f },
                    { 86, new DateTime(2021, 2, 23, 14, 34, 0, 0, DateTimeKind.Unspecified), "Secer86", 2.53f, 1, 17f },
                    { 85, new DateTime(2021, 8, 24, 13, 57, 0, 0, DateTimeKind.Unspecified), "Ulje85", 27.47f, 5, 32f },
                    { 84, new DateTime(2021, 6, 22, 1, 57, 0, 0, DateTimeKind.Unspecified), "Brasno84", 34.57f, 4, 19f }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CreatedDate", "Name", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[,]
                {
                    { 83, new DateTime(2021, 4, 10, 9, 43, 0, 0, DateTimeKind.Unspecified), "Cokolada83", 36.31f, 5, 23f },
                    { 82, new DateTime(2021, 6, 8, 20, 23, 0, 0, DateTimeKind.Unspecified), "Maslac82", 18.61f, 3, 25f },
                    { 81, new DateTime(2021, 9, 30, 17, 34, 0, 0, DateTimeKind.Unspecified), "Jaja81", 24.42f, 5, 29f },
                    { 80, new DateTime(2021, 8, 28, 9, 38, 0, 0, DateTimeKind.Unspecified), "Secer80", 30.49f, 5, 12f },
                    { 79, new DateTime(2021, 5, 21, 13, 35, 0, 0, DateTimeKind.Unspecified), "Ulje79", 7.8f, 4, 41f },
                    { 78, new DateTime(2021, 6, 14, 11, 21, 0, 0, DateTimeKind.Unspecified), "Brasno78", 17.25f, 2, 22f },
                    { 88, new DateTime(2021, 8, 9, 16, 52, 0, 0, DateTimeKind.Unspecified), "Maslac88", 22.21f, 3, 16f },
                    { 51, new DateTime(2021, 2, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), "Jaja51", 14.88f, 3, 4f },
                    { 100, new DateTime(2021, 9, 20, 6, 9, 0, 0, DateTimeKind.Unspecified), "Maslac100", 2.3f, 4, 28f },
                    { 49, new DateTime(2021, 4, 9, 2, 35, 0, 0, DateTimeKind.Unspecified), "Ulje49", 34.4f, 3, 42f },
                    { 22, new DateTime(2021, 5, 17, 5, 2, 0, 0, DateTimeKind.Unspecified), "Maslac22", 49.55f, 4, 40f },
                    { 21, new DateTime(2021, 9, 27, 20, 47, 0, 0, DateTimeKind.Unspecified), "Jaja21", 3.5f, 1, 15f },
                    { 20, new DateTime(2021, 1, 9, 12, 40, 0, 0, DateTimeKind.Unspecified), "Secer20", 9.75f, 1, 29f },
                    { 19, new DateTime(2021, 4, 23, 6, 20, 0, 0, DateTimeKind.Unspecified), "Ulje19", 31.13f, 4, 16f },
                    { 18, new DateTime(2021, 1, 13, 17, 1, 0, 0, DateTimeKind.Unspecified), "Brasno18", 26.86f, 3, 46f },
                    { 17, new DateTime(2021, 2, 28, 11, 34, 0, 0, DateTimeKind.Unspecified), "Cokolada17", 41.64f, 5, 32f },
                    { 16, new DateTime(2021, 4, 28, 14, 36, 0, 0, DateTimeKind.Unspecified), "Maslac16", 1.67f, 1, 23f },
                    { 15, new DateTime(2021, 7, 30, 22, 43, 0, 0, DateTimeKind.Unspecified), "Jaja15", 14.42f, 3, 47f },
                    { 13, new DateTime(2021, 6, 1, 15, 50, 0, 0, DateTimeKind.Unspecified), "Ulje13", 23.59f, 5, 43f },
                    { 12, new DateTime(2021, 9, 9, 20, 38, 0, 0, DateTimeKind.Unspecified), "Brasno12", 13.57f, 3, 44f },
                    { 11, new DateTime(2021, 9, 28, 14, 58, 0, 0, DateTimeKind.Unspecified), "Cokolada11", 43.95f, 5, 31f },
                    { 10, new DateTime(2021, 1, 6, 4, 26, 0, 0, DateTimeKind.Unspecified), "Maslac10", 49.19f, 3, 32f },
                    { 9, new DateTime(2021, 9, 29, 22, 55, 0, 0, DateTimeKind.Unspecified), "Jaja9", 13.8f, 5, 15f },
                    { 8, new DateTime(2021, 9, 20, 17, 19, 0, 0, DateTimeKind.Unspecified), "Secer8", 45.85f, 2, 47f },
                    { 7, new DateTime(2021, 8, 12, 17, 4, 0, 0, DateTimeKind.Unspecified), "Ulje7", 39.93f, 4, 24f },
                    { 6, new DateTime(2021, 3, 24, 4, 49, 0, 0, DateTimeKind.Unspecified), "Brasno6", 29.79f, 3, 13f },
                    { 5, new DateTime(2021, 10, 4, 4, 50, 0, 0, DateTimeKind.Unspecified), "Cokolada5", 7.27f, 2, 2f },
                    { 4, new DateTime(2021, 1, 29, 19, 57, 0, 0, DateTimeKind.Unspecified), "Maslac4", 15.81f, 3, 20f },
                    { 3, new DateTime(2021, 9, 28, 12, 37, 0, 0, DateTimeKind.Unspecified), "Jaja3", 10.76f, 3, 36f },
                    { 2, new DateTime(2021, 1, 27, 16, 25, 0, 0, DateTimeKind.Unspecified), "Secer2", 38.49f, 1, 22f },
                    { 50, new DateTime(2021, 11, 14, 22, 8, 0, 0, DateTimeKind.Unspecified), "Secer50", 38.61f, 1, 30f },
                    { 23, new DateTime(2021, 10, 13, 8, 8, 0, 0, DateTimeKind.Unspecified), "Cokolada23", 14.88f, 5, 14f },
                    { 24, new DateTime(2021, 3, 11, 1, 36, 0, 0, DateTimeKind.Unspecified), "Brasno24", 12.8f, 1, 44f },
                    { 14, new DateTime(2021, 8, 9, 18, 10, 0, 0, DateTimeKind.Unspecified), "Secer14", 14.47f, 5, 26f },
                    { 26, new DateTime(2021, 1, 30, 13, 8, 0, 0, DateTimeKind.Unspecified), "Secer26", 45.38f, 4, 23f },
                    { 25, new DateTime(2021, 10, 4, 6, 22, 0, 0, DateTimeKind.Unspecified), "Ulje25", 25.25f, 4, 34f },
                    { 47, new DateTime(2021, 3, 30, 19, 34, 0, 0, DateTimeKind.Unspecified), "Cokolada47", 14.75f, 4, 2f },
                    { 46, new DateTime(2021, 2, 6, 20, 43, 0, 0, DateTimeKind.Unspecified), "Maslac46", 31.21f, 3, 41f },
                    { 45, new DateTime(2021, 9, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), "Jaja45", 11.84f, 3, 49f },
                    { 44, new DateTime(2021, 5, 1, 20, 47, 0, 0, DateTimeKind.Unspecified), "Secer44", 22.31f, 2, 25f },
                    { 43, new DateTime(2021, 7, 19, 17, 42, 0, 0, DateTimeKind.Unspecified), "Ulje43", 22.12f, 4, 23f },
                    { 42, new DateTime(2021, 4, 18, 12, 2, 0, 0, DateTimeKind.Unspecified), "Brasno42", 39.32f, 3, 23f }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CreatedDate", "Name", "Price", "UnitMeasure", "UnitQuantity" },
                values: new object[,]
                {
                    { 40, new DateTime(2021, 3, 13, 14, 24, 0, 0, DateTimeKind.Unspecified), "Maslac40", 9.82f, 1, 1f },
                    { 39, new DateTime(2021, 10, 16, 0, 33, 0, 0, DateTimeKind.Unspecified), "Jaja39", 44.41f, 2, 39f },
                    { 38, new DateTime(2021, 2, 12, 9, 43, 0, 0, DateTimeKind.Unspecified), "Secer38", 1.38f, 1, 42f },
                    { 37, new DateTime(2021, 2, 22, 5, 4, 0, 0, DateTimeKind.Unspecified), "Ulje37", 32.74f, 5, 37f },
                    { 41, new DateTime(2021, 4, 16, 9, 49, 0, 0, DateTimeKind.Unspecified), "Cokolada41", 11.95f, 2, 44f },
                    { 48, new DateTime(2021, 1, 19, 7, 18, 0, 0, DateTimeKind.Unspecified), "Brasno48", 10.26f, 1, 25f },
                    { 36, new DateTime(2021, 4, 7, 15, 19, 0, 0, DateTimeKind.Unspecified), "Brasno36", 38.66f, 1, 32f },
                    { 28, new DateTime(2021, 7, 17, 12, 18, 0, 0, DateTimeKind.Unspecified), "Maslac28", 8.9f, 5, 12f },
                    { 29, new DateTime(2021, 6, 8, 0, 6, 0, 0, DateTimeKind.Unspecified), "Cokolada29", 41.74f, 5, 39f },
                    { 30, new DateTime(2021, 9, 26, 22, 17, 0, 0, DateTimeKind.Unspecified), "Brasno30", 18.12f, 1, 19f },
                    { 31, new DateTime(2021, 3, 22, 5, 4, 0, 0, DateTimeKind.Unspecified), "Ulje31", 42.86f, 4, 11f },
                    { 27, new DateTime(2021, 6, 27, 3, 42, 0, 0, DateTimeKind.Unspecified), "Jaja27", 32.92f, 2, 39f },
                    { 33, new DateTime(2021, 3, 10, 21, 35, 0, 0, DateTimeKind.Unspecified), "Jaja33", 13.12f, 3, 6f },
                    { 34, new DateTime(2021, 10, 16, 19, 21, 0, 0, DateTimeKind.Unspecified), "Maslac34", 4.97f, 4, 16f },
                    { 35, new DateTime(2021, 7, 6, 1, 25, 0, 0, DateTimeKind.Unspecified), "Cokolada35", 3.7f, 2, 34f },
                    { 32, new DateTime(2021, 9, 30, 9, 7, 0, 0, DateTimeKind.Unspecified), "Secer32", 29.37f, 3, 35f }
                });

            migrationBuilder.InsertData(
                table: "RecipeCategories",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 64, new DateTime(2021, 9, 24, 1, 34, 0, 0, DateTimeKind.Unspecified), "LgtWitjJ", "Pizza64" },
                    { 72, new DateTime(2021, 3, 26, 5, 11, 0, 0, DateTimeKind.Unspecified), "jecfWcsS", "Pizza72" },
                    { 71, new DateTime(2021, 9, 28, 0, 33, 0, 0, DateTimeKind.Unspecified), "msgSDDak", "Salata71" },
                    { 70, new DateTime(2021, 8, 21, 23, 44, 0, 0, DateTimeKind.Unspecified), "DatbJAtD", "Waffle70" },
                    { 69, new DateTime(2021, 9, 26, 4, 35, 0, 0, DateTimeKind.Unspecified), "BWpilfBd", "Pitta69" },
                    { 68, new DateTime(2021, 3, 21, 9, 22, 0, 0, DateTimeKind.Unspecified), "jSJsBfDr", "Sendvic68" },
                    { 67, new DateTime(2021, 10, 3, 21, 41, 0, 0, DateTimeKind.Unspecified), "LzLHJJJD", "Hamburger67" },
                    { 66, new DateTime(2021, 11, 5, 2, 9, 0, 0, DateTimeKind.Unspecified), "LpstrmAb", "Kolac66" },
                    { 65, new DateTime(2021, 1, 6, 15, 34, 0, 0, DateTimeKind.Unspecified), "fSdldlAM", "Palacinke65" },
                    { 63, new DateTime(2021, 9, 2, 22, 25, 0, 0, DateTimeKind.Unspecified), "owMlsklS", "Salata63" },
                    { 52, new DateTime(2021, 3, 8, 6, 41, 0, 0, DateTimeKind.Unspecified), "IzjSthSr", "Sendvic52" },
                    { 61, new DateTime(2021, 4, 19, 8, 18, 0, 0, DateTimeKind.Unspecified), "jvHsDAeA", "Pitta61" },
                    { 60, new DateTime(2021, 1, 3, 6, 28, 0, 0, DateTimeKind.Unspecified), "pjchhDgf", "Sendvic60" },
                    { 59, new DateTime(2021, 8, 7, 21, 42, 0, 0, DateTimeKind.Unspecified), "SAaheKWa", "Hamburger59" },
                    { 58, new DateTime(2021, 3, 18, 9, 41, 0, 0, DateTimeKind.Unspecified), "hlcnHJWe", "Kolac58" },
                    { 57, new DateTime(2021, 6, 27, 11, 37, 0, 0, DateTimeKind.Unspecified), "nDgAilDr", "Palacinke57" },
                    { 56, new DateTime(2021, 10, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), "rDKShttr", "Pizza56" },
                    { 55, new DateTime(2021, 5, 5, 17, 2, 0, 0, DateTimeKind.Unspecified), "AldtHiDa", "Salata55" },
                    { 54, new DateTime(2021, 10, 28, 17, 8, 0, 0, DateTimeKind.Unspecified), "wDKSWSJm", "Waffle54" },
                    { 53, new DateTime(2021, 7, 12, 6, 11, 0, 0, DateTimeKind.Unspecified), "jJjugAmo", "Pitta53" },
                    { 73, new DateTime(2021, 6, 24, 13, 36, 0, 0, DateTimeKind.Unspecified), "IgSSSWIJ", "Palacinke73" },
                    { 62, new DateTime(2021, 5, 10, 17, 15, 0, 0, DateTimeKind.Unspecified), "ASlvgorW", "Waffle62" },
                    { 74, new DateTime(2021, 9, 19, 12, 51, 0, 0, DateTimeKind.Unspecified), "MWWJDSlp", "Kolac74" },
                    { 98, new DateTime(2021, 3, 4, 16, 15, 0, 0, DateTimeKind.Unspecified), "saBucgIz", "Kolac98" },
                    { 76, new DateTime(2021, 4, 30, 12, 35, 0, 0, DateTimeKind.Unspecified), "WeDgczsS", "Sendvic76" },
                    { 51, new DateTime(2021, 6, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), "buDBLvWH", "Hamburger51" }
                });

            migrationBuilder.InsertData(
                table: "RecipeCategories",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 97, new DateTime(2021, 2, 9, 7, 31, 0, 0, DateTimeKind.Unspecified), "cwcmvcDW", "Palacinke97" },
                    { 96, new DateTime(2021, 4, 2, 19, 54, 0, 0, DateTimeKind.Unspecified), "kWJWJJAA", "Pizza96" },
                    { 95, new DateTime(2021, 4, 14, 12, 45, 0, 0, DateTimeKind.Unspecified), "WkelAJsd", "Salata95" },
                    { 94, new DateTime(2021, 11, 6, 1, 18, 0, 0, DateTimeKind.Unspecified), "eJStApAW", "Waffle94" },
                    { 93, new DateTime(2021, 8, 28, 1, 28, 0, 0, DateTimeKind.Unspecified), "lwsLluWK", "Pitta93" },
                    { 92, new DateTime(2021, 8, 29, 11, 24, 0, 0, DateTimeKind.Unspecified), "JWzMAWWt", "Sendvic92" },
                    { 91, new DateTime(2021, 10, 16, 17, 22, 0, 0, DateTimeKind.Unspecified), "jcKSoWAp", "Hamburger91" },
                    { 90, new DateTime(2021, 7, 19, 2, 59, 0, 0, DateTimeKind.Unspecified), "BaAnJAMJ", "Kolac90" },
                    { 89, new DateTime(2021, 5, 7, 1, 13, 0, 0, DateTimeKind.Unspecified), "KSMSHdIK", "Palacinke89" },
                    { 75, new DateTime(2021, 1, 29, 18, 12, 0, 0, DateTimeKind.Unspecified), "DcjiDWIa", "Hamburger75" },
                    { 88, new DateTime(2021, 5, 20, 16, 38, 0, 0, DateTimeKind.Unspecified), "SAWnodtH", "Pizza88" },
                    { 86, new DateTime(2021, 11, 26, 2, 54, 0, 0, DateTimeKind.Unspecified), "sJhkKhbm", "Waffle86" },
                    { 85, new DateTime(2021, 6, 3, 19, 14, 0, 0, DateTimeKind.Unspecified), "WrvevSWm", "Pitta85" },
                    { 84, new DateTime(2021, 8, 21, 5, 23, 0, 0, DateTimeKind.Unspecified), "MkokBKAM", "Sendvic84" },
                    { 83, new DateTime(2021, 3, 13, 5, 41, 0, 0, DateTimeKind.Unspecified), "uDnpJJes", "Hamburger83" },
                    { 82, new DateTime(2021, 11, 19, 17, 41, 0, 0, DateTimeKind.Unspecified), "vJJWWdik", "Kolac82" },
                    { 81, new DateTime(2021, 5, 4, 7, 44, 0, 0, DateTimeKind.Unspecified), "rJWAAWnM", "Palacinke81" },
                    { 80, new DateTime(2021, 11, 27, 3, 31, 0, 0, DateTimeKind.Unspecified), "pSfAAHWw", "Pizza80" },
                    { 79, new DateTime(2021, 9, 14, 17, 51, 0, 0, DateTimeKind.Unspecified), "ASBKLiJa", "Salata79" },
                    { 78, new DateTime(2021, 9, 15, 14, 58, 0, 0, DateTimeKind.Unspecified), "KtSJLtAs", "Waffle78" },
                    { 77, new DateTime(2021, 1, 4, 1, 23, 0, 0, DateTimeKind.Unspecified), "SSlJbHJK", "Pitta77" },
                    { 87, new DateTime(2021, 2, 8, 5, 21, 0, 0, DateTimeKind.Unspecified), "SMsiutDz", "Salata87" },
                    { 50, new DateTime(2021, 8, 3, 5, 23, 0, 0, DateTimeKind.Unspecified), "AlLpWsJS", "Kolac50" },
                    { 26, new DateTime(2021, 8, 18, 9, 32, 0, 0, DateTimeKind.Unspecified), "WKmHlWJJ", "Kolac26" },
                    { 48, new DateTime(2021, 7, 26, 17, 12, 0, 0, DateTimeKind.Unspecified), "JBAfWiAv", "Pizza48" },
                    { 20, new DateTime(2021, 9, 8, 7, 23, 0, 0, DateTimeKind.Unspecified), "sADukDBt", "Sendvic20" },
                    { 19, new DateTime(2021, 5, 22, 9, 55, 0, 0, DateTimeKind.Unspecified), "SAujsBDA", "Hamburger19" },
                    { 18, new DateTime(2021, 6, 3, 21, 23, 0, 0, DateTimeKind.Unspecified), "aDmvoJHJ", "Kolac18" },
                    { 17, new DateTime(2021, 7, 30, 4, 22, 0, 0, DateTimeKind.Unspecified), "eJzsJwSD", "Palacinke17" },
                    { 16, new DateTime(2021, 9, 12, 21, 40, 0, 0, DateTimeKind.Unspecified), "DljKnbvr", "Pizza16" },
                    { 15, new DateTime(2021, 2, 5, 4, 44, 0, 0, DateTimeKind.Unspecified), "pJnorAmt", "Salata15" },
                    { 14, new DateTime(2021, 3, 18, 23, 57, 0, 0, DateTimeKind.Unspecified), "vlJASJSK", "Waffle14" },
                    { 13, new DateTime(2021, 11, 27, 3, 37, 0, 0, DateTimeKind.Unspecified), "sAmDSuoI", "Pitta13" },
                    { 12, new DateTime(2021, 2, 22, 7, 28, 0, 0, DateTimeKind.Unspecified), "sscAeSSA", "Sendvic12" },
                    { 11, new DateTime(2021, 7, 26, 13, 42, 0, 0, DateTimeKind.Unspecified), "DorWHiKw", "Hamburger11" },
                    { 10, new DateTime(2021, 3, 11, 1, 10, 0, 0, DateTimeKind.Unspecified), "WMIIiDaW", "Kolac10" },
                    { 9, new DateTime(2021, 9, 12, 6, 49, 0, 0, DateTimeKind.Unspecified), "KKSKkpJA", "Palacinke9" },
                    { 8, new DateTime(2021, 1, 28, 9, 13, 0, 0, DateTimeKind.Unspecified), "BpAnDHiA", "Pizza8" },
                    { 7, new DateTime(2021, 5, 11, 18, 39, 0, 0, DateTimeKind.Unspecified), "giJAWJBJ", "Salata7" },
                    { 6, new DateTime(2021, 11, 2, 19, 12, 0, 0, DateTimeKind.Unspecified), "WBSIosWA", "Waffle6" },
                    { 5, new DateTime(2021, 8, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), "fMrDbDAv", "Pitta5" },
                    { 4, new DateTime(2021, 11, 2, 1, 1, 0, 0, DateTimeKind.Unspecified), "WWIwLvbK", "Sendvic4" }
                });

            migrationBuilder.InsertData(
                table: "RecipeCategories",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 3, new DateTime(2021, 10, 5, 4, 11, 0, 0, DateTimeKind.Unspecified), "dMrurIIo", "Hamburger3" },
                    { 2, new DateTime(2021, 10, 25, 11, 34, 0, 0, DateTimeKind.Unspecified), "rWrLwBMW", "Kolac2" },
                    { 1, new DateTime(2021, 10, 1, 11, 35, 0, 0, DateTimeKind.Unspecified), "WsWslthb", "Palacinke1" },
                    { 99, new DateTime(2021, 7, 8, 17, 23, 0, 0, DateTimeKind.Unspecified), "mHoHWSJw", "Hamburger99" },
                    { 21, new DateTime(2021, 3, 13, 18, 32, 0, 0, DateTimeKind.Unspecified), "SKWSpmIL", "Pitta21" },
                    { 22, new DateTime(2021, 11, 28, 19, 13, 0, 0, DateTimeKind.Unspecified), "AAoIlSef", "Waffle22" },
                    { 23, new DateTime(2021, 4, 30, 23, 56, 0, 0, DateTimeKind.Unspecified), "DDbWSkWB", "Salata23" },
                    { 24, new DateTime(2021, 7, 20, 18, 29, 0, 0, DateTimeKind.Unspecified), "oKDASKtw", "Pizza24" },
                    { 47, new DateTime(2021, 4, 17, 1, 47, 0, 0, DateTimeKind.Unspecified), "SWrmiSck", "Salata47" },
                    { 46, new DateTime(2021, 3, 29, 23, 47, 0, 0, DateTimeKind.Unspecified), "DJpJvWdv", "Waffle46" },
                    { 45, new DateTime(2021, 10, 4, 0, 38, 0, 0, DateTimeKind.Unspecified), "AAHIwmmS", "Pitta45" },
                    { 44, new DateTime(2021, 7, 14, 8, 57, 0, 0, DateTimeKind.Unspecified), "zfIhpiWA", "Sendvic44" },
                    { 43, new DateTime(2021, 11, 25, 17, 50, 0, 0, DateTimeKind.Unspecified), "bKSskMDb", "Hamburger43" },
                    { 42, new DateTime(2021, 10, 12, 5, 56, 0, 0, DateTimeKind.Unspecified), "WfJglShW", "Kolac42" },
                    { 41, new DateTime(2021, 8, 10, 13, 10, 0, 0, DateTimeKind.Unspecified), "gWDokWrb", "Palacinke41" },
                    { 40, new DateTime(2021, 7, 31, 21, 3, 0, 0, DateTimeKind.Unspecified), "mWDsagjm", "Pizza40" },
                    { 39, new DateTime(2021, 11, 8, 7, 46, 0, 0, DateTimeKind.Unspecified), "pLAMJpAp", "Salata39" },
                    { 38, new DateTime(2021, 5, 6, 23, 10, 0, 0, DateTimeKind.Unspecified), "DWgIvcKw", "Waffle38" },
                    { 49, new DateTime(2021, 9, 19, 19, 42, 0, 0, DateTimeKind.Unspecified), "zbStispK", "Palacinke49" },
                    { 37, new DateTime(2021, 11, 13, 21, 6, 0, 0, DateTimeKind.Unspecified), "ssvdSJBW", "Pitta37" },
                    { 35, new DateTime(2021, 5, 21, 19, 21, 0, 0, DateTimeKind.Unspecified), "AhIJSsJK", "Hamburger35" },
                    { 34, new DateTime(2021, 9, 8, 18, 15, 0, 0, DateTimeKind.Unspecified), "vSrAHSHo", "Kolac34" },
                    { 33, new DateTime(2021, 4, 19, 9, 47, 0, 0, DateTimeKind.Unspecified), "HJsvWmtv", "Palacinke33" },
                    { 32, new DateTime(2021, 8, 19, 11, 32, 0, 0, DateTimeKind.Unspecified), "gWgAcBkJ", "Pizza32" },
                    { 31, new DateTime(2021, 3, 5, 9, 35, 0, 0, DateTimeKind.Unspecified), "SteBJJDl", "Salata31" },
                    { 30, new DateTime(2021, 11, 17, 5, 15, 0, 0, DateTimeKind.Unspecified), "nKeeSopA", "Waffle30" },
                    { 29, new DateTime(2021, 4, 25, 10, 47, 0, 0, DateTimeKind.Unspecified), "pSStlsaA", "Pitta29" },
                    { 28, new DateTime(2021, 1, 2, 1, 23, 0, 0, DateTimeKind.Unspecified), "DlHJmAJt", "Sendvic28" },
                    { 27, new DateTime(2021, 7, 17, 10, 54, 0, 0, DateTimeKind.Unspecified), "KvSJAKJJ", "Hamburger27" },
                    { 25, new DateTime(2021, 3, 28, 3, 19, 0, 0, DateTimeKind.Unspecified), "DAWSeAow", "Palacinke25" },
                    { 36, new DateTime(2021, 5, 15, 4, 59, 0, 0, DateTimeKind.Unspecified), "LWlmkhSS", "Sendvic36" },
                    { 100, new DateTime(2021, 10, 27, 22, 29, 0, 0, DateTimeKind.Unspecified), "gtSJAMSk", "Sendvic100" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedDate", "Description", "MyUserId", "Name", "RecipeCategoryId", "TotalCost" },
                values: new object[,]
                {
                    { 60, new DateTime(2021, 2, 7, 21, 7, 0, 0, DateTimeKind.Unspecified), "IaArAuDn", 1, "Palacinke sa nutelom60", 1, 47.275448f },
                    { 14, new DateTime(2021, 6, 27, 3, 55, 0, 0, DateTimeKind.Unspecified), "nIWApKdD", 1, "Cokoladni kolac14", 35, 28.6681f },
                    { 33, new DateTime(2021, 10, 28, 13, 55, 0, 0, DateTimeKind.Unspecified), "DJSkKAJr", 1, "Rafaelo33", 34, 74.0775f },
                    { 26, new DateTime(2021, 8, 3, 15, 28, 0, 0, DateTimeKind.Unspecified), "vmfWmWDW", 1, "Snickers26", 34, 81.20821f },
                    { 9, new DateTime(2021, 10, 5, 1, 52, 0, 0, DateTimeKind.Unspecified), "alzJJJob", 1, "Rafaelo9", 34, 19.272299f },
                    { 80, new DateTime(2021, 11, 5, 14, 14, 0, 0, DateTimeKind.Unspecified), "azhzAscd", 1, "Pizza sa sirom 80", 33, 91.84053f },
                    { 45, new DateTime(2021, 4, 17, 18, 37, 0, 0, DateTimeKind.Unspecified), "ccJaDWla", 1, "Saher torta45", 33, 32.42224f },
                    { 30, new DateTime(2021, 6, 5, 21, 47, 0, 0, DateTimeKind.Unspecified), "JApdzeWS", 1, "Cokoladni kolac30", 33, 52.792435f },
                    { 21, new DateTime(2021, 1, 9, 6, 39, 0, 0, DateTimeKind.Unspecified), "gaSWAiSM", 1, "Saher torta21", 33, 4.8133245f },
                    { 7, new DateTime(2021, 10, 29, 22, 2, 0, 0, DateTimeKind.Unspecified), "sKScwWWh", 1, "Ferrero7", 33, 3.3758886f },
                    { 82, new DateTime(2021, 10, 5, 13, 29, 0, 0, DateTimeKind.Unspecified), "cJfKeeDp", 1, "Snickers82", 30, 19.605173f },
                    { 78, new DateTime(2021, 7, 29, 2, 5, 0, 0, DateTimeKind.Unspecified), "dLLtolsA", 1, "Cokoladni kolac78", 30, 39.46612f },
                    { 39, new DateTime(2021, 9, 9, 13, 20, 0, 0, DateTimeKind.Unspecified), "vJADILdt", 1, "Ferrero39", 30, 78.316895f },
                    { 22, new DateTime(2021, 10, 22, 6, 10, 0, 0, DateTimeKind.Unspecified), "DwLWAwpS", 1, "Cokoladni kolac22", 29, 52.888237f },
                    { 11, new DateTime(2021, 3, 13, 9, 43, 0, 0, DateTimeKind.Unspecified), "oSHLdlde", 1, "Baklava11", 29, 30.764618f },
                    { 5, new DateTime(2021, 9, 10, 12, 36, 0, 0, DateTimeKind.Unspecified), "drknWWjI", 1, "Saher torta5", 29, 65.43908f },
                    { 16, new DateTime(2021, 3, 20, 4, 44, 0, 0, DateTimeKind.Unspecified), "hsiADAWW", 1, "Pizza sa sirom 16", 28, 48.511936f },
                    { 73, new DateTime(2021, 1, 14, 1, 54, 0, 0, DateTimeKind.Unspecified), "aAmASWkW", 1, "Rafaelo73", 27, 93.63545f },
                    { 66, new DateTime(2021, 11, 28, 15, 28, 0, 0, DateTimeKind.Unspecified), "pwAWMbsu", 1, "Snickers66", 27, 55.940903f },
                    { 24, new DateTime(2021, 7, 8, 12, 24, 0, 0, DateTimeKind.Unspecified), "vWsiiJAI", 1, "Pizza sa sirom 24", 27, 86.59361f },
                    { 81, new DateTime(2021, 4, 3, 18, 50, 0, 0, DateTimeKind.Unspecified), "JWzAnWAs", 1, "Rafaelo81", 26, 85.10347f },
                    { 23, new DateTime(2021, 9, 26, 2, 49, 0, 0, DateTimeKind.Unspecified), "DkSSrKWb", 1, "Ferrero23", 26, 72.87301f },
                    { 4, new DateTime(2021, 11, 12, 19, 10, 0, 0, DateTimeKind.Unspecified), "WKgbvJoK", 1, "Palacinke sa nutelom4", 36, 41.31568f },
                    { 29, new DateTime(2021, 7, 26, 2, 39, 0, 0, DateTimeKind.Unspecified), "KbgJsAwv", 1, "Saher torta29", 25, 40.379055f },
                    { 42, new DateTime(2021, 3, 22, 5, 12, 0, 0, DateTimeKind.Unspecified), "nssdHLWz", 1, "Snickers42", 36, 31.929562f },
                    { 98, new DateTime(2021, 6, 4, 10, 55, 0, 0, DateTimeKind.Unspecified), "bhWouJDB", 1, "Snickers98", 36, 85.08068f },
                    { 88, new DateTime(2021, 11, 5, 1, 16, 0, 0, DateTimeKind.Unspecified), "wADhkJAo", 1, "Pizza sa sirom 88", 47, 51.241947f },
                    { 34, new DateTime(2021, 7, 30, 7, 26, 0, 0, DateTimeKind.Unspecified), "fJmcDsgl", 1, "Snickers34", 47, 36.266457f },
                    { 12, new DateTime(2021, 8, 29, 20, 55, 0, 0, DateTimeKind.Unspecified), "ScKWrwwS", 1, "Palacinke sa nutelom12", 47, 72.361824f },
                    { 64, new DateTime(2021, 5, 2, 4, 4, 0, 0, DateTimeKind.Unspecified), "cWWpLizk", 1, "Pizza sa sirom 64", 46, 6.2014413f },
                    { 90, new DateTime(2021, 6, 11, 20, 28, 0, 0, DateTimeKind.Unspecified), "ASHJmcbt", 1, "Snickers90", 45, 14.060277f },
                    { 63, new DateTime(2021, 2, 5, 15, 19, 0, 0, DateTimeKind.Unspecified), "cbSlHKlA", 1, "Ferrero63", 45, 19.500683f },
                    { 44, new DateTime(2021, 3, 1, 0, 44, 0, 0, DateTimeKind.Unspecified), "wiJAKisc", 1, "Palacinke sa nutelom44", 45, 46.54805f },
                    { 62, new DateTime(2021, 10, 14, 14, 27, 0, 0, DateTimeKind.Unspecified), "BIvsAvlh", 1, "Cokoladni kolac62", 44, 58.658585f },
                    { 3, new DateTime(2021, 11, 12, 14, 33, 0, 0, DateTimeKind.Unspecified), "IzvWWcnr", 1, "Baklava3", 44, 86.34001f },
                    { 31, new DateTime(2021, 6, 9, 13, 56, 0, 0, DateTimeKind.Unspecified), "twWDDSSD", 1, "Ferrero31", 43, 64.02801f },
                    { 70, new DateTime(2021, 9, 17, 3, 37, 0, 0, DateTimeKind.Unspecified), "HiMiMJIb", 1, "Cokoladni kolac70", 41, 97.0135f },
                    { 69, new DateTime(2021, 5, 4, 15, 57, 0, 0, DateTimeKind.Unspecified), "sjjwieWK", 1, "Saher torta69", 41, 81.46624f },
                    { 35, new DateTime(2021, 2, 23, 11, 58, 0, 0, DateTimeKind.Unspecified), "MsglAhWc", 1, "Baklava35", 41, 99.61236f },
                    { 20, new DateTime(2021, 7, 23, 8, 46, 0, 0, DateTimeKind.Unspecified), "zDBJkSJK", 1, "Palacinke sa nutelom20", 41, 40.54107f },
                    { 89, new DateTime(2021, 10, 16, 7, 56, 0, 0, DateTimeKind.Unspecified), "JuSpwaDt", 1, "Rafaelo89", 40, 61.38343f },
                    { 85, new DateTime(2021, 1, 4, 11, 47, 0, 0, DateTimeKind.Unspecified), "IWJAWHHA", 1, "Saher torta85", 40, 23.90871f }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedDate", "Description", "MyUserId", "Name", "RecipeCategoryId", "TotalCost" },
                values: new object[,]
                {
                    { 83, new DateTime(2021, 10, 7, 20, 49, 0, 0, DateTimeKind.Unspecified), "biBoaDoS", 1, "Baklava83", 39, 57.084194f },
                    { 40, new DateTime(2021, 8, 7, 7, 28, 0, 0, DateTimeKind.Unspecified), "SKaDkSKv", 1, "Pizza sa sirom 40", 39, 79.53849f },
                    { 25, new DateTime(2021, 4, 2, 0, 22, 0, 0, DateTimeKind.Unspecified), "sSfzwisW", 1, "Rafaelo25", 39, 40.446697f },
                    { 50, new DateTime(2021, 3, 30, 8, 32, 0, 0, DateTimeKind.Unspecified), "ksAoSHDA", 1, "Snickers50", 37, 29.978544f },
                    { 19, new DateTime(2021, 4, 10, 10, 40, 0, 0, DateTimeKind.Unspecified), "Wmifeeno", 1, "Baklava19", 37, 28.845299f },
                    { 75, new DateTime(2021, 4, 30, 16, 14, 0, 0, DateTimeKind.Unspecified), "BlciWSwI", 1, "Baklava75", 36, 64.855316f },
                    { 87, new DateTime(2021, 11, 3, 11, 51, 0, 0, DateTimeKind.Unspecified), "MLvASJdK", 1, "Ferrero87", 24, 31.779764f },
                    { 57, new DateTime(2021, 10, 17, 20, 15, 0, 0, DateTimeKind.Unspecified), "bzKAprAt", 1, "Rafaelo57", 24, 68.22477f },
                    { 56, new DateTime(2021, 8, 12, 15, 30, 0, 0, DateTimeKind.Unspecified), "WShJazhJ", 1, "Pizza sa sirom 56", 24, 76.09614f },
                    { 95, new DateTime(2021, 9, 17, 6, 41, 0, 0, DateTimeKind.Unspecified), "shWJAuWb", 1, "Ferrero95", 8, 95.59672f },
                    { 6, new DateTime(2021, 1, 18, 6, 29, 0, 0, DateTimeKind.Unspecified), "oJWoAuni", 1, "Cokoladni kolac6", 8, 59.029125f },
                    { 43, new DateTime(2021, 10, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), "KztAIMaa", 1, "Baklava43", 7, 54.709515f },
                    { 18, new DateTime(2021, 9, 22, 15, 15, 0, 0, DateTimeKind.Unspecified), "DdDmskKW", 1, "Snickers18", 7, 16.889505f },
                    { 1, new DateTime(2021, 7, 5, 21, 40, 0, 0, DateTimeKind.Unspecified), "jKrbmstK", 1, "Rafaelo1", 7, 32.514862f },
                    { 84, new DateTime(2021, 4, 28, 18, 6, 0, 0, DateTimeKind.Unspecified), "ifuSSJnA", 1, "Palacinke sa nutelom84", 6, 12.455657f },
                    { 79, new DateTime(2021, 3, 23, 17, 47, 0, 0, DateTimeKind.Unspecified), "prKKhaKc", 1, "Ferrero79", 6, 55.650475f },
                    { 77, new DateTime(2021, 1, 19, 15, 10, 0, 0, DateTimeKind.Unspecified), "WJiutejh", 1, "Saher torta77", 6, 87.803055f },
                    { 36, new DateTime(2021, 2, 16, 18, 29, 0, 0, DateTimeKind.Unspecified), "kKwIKWzI", 1, "Palacinke sa nutelom36", 6, 47.9758f },
                    { 93, new DateTime(2021, 8, 11, 19, 44, 0, 0, DateTimeKind.Unspecified), "JzSDLJzJ", 1, "Saher torta93", 5, 65.701706f },
                    { 55, new DateTime(2021, 9, 11, 23, 30, 0, 0, DateTimeKind.Unspecified), "ScibfWrr", 1, "Ferrero55", 5, 11.372749f },
                    { 41, new DateTime(2021, 3, 25, 16, 32, 0, 0, DateTimeKind.Unspecified), "jzjbIvSs", 1, "Rafaelo41", 5, 51.73164f },
                    { 100, new DateTime(2021, 4, 18, 3, 9, 0, 0, DateTimeKind.Unspecified), "wJDWbLJe", 1, "Palacinke sa nutelom100", 3, 66.84396f },
                    { 51, new DateTime(2021, 6, 2, 9, 59, 0, 0, DateTimeKind.Unspecified), "sSraKHWs", 1, "Baklava51", 3, 40.011814f },
                    { 10, new DateTime(2021, 7, 19, 16, 55, 0, 0, DateTimeKind.Unspecified), "mJHLdWuj", 1, "Snickers10", 3, 88.89675f },
                    { 2, new DateTime(2021, 8, 14, 23, 5, 0, 0, DateTimeKind.Unspecified), "WoWAkSbe", 1, "Snickers2", 3, 94.2741f },
                    { 71, new DateTime(2021, 8, 23, 22, 53, 0, 0, DateTimeKind.Unspecified), "goBAJBSI", 1, "Ferrero71", 2, 2.8935733f },
                    { 48, new DateTime(2021, 4, 23, 16, 12, 0, 0, DateTimeKind.Unspecified), "ziBSHzWe", 1, "Pizza sa sirom 48", 2, 24.050907f },
                    { 94, new DateTime(2021, 8, 2, 16, 12, 0, 0, DateTimeKind.Unspecified), "pcjDdiAz", 1, "Cokoladni kolac94", 1, 27.02063f },
                    { 74, new DateTime(2021, 8, 2, 3, 11, 0, 0, DateTimeKind.Unspecified), "SDmvzzae", 1, "Snickers74", 1, 60.024628f },
                    { 68, new DateTime(2021, 7, 2, 13, 59, 0, 0, DateTimeKind.Unspecified), "Ssnishss", 1, "Palacinke sa nutelom68", 1, 25.067883f },
                    { 17, new DateTime(2021, 9, 16, 19, 3, 0, 0, DateTimeKind.Unspecified), "gAmMWAlM", 1, "Rafaelo17", 9, 75.05107f },
                    { 99, new DateTime(2021, 1, 19, 21, 45, 0, 0, DateTimeKind.Unspecified), "tDLWBJik", 1, "Baklava99", 9, 97.30132f },
                    { 58, new DateTime(2021, 5, 8, 2, 9, 0, 0, DateTimeKind.Unspecified), "JJoAeDWg", 1, "Snickers58", 11, 94.65673f },
                    { 86, new DateTime(2021, 3, 31, 10, 23, 0, 0, DateTimeKind.Unspecified), "SfSmMISA", 1, "Cokoladni kolac86", 11, 36.686058f },
                    { 38, new DateTime(2021, 4, 26, 14, 32, 0, 0, DateTimeKind.Unspecified), "AJwSsKDc", 1, "Cokoladni kolac38", 24, 6.4329305f },
                    { 76, new DateTime(2021, 9, 18, 1, 27, 0, 0, DateTimeKind.Unspecified), "KufLSDKs", 1, "Palacinke sa nutelom76", 23, 3.201968f },
                    { 61, new DateTime(2021, 10, 19, 0, 47, 0, 0, DateTimeKind.Unspecified), "WScpKhso", 1, "Saher torta61", 23, 67.9297f },
                    { 49, new DateTime(2021, 3, 9, 10, 45, 0, 0, DateTimeKind.Unspecified), "aoaWeDLW", 1, "Rafaelo49", 23, 10.25192f },
                    { 72, new DateTime(2021, 5, 24, 4, 30, 0, 0, DateTimeKind.Unspecified), "tpzfajji", 1, "Pizza sa sirom 72", 22, 3.4604354f },
                    { 28, new DateTime(2021, 1, 16, 7, 35, 0, 0, DateTimeKind.Unspecified), "pAjDSHJt", 1, "Palacinke sa nutelom28", 22, 80.728935f },
                    { 96, new DateTime(2021, 5, 10, 2, 4, 0, 0, DateTimeKind.Unspecified), "DAWWaklD", 1, "Pizza sa sirom 96", 20, 14.272219f },
                    { 54, new DateTime(2021, 11, 21, 12, 39, 0, 0, DateTimeKind.Unspecified), "ASDdKpSW", 1, "Cokoladni kolac54", 19, 25.181711f }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedDate", "Description", "MyUserId", "Name", "RecipeCategoryId", "TotalCost" },
                values: new object[,]
                {
                    { 27, new DateTime(2021, 2, 28, 5, 42, 0, 0, DateTimeKind.Unspecified), "kDbDDJvK", 1, "Baklava27", 19, 24.408726f },
                    { 52, new DateTime(2021, 3, 12, 3, 33, 0, 0, DateTimeKind.Unspecified), "ssKvzDrA", 1, "Palacinke sa nutelom52", 18, 75.360245f },
                    { 13, new DateTime(2021, 3, 2, 21, 25, 0, 0, DateTimeKind.Unspecified), "DinAWtvW", 1, "Saher torta13", 49, 27.941961f },
                    { 59, new DateTime(2021, 8, 13, 18, 48, 0, 0, DateTimeKind.Unspecified), "IWWuuptS", 1, "Baklava59", 17, 73.23608f },
                    { 97, new DateTime(2021, 2, 14, 13, 52, 0, 0, DateTimeKind.Unspecified), "rKnSuDDB", 1, "Rafaelo97", 16, 27.391125f },
                    { 47, new DateTime(2021, 5, 2, 20, 37, 0, 0, DateTimeKind.Unspecified), "iKvWzAWo", 1, "Ferrero47", 16, 81.81866f },
                    { 92, new DateTime(2021, 2, 18, 3, 41, 0, 0, DateTimeKind.Unspecified), "SAaogDwJ", 1, "Palacinke sa nutelom92", 15, 28.201704f },
                    { 65, new DateTime(2021, 2, 10, 2, 58, 0, 0, DateTimeKind.Unspecified), "ialhwntH", 1, "Rafaelo65", 15, 12.45434f },
                    { 91, new DateTime(2021, 3, 30, 22, 13, 0, 0, DateTimeKind.Unspecified), "isbfrDJd", 1, "Baklava91", 14, 58.30929f },
                    { 32, new DateTime(2021, 3, 13, 18, 15, 0, 0, DateTimeKind.Unspecified), "uKfWDSdK", 1, "Pizza sa sirom 32", 14, 86.157814f },
                    { 15, new DateTime(2021, 11, 2, 22, 6, 0, 0, DateTimeKind.Unspecified), "WlutHoSK", 1, "Ferrero15", 14, 4.339546f },
                    { 8, new DateTime(2021, 8, 30, 17, 59, 0, 0, DateTimeKind.Unspecified), "AazArrhW", 1, "Pizza sa sirom 8", 14, 52.683975f },
                    { 67, new DateTime(2021, 9, 30, 6, 59, 0, 0, DateTimeKind.Unspecified), "KrnMDsJM", 1, "Baklava67", 13, 97.12939f },
                    { 53, new DateTime(2021, 4, 8, 6, 24, 0, 0, DateTimeKind.Unspecified), "JhrjDebW", 1, "Saher torta53", 12, 92.35779f },
                    { 46, new DateTime(2021, 4, 25, 10, 7, 0, 0, DateTimeKind.Unspecified), "ADmrwDAf", 1, "Cokoladni kolac46", 17, 2.4153311f },
                    { 37, new DateTime(2021, 6, 25, 5, 50, 0, 0, DateTimeKind.Unspecified), "ABBAnKiW", 1, "Saher torta37", 49, 98.532364f }
                });

            migrationBuilder.InsertData(
                table: "IngredientRecipes",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 71, new DateTime(2021, 2, 26, 22, 3, 0, 0, DateTimeKind.Unspecified), 47, 0f, 40.97f, 60, 4 },
                    { 84, new DateTime(2021, 2, 10, 1, 7, 0, 0, DateTimeKind.Unspecified), 9, 0f, 12.25f, 33, 2 },
                    { 25, new DateTime(2021, 6, 20, 5, 23, 0, 0, DateTimeKind.Unspecified), 70, 0f, 30.25f, 33, 5 },
                    { 68, new DateTime(2021, 3, 12, 17, 43, 0, 0, DateTimeKind.Unspecified), 81, 0f, 39.38f, 26, 2 },
                    { 99, new DateTime(2021, 7, 3, 23, 24, 0, 0, DateTimeKind.Unspecified), 81, 0f, 27.72f, 9, 2 },
                    { 79, new DateTime(2021, 1, 5, 23, 21, 0, 0, DateTimeKind.Unspecified), 21, 0f, 11.55f, 21, 3 },
                    { 59, new DateTime(2021, 10, 30, 1, 44, 0, 0, DateTimeKind.Unspecified), 62, 0f, 16.61f, 21, 3 },
                    { 12, new DateTime(2021, 3, 22, 18, 10, 0, 0, DateTimeKind.Unspecified), 32, 0f, 30.15f, 7, 3 },
                    { 41, new DateTime(2021, 2, 2, 8, 44, 0, 0, DateTimeKind.Unspecified), 17, 0f, 10.88f, 82, 4 },
                    { 33, new DateTime(2021, 7, 10, 4, 19, 0, 0, DateTimeKind.Unspecified), 87, 0f, 7.19f, 39, 3 },
                    { 21, new DateTime(2021, 1, 26, 3, 36, 0, 0, DateTimeKind.Unspecified), 5, 0f, 36.06f, 39, 2 },
                    { 43, new DateTime(2021, 4, 14, 4, 51, 0, 0, DateTimeKind.Unspecified), 73, 0f, 41.69f, 11, 2 },
                    { 75, new DateTime(2021, 9, 8, 7, 51, 0, 0, DateTimeKind.Unspecified), 57, 0f, 40.19f, 5, 1 },
                    { 11, new DateTime(2021, 7, 25, 0, 19, 0, 0, DateTimeKind.Unspecified), 17, 0f, 18.11f, 16, 1 },
                    { 13, new DateTime(2021, 2, 15, 8, 21, 0, 0, DateTimeKind.Unspecified), 29, 0f, 10.62f, 73, 2 },
                    { 19, new DateTime(2021, 4, 28, 16, 16, 0, 0, DateTimeKind.Unspecified), 19, 0f, 40.64f, 66, 1 },
                    { 78, new DateTime(2021, 9, 21, 20, 10, 0, 0, DateTimeKind.Unspecified), 2, 0f, 36.97f, 24, 2 },
                    { 58, new DateTime(2021, 1, 28, 4, 45, 0, 0, DateTimeKind.Unspecified), 37, 0f, 39.34f, 81, 2 },
                    { 28, new DateTime(2021, 5, 12, 9, 41, 0, 0, DateTimeKind.Unspecified), 18, 0f, 42.86f, 29, 3 },
                    { 22, new DateTime(2021, 10, 24, 5, 43, 0, 0, DateTimeKind.Unspecified), 70, 0f, 31.23f, 87, 4 },
                    { 89, new DateTime(2021, 8, 13, 15, 5, 0, 0, DateTimeKind.Unspecified), 40, 0f, 6.3f, 57, 1 },
                    { 49, new DateTime(2021, 9, 26, 13, 55, 0, 0, DateTimeKind.Unspecified), 10, 0f, 44.74f, 57, 2 },
                    { 61, new DateTime(2021, 3, 30, 20, 42, 0, 0, DateTimeKind.Unspecified), 80, 0f, 48.45f, 14, 3 },
                    { 56, new DateTime(2021, 7, 29, 21, 23, 0, 0, DateTimeKind.Unspecified), 95, 0f, 32.36f, 38, 1 },
                    { 82, new DateTime(2021, 10, 5, 17, 36, 0, 0, DateTimeKind.Unspecified), 66, 0f, 31.62f, 4, 4 },
                    { 18, new DateTime(2021, 9, 7, 21, 12, 0, 0, DateTimeKind.Unspecified), 55, 0f, 17.53f, 42, 3 },
                    { 5, new DateTime(2021, 7, 5, 9, 38, 0, 0, DateTimeKind.Unspecified), 65, 0f, 36.16f, 88, 4 },
                    { 17, new DateTime(2021, 1, 7, 17, 37, 0, 0, DateTimeKind.Unspecified), 89, 0f, 46.97f, 34, 4 },
                    { 50, new DateTime(2021, 9, 3, 19, 23, 0, 0, DateTimeKind.Unspecified), 88, 0f, 26.53f, 12, 5 },
                    { 55, new DateTime(2021, 3, 23, 23, 32, 0, 0, DateTimeKind.Unspecified), 36, 0f, 30.02f, 64, 5 },
                    { 54, new DateTime(2021, 3, 10, 5, 9, 0, 0, DateTimeKind.Unspecified), 97, 0f, 5.54f, 44, 2 },
                    { 30, new DateTime(2021, 11, 19, 14, 9, 0, 0, DateTimeKind.Unspecified), 69, 0f, 1.12f, 44, 1 },
                    { 69, new DateTime(2021, 4, 24, 17, 25, 0, 0, DateTimeKind.Unspecified), 10, 0f, 12.3f, 62, 2 },
                    { 97, new DateTime(2021, 6, 10, 1, 56, 0, 0, DateTimeKind.Unspecified), 90, 0f, 42.78f, 3, 5 },
                    { 62, new DateTime(2021, 9, 15, 15, 57, 0, 0, DateTimeKind.Unspecified), 19, 0f, 14.55f, 31, 2 },
                    { 27, new DateTime(2021, 9, 10, 8, 46, 0, 0, DateTimeKind.Unspecified), 55, 0f, 30.97f, 70, 3 },
                    { 77, new DateTime(2021, 7, 13, 0, 51, 0, 0, DateTimeKind.Unspecified), 94, 0f, 6.98f, 69, 3 },
                    { 32, new DateTime(2021, 7, 16, 4, 15, 0, 0, DateTimeKind.Unspecified), 44, 0f, 23.65f, 69, 1 },
                    { 16, new DateTime(2021, 1, 14, 11, 17, 0, 0, DateTimeKind.Unspecified), 79, 0f, 6.12f, 69, 1 },
                    { 91, new DateTime(2021, 4, 19, 11, 37, 0, 0, DateTimeKind.Unspecified), 66, 0f, 44.88f, 35, 4 },
                    { 74, new DateTime(2021, 5, 4, 9, 58, 0, 0, DateTimeKind.Unspecified), 46, 0f, 33.09f, 20, 5 },
                    { 4, new DateTime(2021, 5, 21, 7, 8, 0, 0, DateTimeKind.Unspecified), 24, 0f, 48.68f, 85, 2 }
                });

            migrationBuilder.InsertData(
                table: "IngredientRecipes",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 86, new DateTime(2021, 3, 30, 18, 55, 0, 0, DateTimeKind.Unspecified), 36, 0f, 13.32f, 83, 3 },
                    { 24, new DateTime(2021, 10, 21, 19, 29, 0, 0, DateTimeKind.Unspecified), 37, 0f, 12.94f, 83, 4 },
                    { 95, new DateTime(2021, 8, 26, 9, 36, 0, 0, DateTimeKind.Unspecified), 38, 0f, 15.42f, 40, 5 },
                    { 83, new DateTime(2021, 7, 14, 19, 45, 0, 0, DateTimeKind.Unspecified), 60, 0f, 20.76f, 98, 2 },
                    { 76, new DateTime(2021, 9, 24, 18, 58, 0, 0, DateTimeKind.Unspecified), 96, 0f, 22.22f, 98, 3 },
                    { 88, new DateTime(2021, 5, 2, 23, 10, 0, 0, DateTimeKind.Unspecified), 92, 0f, 35.93f, 4, 3 },
                    { 14, new DateTime(2021, 9, 6, 4, 33, 0, 0, DateTimeKind.Unspecified), 5, 0f, 7.14f, 88, 2 },
                    { 47, new DateTime(2021, 1, 3, 19, 19, 0, 0, DateTimeKind.Unspecified), 66, 0f, 37.75f, 61, 2 },
                    { 29, new DateTime(2021, 10, 13, 20, 30, 0, 0, DateTimeKind.Unspecified), 92, 0f, 6.89f, 72, 4 },
                    { 10, new DateTime(2021, 11, 22, 22, 2, 0, 0, DateTimeKind.Unspecified), 19, 0f, 42.13f, 43, 2 },
                    { 100, new DateTime(2021, 10, 8, 0, 3, 0, 0, DateTimeKind.Unspecified), 11, 0f, 21.72f, 18, 2 },
                    { 85, new DateTime(2021, 7, 20, 5, 42, 0, 0, DateTimeKind.Unspecified), 74, 0f, 35.9f, 18, 1 },
                    { 48, new DateTime(2021, 11, 3, 15, 10, 0, 0, DateTimeKind.Unspecified), 28, 0f, 41.4f, 1, 4 },
                    { 92, new DateTime(2021, 9, 19, 8, 28, 0, 0, DateTimeKind.Unspecified), 95, 0f, 6.15f, 84, 1 },
                    { 40, new DateTime(2021, 11, 23, 6, 18, 0, 0, DateTimeKind.Unspecified), 79, 0f, 46.96f, 84, 3 },
                    { 39, new DateTime(2021, 9, 22, 8, 28, 0, 0, DateTimeKind.Unspecified), 71, 0f, 10.61f, 84, 5 },
                    { 20, new DateTime(2021, 10, 10, 16, 35, 0, 0, DateTimeKind.Unspecified), 98, 0f, 12.51f, 84, 2 },
                    { 3, new DateTime(2021, 11, 18, 0, 15, 0, 0, DateTimeKind.Unspecified), 49, 0f, 49.09f, 79, 2 },
                    { 96, new DateTime(2021, 4, 17, 16, 46, 0, 0, DateTimeKind.Unspecified), 63, 0f, 20.69f, 77, 4 },
                    { 36, new DateTime(2021, 6, 3, 12, 12, 0, 0, DateTimeKind.Unspecified), 58, 0f, 35.63f, 41, 3 },
                    { 87, new DateTime(2021, 6, 9, 9, 36, 0, 0, DateTimeKind.Unspecified), 83, 0f, 24.26f, 10, 1 },
                    { 66, new DateTime(2021, 1, 9, 20, 4, 0, 0, DateTimeKind.Unspecified), 4, 0f, 49.07f, 2, 5 },
                    { 63, new DateTime(2021, 9, 20, 6, 41, 0, 0, DateTimeKind.Unspecified), 16, 0f, 15.22f, 2, 4 },
                    { 67, new DateTime(2021, 8, 11, 13, 50, 0, 0, DateTimeKind.Unspecified), 82, 0f, 34.62f, 71, 2 },
                    { 1, new DateTime(2021, 6, 24, 3, 7, 0, 0, DateTimeKind.Unspecified), 5, 0f, 38.94f, 71, 1 },
                    { 2, new DateTime(2021, 9, 29, 6, 38, 0, 0, DateTimeKind.Unspecified), 34, 0f, 17.45f, 48, 4 },
                    { 72, new DateTime(2021, 7, 19, 3, 56, 0, 0, DateTimeKind.Unspecified), 6, 0f, 30.58f, 94, 3 },
                    { 46, new DateTime(2021, 1, 9, 4, 3, 0, 0, DateTimeKind.Unspecified), 31, 0f, 38.73f, 94, 2 },
                    { 38, new DateTime(2021, 5, 20, 13, 41, 0, 0, DateTimeKind.Unspecified), 26, 0f, 38.15f, 94, 1 },
                    { 90, new DateTime(2021, 9, 14, 13, 43, 0, 0, DateTimeKind.Unspecified), 81, 0f, 23.41f, 60, 5 },
                    { 80, new DateTime(2021, 6, 12, 1, 20, 0, 0, DateTimeKind.Unspecified), 89, 0f, 7.97f, 43, 3 },
                    { 34, new DateTime(2021, 11, 3, 14, 38, 0, 0, DateTimeKind.Unspecified), 62, 0f, 26.82f, 72, 1 },
                    { 98, new DateTime(2021, 8, 9, 22, 36, 0, 0, DateTimeKind.Unspecified), 95, 0f, 29.48f, 43, 1 },
                    { 57, new DateTime(2021, 2, 15, 0, 34, 0, 0, DateTimeKind.Unspecified), 79, 0f, 12.23f, 6, 5 },
                    { 23, new DateTime(2021, 8, 15, 6, 3, 0, 0, DateTimeKind.Unspecified), 22, 0f, 25.79f, 28, 5 },
                    { 60, new DateTime(2021, 11, 27, 14, 26, 0, 0, DateTimeKind.Unspecified), 67, 0f, 7.95f, 96, 4 },
                    { 42, new DateTime(2021, 4, 1, 8, 38, 0, 0, DateTimeKind.Unspecified), 38, 0f, 8.87f, 96, 5 },
                    { 73, new DateTime(2021, 11, 14, 12, 44, 0, 0, DateTimeKind.Unspecified), 20, 0f, 10.1f, 27, 1 },
                    { 81, new DateTime(2021, 7, 3, 23, 52, 0, 0, DateTimeKind.Unspecified), 65, 0f, 1.41f, 59, 2 },
                    { 8, new DateTime(2021, 8, 5, 3, 12, 0, 0, DateTimeKind.Unspecified), 79, 0f, 47.51f, 97, 3 },
                    { 45, new DateTime(2021, 10, 16, 20, 8, 0, 0, DateTimeKind.Unspecified), 85, 0f, 19.54f, 47, 1 },
                    { 31, new DateTime(2021, 8, 4, 11, 34, 0, 0, DateTimeKind.Unspecified), 75, 0f, 15.83f, 47, 3 }
                });

            migrationBuilder.InsertData(
                table: "IngredientRecipes",
                columns: new[] { "Id", "CreatedDate", "IngredientId", "Price", "Quantity", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 44, new DateTime(2021, 10, 22, 9, 53, 0, 0, DateTimeKind.Unspecified), 18, 0f, 1.63f, 92, 3 },
                    { 53, new DateTime(2021, 2, 6, 18, 38, 0, 0, DateTimeKind.Unspecified), 61, 0f, 22.76f, 65, 4 },
                    { 35, new DateTime(2021, 5, 15, 11, 7, 0, 0, DateTimeKind.Unspecified), 51, 0f, 19.14f, 65, 3 },
                    { 94, new DateTime(2021, 9, 23, 18, 1, 0, 0, DateTimeKind.Unspecified), 14, 0f, 7.53f, 15, 2 },
                    { 65, new DateTime(2021, 4, 21, 10, 28, 0, 0, DateTimeKind.Unspecified), 20, 0f, 37.37f, 8, 3 },
                    { 93, new DateTime(2021, 6, 19, 11, 56, 0, 0, DateTimeKind.Unspecified), 40, 0f, 15.69f, 67, 5 },
                    { 51, new DateTime(2021, 5, 3, 8, 27, 0, 0, DateTimeKind.Unspecified), 79, 0f, 15.97f, 67, 5 },
                    { 6, new DateTime(2021, 1, 10, 5, 29, 0, 0, DateTimeKind.Unspecified), 75, 0f, 3.14f, 53, 3 },
                    { 64, new DateTime(2021, 8, 3, 6, 15, 0, 0, DateTimeKind.Unspecified), 36, 0f, 10.32f, 86, 3 },
                    { 26, new DateTime(2021, 7, 6, 19, 12, 0, 0, DateTimeKind.Unspecified), 48, 0f, 41.51f, 86, 2 },
                    { 7, new DateTime(2021, 2, 27, 1, 39, 0, 0, DateTimeKind.Unspecified), 91, 0f, 23.86f, 58, 3 },
                    { 37, new DateTime(2021, 10, 16, 13, 13, 0, 0, DateTimeKind.Unspecified), 47, 0f, 35.12f, 17, 5 },
                    { 70, new DateTime(2021, 5, 4, 14, 4, 0, 0, DateTimeKind.Unspecified), 33, 0f, 5.88f, 6, 2 },
                    { 15, new DateTime(2021, 10, 5, 2, 17, 0, 0, DateTimeKind.Unspecified), 29, 0f, 23.73f, 6, 3 },
                    { 9, new DateTime(2021, 7, 24, 20, 24, 0, 0, DateTimeKind.Unspecified), 20, 0f, 43.61f, 13, 2 }
                });
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
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12);

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
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41);

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
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50);

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
                keyValue: 54);

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
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72);

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
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 31);

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
                keyValue: 42);

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
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 25);

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
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 46);

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
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 52);

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
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 74);

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
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 80);

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
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9);

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
                keyValue: 19);

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
                keyValue: 22);

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
                keyValue: 28);

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
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46);

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
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51);

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
                keyValue: 69);

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
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80);

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
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85);

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
                keyValue: 89);

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
                keyValue: 92);

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
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 37);

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
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4);

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
                keyValue: 9);

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
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 24);

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
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 33);

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
                keyValue: 38);

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
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 59);

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
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 67);

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
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 77);

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
                keyValue: 82);

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
                keyValue: 86);

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
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 94);

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
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 6);

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
                keyValue: 13);

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
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 20);

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
                keyValue: 24);

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
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 30);

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
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "RecipeCategories",
                keyColumn: "Id",
                keyValue: 45);

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
        }
    }
}
