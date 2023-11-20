using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineStore_Exam.Migrations
{
    /// <inheritdoc />
    public partial class UbdateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CategoryImageId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryImageId",
                table: "Categories",
                column: "CategoryImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Images_CategoryImageId",
                table: "Categories",
                column: "CategoryImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Images_CategoryImageId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryImageId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "CategoryImageId",
                table: "Categories");
        }
    }
}
