using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TP01EF2024.Datos.Migrations
{
    /// <inheritdoc />
    public partial class CreacionEInsercionDeRegistrosTablaSizes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    SizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeNumber = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.SizeId);
                });

            migrationBuilder.CreateTable(
                name: "ShoeSize",
                columns: table => new
                {
                    ShoeId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoeSize", x => new { x.ShoeId, x.SizeId });
                    table.ForeignKey(
                        name: "FK_ShoeSize_Shoes_ShoeId",
                        column: x => x.ShoeId,
                        principalTable: "Shoes",
                        principalColumn: "ShoeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoeSize_Size_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Size",
                        principalColumn: "SizeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "SizeId", "SizeNumber" },
                values: new object[,]
                {
                    { 1, 28.0 },
                    { 2, 28.5 },
                    { 3, 29.0 },
                    { 4, 29.5 },
                    { 5, 30.0 },
                    { 6, 30.5 },
                    { 7, 31.0 },
                    { 8, 31.5 },
                    { 9, 32.0 },
                    { 10, 32.5 },
                    { 11, 33.0 },
                    { 12, 33.5 },
                    { 13, 34.0 },
                    { 14, 34.5 },
                    { 15, 35.0 },
                    { 16, 35.5 },
                    { 17, 36.0 },
                    { 18, 36.5 },
                    { 19, 37.0 },
                    { 20, 37.5 },
                    { 21, 38.0 },
                    { 22, 38.5 },
                    { 23, 39.0 },
                    { 24, 39.5 },
                    { 25, 40.0 },
                    { 26, 40.5 },
                    { 27, 41.0 },
                    { 28, 41.5 },
                    { 29, 42.0 },
                    { 30, 42.5 },
                    { 31, 43.0 },
                    { 32, 43.5 },
                    { 33, 44.0 },
                    { 34, 44.5 },
                    { 35, 45.0 },
                    { 36, 45.5 },
                    { 37, 46.0 },
                    { 38, 46.5 },
                    { 39, 47.0 },
                    { 40, 47.5 },
                    { 41, 48.0 },
                    { 42, 48.5 },
                    { 43, 49.0 },
                    { 44, 49.5 },
                    { 45, 50.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoeSize_SizeId",
                table: "ShoeSize",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Size_SizeNumber",
                table: "Size",
                column: "SizeNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoeSize");

            migrationBuilder.DropTable(
                name: "Size");
        }
    }
}
