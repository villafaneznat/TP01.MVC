using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP01EF2024.Datos.Migrations
{
    /// <inheritdoc />
    public partial class ActualizacionCampoActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Sports",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Shoes",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Colours",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Brands",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 1,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 2,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 3,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "ColourId",
                keyValue: 1,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "ColourId",
                keyValue: 2,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "ColourId",
                keyValue: 3,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 1,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 2,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 3,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportId",
                keyValue: 1,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportId",
                keyValue: 2,
                column: "Active",
                value: true);

            migrationBuilder.UpdateData(
                table: "Sports",
                keyColumn: "SportId",
                keyValue: 3,
                column: "Active",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Sports");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Colours");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Brands");
        }
    }
}
