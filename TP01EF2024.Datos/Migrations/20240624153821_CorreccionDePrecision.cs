using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP01EF2024.Datos.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionDePrecision : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "SizeNumber",
                table: "Sizes",
                type: "decimal(3,1)",
                precision: 3,
                scale: 1,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(3)",
                oldPrecision: 3,
                oldScale: 2);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 1,
                column: "SizeNumber",
                value: 28m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 2,
                column: "SizeNumber",
                value: 28.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 3,
                column: "SizeNumber",
                value: 29.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 4,
                column: "SizeNumber",
                value: 29.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 5,
                column: "SizeNumber",
                value: 30.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 6,
                column: "SizeNumber",
                value: 30.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 7,
                column: "SizeNumber",
                value: 31.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 8,
                column: "SizeNumber",
                value: 31.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 9,
                column: "SizeNumber",
                value: 32.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 10,
                column: "SizeNumber",
                value: 32.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 11,
                column: "SizeNumber",
                value: 33.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 12,
                column: "SizeNumber",
                value: 33.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 13,
                column: "SizeNumber",
                value: 34.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 14,
                column: "SizeNumber",
                value: 34.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 15,
                column: "SizeNumber",
                value: 35.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 16,
                column: "SizeNumber",
                value: 35.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 17,
                column: "SizeNumber",
                value: 36.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 18,
                column: "SizeNumber",
                value: 36.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 19,
                column: "SizeNumber",
                value: 37.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 20,
                column: "SizeNumber",
                value: 37.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 21,
                column: "SizeNumber",
                value: 38.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 22,
                column: "SizeNumber",
                value: 38.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 23,
                column: "SizeNumber",
                value: 39.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 24,
                column: "SizeNumber",
                value: 39.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 25,
                column: "SizeNumber",
                value: 40.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 26,
                column: "SizeNumber",
                value: 40.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 27,
                column: "SizeNumber",
                value: 41.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 28,
                column: "SizeNumber",
                value: 41.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 29,
                column: "SizeNumber",
                value: 42.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 30,
                column: "SizeNumber",
                value: 42.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 31,
                column: "SizeNumber",
                value: 43.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 32,
                column: "SizeNumber",
                value: 43.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 33,
                column: "SizeNumber",
                value: 44.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 34,
                column: "SizeNumber",
                value: 44.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 35,
                column: "SizeNumber",
                value: 45.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 36,
                column: "SizeNumber",
                value: 45.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 37,
                column: "SizeNumber",
                value: 46.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 38,
                column: "SizeNumber",
                value: 46.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 39,
                column: "SizeNumber",
                value: 47.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 40,
                column: "SizeNumber",
                value: 47.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 41,
                column: "SizeNumber",
                value: 48.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 42,
                column: "SizeNumber",
                value: 48.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 43,
                column: "SizeNumber",
                value: 49.0m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 44,
                column: "SizeNumber",
                value: 49.5m);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 45,
                column: "SizeNumber",
                value: 50.0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "SizeNumber",
                table: "Sizes",
                type: "float(3)",
                precision: 3,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)",
                oldPrecision: 3,
                oldScale: 1);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 1,
                column: "SizeNumber",
                value: 28.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 2,
                column: "SizeNumber",
                value: 28.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 3,
                column: "SizeNumber",
                value: 29.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 4,
                column: "SizeNumber",
                value: 29.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 5,
                column: "SizeNumber",
                value: 30.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 6,
                column: "SizeNumber",
                value: 30.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 7,
                column: "SizeNumber",
                value: 31.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 8,
                column: "SizeNumber",
                value: 31.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 9,
                column: "SizeNumber",
                value: 32.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 10,
                column: "SizeNumber",
                value: 32.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 11,
                column: "SizeNumber",
                value: 33.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 12,
                column: "SizeNumber",
                value: 33.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 13,
                column: "SizeNumber",
                value: 34.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 14,
                column: "SizeNumber",
                value: 34.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 15,
                column: "SizeNumber",
                value: 35.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 16,
                column: "SizeNumber",
                value: 35.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 17,
                column: "SizeNumber",
                value: 36.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 18,
                column: "SizeNumber",
                value: 36.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 19,
                column: "SizeNumber",
                value: 37.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 20,
                column: "SizeNumber",
                value: 37.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 21,
                column: "SizeNumber",
                value: 38.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 22,
                column: "SizeNumber",
                value: 38.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 23,
                column: "SizeNumber",
                value: 39.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 24,
                column: "SizeNumber",
                value: 39.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 25,
                column: "SizeNumber",
                value: 40.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 26,
                column: "SizeNumber",
                value: 40.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 27,
                column: "SizeNumber",
                value: 41.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 28,
                column: "SizeNumber",
                value: 41.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 29,
                column: "SizeNumber",
                value: 42.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 30,
                column: "SizeNumber",
                value: 42.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 31,
                column: "SizeNumber",
                value: 43.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 32,
                column: "SizeNumber",
                value: 43.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 33,
                column: "SizeNumber",
                value: 44.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 34,
                column: "SizeNumber",
                value: 44.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 35,
                column: "SizeNumber",
                value: 45.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 36,
                column: "SizeNumber",
                value: 45.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 37,
                column: "SizeNumber",
                value: 46.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 38,
                column: "SizeNumber",
                value: 46.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 39,
                column: "SizeNumber",
                value: 47.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 40,
                column: "SizeNumber",
                value: 47.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 41,
                column: "SizeNumber",
                value: 48.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 42,
                column: "SizeNumber",
                value: 48.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 43,
                column: "SizeNumber",
                value: 49.0);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 44,
                column: "SizeNumber",
                value: 49.5);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 45,
                column: "SizeNumber",
                value: 50.0);
        }
    }
}
