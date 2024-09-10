using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TP01EF2024.Datos.Migrations
{
    /// <inheritdoc />
    public partial class InsercionDeRegistrosTablaSHOES : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "ShoeId", "BrandId", "Description", "GenreId", "Model", "Price", "SportId" },
                values: new object[,]
                {
                    { 1, 1, "Vans Deportivas", 2, "Deportivas", 15m, 3 },
                    { 2, 2, "Botines Femeninos", 1, "Botines", 20m, 1 },
                    { 3, 3, "Importados", 3, "1982", 35m, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 3);
        }
    }
}
