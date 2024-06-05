using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixedSpellingInMeal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAd",
                table: "MealsComment",
                newName: "CreatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "MealsComment",
                newName: "CreatedAd");
        }
    }
}
