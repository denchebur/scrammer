using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class try_to_fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Boards_UserId",
                table: "Boards");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Boards");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BoardId",
                table: "Users",
                column: "BoardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_BoardId",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Boards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Boards_UserId",
                table: "Boards",
                column: "UserId");
        }
    }
}
