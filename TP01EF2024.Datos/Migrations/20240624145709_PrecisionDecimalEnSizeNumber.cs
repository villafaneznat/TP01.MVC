using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP01EF2024.Datos.Migrations
{
    /// <inheritdoc />
    public partial class PrecisionDecimalEnSizeNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "SizeNumber",
                table: "Sizes",
                type: "float(3)",
                precision: 3,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "SizeNumber",
                table: "Sizes",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(3)",
                oldPrecision: 3,
                oldScale: 2);
        }
    }
}
