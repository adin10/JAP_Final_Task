using Microsoft.EntityFrameworkCore.Migrations;

namespace NormativeCalculator.Infrastructure.Migrations
{
    public partial class addingIngredientRecipesFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "IngredientRecipe",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Quantity",
                table: "IngredientRecipe",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "IngredientRecipe");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "IngredientRecipe");
        }
    }
}
