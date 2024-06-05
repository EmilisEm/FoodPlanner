using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class RemovedingredientUnit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientUnits");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "IngredientUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IngredientId = table.Column<Guid>(type: "uuid", nullable: false),
                    UnitId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngredientUnits_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientUnits_Unit_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientUnits_IngredientId",
                table: "IngredientUnits",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientUnits_UnitId",
                table: "IngredientUnits",
                column: "UnitId");
        }
    }
}
