using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TP01EF2024.Datos.Migrations
{
    /// <inheritdoc />
    public partial class Correcciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 45);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeId", "SizeNumber" },
                values: new object[,]
                {
                    { 1, 28m },
                    { 2, 28.5m },
                    { 3, 29.0m },
                    { 4, 29.5m },
                    { 5, 30.0m },
                    { 6, 30.5m },
                    { 7, 31.0m },
                    { 8, 31.5m },
                    { 9, 32.0m },
                    { 10, 32.5m },
                    { 11, 33.0m },
                    { 12, 33.5m },
                    { 13, 34.0m },
                    { 14, 34.5m },
                    { 15, 35.0m },
                    { 16, 35.5m },
                    { 17, 36.0m },
                    { 18, 36.5m },
                    { 19, 37.0m },
                    { 20, 37.5m },
                    { 21, 38.0m },
                    { 22, 38.5m },
                    { 23, 39.0m },
                    { 24, 39.5m },
                    { 25, 40.0m },
                    { 26, 40.5m },
                    { 27, 41.0m },
                    { 28, 41.5m },
                    { 29, 42.0m },
                    { 30, 42.5m },
                    { 31, 43.0m },
                    { 32, 43.5m },
                    { 33, 44.0m },
                    { 34, 44.5m },
                    { 35, 45.0m },
                    { 36, 45.5m },
                    { 37, 46.0m },
                    { 38, 46.5m },
                    { 39, 47.0m },
                    { 40, 47.5m },
                    { 41, 48.0m },
                    { 42, 48.5m },
                    { 43, 49.0m },
                    { 44, 49.5m },
                    { 45, 50.0m }
                });
        }
    }
}
