using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP01EF2024.Datos.Migrations
{
    /// <inheritdoc />
    public partial class EliminacionTablaShoesColours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoesColours");

            migrationBuilder.AddColumn<int>(
                name: "ColourId",
                table: "Shoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 1,
                column: "ColourId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 2,
                column: "ColourId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 3,
                column: "ColourId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_ColourId",
                table: "Shoes",
                column: "ColourId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Colours_ColourId",
                table: "Shoes",
                column: "ColourId",
                principalTable: "Colours",
                principalColumn: "ColourId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Colours_ColourId",
                table: "Shoes");

            migrationBuilder.DropIndex(
                name: "IX_Shoes_ColourId",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "ColourId",
                table: "Shoes");

            migrationBuilder.CreateTable(
                name: "ShoesColours",
                columns: table => new
                {
                    ShoeId = table.Column<int>(type: "int", nullable: false),
                    ColourId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoesColours", x => new { x.ShoeId, x.ColourId });
                    table.ForeignKey(
                        name: "FK_ShoesColours_Colours_ColourId",
                        column: x => x.ColourId,
                        principalTable: "Colours",
                        principalColumn: "ColourId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoesColours_Shoes_ShoeId",
                        column: x => x.ShoeId,
                        principalTable: "Shoes",
                        principalColumn: "ShoeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoesColours_ColourId",
                table: "ShoesColours",
                column: "ColourId");
        }
    }
}
