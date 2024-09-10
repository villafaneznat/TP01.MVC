using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP01EF2024.Datos.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionesTablaSizes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoeSize_Shoes_ShoeId",
                table: "ShoeSize");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoeSize_Size_SizeId",
                table: "ShoeSize");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Size",
                table: "Size");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoeSize",
                table: "ShoeSize");

            migrationBuilder.RenameTable(
                name: "Size",
                newName: "Sizes");

            migrationBuilder.RenameTable(
                name: "ShoeSize",
                newName: "ShoesSizes");

            migrationBuilder.RenameIndex(
                name: "IX_Size_SizeNumber",
                table: "Sizes",
                newName: "IX_Sizes_SizeNumber");

            migrationBuilder.RenameIndex(
                name: "IX_ShoeSize_SizeId",
                table: "ShoesSizes",
                newName: "IX_ShoesSizes_SizeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes",
                column: "SizeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoesSizes",
                table: "ShoesSizes",
                columns: new[] { "ShoeId", "SizeId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ShoesSizes_Shoes_ShoeId",
                table: "ShoesSizes",
                column: "ShoeId",
                principalTable: "Shoes",
                principalColumn: "ShoeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoesSizes_Sizes_SizeId",
                table: "ShoesSizes",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoesSizes_Shoes_ShoeId",
                table: "ShoesSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoesSizes_Sizes_SizeId",
                table: "ShoesSizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoesSizes",
                table: "ShoesSizes");

            migrationBuilder.RenameTable(
                name: "Sizes",
                newName: "Size");

            migrationBuilder.RenameTable(
                name: "ShoesSizes",
                newName: "ShoeSize");

            migrationBuilder.RenameIndex(
                name: "IX_Sizes_SizeNumber",
                table: "Size",
                newName: "IX_Size_SizeNumber");

            migrationBuilder.RenameIndex(
                name: "IX_ShoesSizes_SizeId",
                table: "ShoeSize",
                newName: "IX_ShoeSize_SizeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Size",
                table: "Size",
                column: "SizeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoeSize",
                table: "ShoeSize",
                columns: new[] { "ShoeId", "SizeId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ShoeSize_Shoes_ShoeId",
                table: "ShoeSize",
                column: "ShoeId",
                principalTable: "Shoes",
                principalColumn: "ShoeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoeSize_Size_SizeId",
                table: "ShoeSize",
                column: "SizeId",
                principalTable: "Size",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
