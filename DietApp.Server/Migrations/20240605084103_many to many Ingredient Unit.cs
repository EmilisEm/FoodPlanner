using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class manytomanyIngredientUnit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Ingredients_IngredientId",
                table: "Unit");

            migrationBuilder.DropIndex(
                name: "IX_Unit_IngredientId",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "Unit");

            migrationBuilder.CreateTable(
                name: "IngredientUnit",
                columns: table => new
                {
                    IngredientsId = table.Column<Guid>(type: "uuid", nullable: false),
                    UnitsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientUnit", x => new { x.IngredientsId, x.UnitsId });
                    table.ForeignKey(
                        name: "FK_IngredientUnit_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientUnit_Unit_UnitsId",
                        column: x => x.UnitsId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientUnit_UnitsId",
                table: "IngredientUnit",
                column: "UnitsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientUnit");

            migrationBuilder.AddColumn<Guid>(
                name: "IngredientId",
                table: "Unit",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Unit_IngredientId",
                table: "Unit",
                column: "IngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Ingredients_IngredientId",
                table: "Unit",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id");
        }
    }
}
