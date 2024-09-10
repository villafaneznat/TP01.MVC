using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP01EF2024.Datos.Migrations
{
    /// <inheritdoc />
    public partial class IncorporacionTablaShoesSizes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoesSizes",
                table: "ShoesSizes");

            migrationBuilder.AddColumn<int>(
                name: "ShoeSizeId",
                table: "ShoesSizes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "QuantityInStock",
                table: "ShoesSizes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoesSizes",
                table: "ShoesSizes",
                column: "ShoeSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoesSizes_ShoeId_SizeId",
                table: "ShoesSizes",
                columns: new[] { "ShoeId", "SizeId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoesSizes",
                table: "ShoesSizes");

            migrationBuilder.DropIndex(
                name: "IX_ShoesSizes_ShoeId_SizeId",
                table: "ShoesSizes");

            migrationBuilder.DropColumn(
                name: "ShoeSizeId",
                table: "ShoesSizes");

            migrationBuilder.DropColumn(
                name: "QuantityInStock",
                table: "ShoesSizes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoesSizes",
                table: "ShoesSizes",
                columns: new[] { "ShoeId", "SizeId" });
        }
    }
}
