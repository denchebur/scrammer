using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class try_to_fix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskLists_Boards_BoardId",
                table: "TaskLists");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskLists_TaskListId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Boards_BoardId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_BoardId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BoardId",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "UserRole",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TaskStatus",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TaskPriority",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TaskListId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TaskAddingDate",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "BoardId",
                table: "TaskLists",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Boards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Boards_UserId",
                table: "Boards",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boards_Users",
                table: "Boards",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskLists_Boards",
                table: "TaskLists",
                column: "BoardId",
                principalTable: "Boards",
                principalColumn: "BoardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskLists",
                table: "Tasks",
                column: "TaskListId",
                principalTable: "TaskLists",
                principalColumn: "TaskListId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boards_Users",
                table: "Boards");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskLists_Boards",
                table: "TaskLists");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskLists",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Boards_UserId",
                table: "Boards");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Boards");

            migrationBuilder.AlterColumn<int>(
                name: "UserRole",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "BoardId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TaskStatus",
                table: "Tasks",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TaskPriority",
                table: "Tasks",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TaskListId",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TaskAddingDate",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "BoardId",
                table: "TaskLists",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BoardId",
                table: "Users",
                column: "BoardId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskLists_Boards_BoardId",
                table: "TaskLists",
                column: "BoardId",
                principalTable: "Boards",
                principalColumn: "BoardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskLists_TaskListId",
                table: "Tasks",
                column: "TaskListId",
                principalTable: "TaskLists",
                principalColumn: "TaskListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Boards_BoardId",
                table: "Users",
                column: "BoardId",
                principalTable: "Boards",
                principalColumn: "BoardId");
        }
    }
}
