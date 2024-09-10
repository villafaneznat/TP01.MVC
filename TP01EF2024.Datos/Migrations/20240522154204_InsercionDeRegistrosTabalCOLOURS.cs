using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TP01EF2024.Datos.Migrations
{
    /// <inheritdoc />
    public partial class InsercionDeRegistrosTabalCOLOURS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "ColourId", "ColourName" },
                values: new object[,]
                {
                    { 1, "Rojo" },
                    { 2, "Negro" },
                    { 3, "Blanco" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "ColourId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "ColourId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "ColourId",
                keyValue: 3);
        }
    }
}
