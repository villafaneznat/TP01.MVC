using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP01EF2024.Datos.Migrations
{
    /// <inheritdoc />
    public partial class IncorporacionTablaShoesColours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColourShoe");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoesColours");

            migrationBuilder.CreateTable(
                name: "ColourShoe",
                columns: table => new
                {
                    ColoursColourId = table.Column<int>(type: "int", nullable: false),
                    ShoesShoeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColourShoe", x => new { x.ColoursColourId, x.ShoesShoeId });
                    table.ForeignKey(
                        name: "FK_ColourShoe_Colours_ColoursColourId",
                        column: x => x.ColoursColourId,
                        principalTable: "Colours",
                        principalColumn: "ColourId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColourShoe_Shoes_ShoesShoeId",
                        column: x => x.ShoesShoeId,
                        principalTable: "Shoes",
                        principalColumn: "ShoeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ColourShoe_ShoesShoeId",
                table: "ColourShoe",
                column: "ShoesShoeId");
        }
    }
}
