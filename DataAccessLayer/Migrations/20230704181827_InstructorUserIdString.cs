using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class InstructorUserIdString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_AspNetUsers_ApplicationUserId1",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_ApplicationUserId1",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "Instructors");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Instructors",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_ApplicationUserId",
                table: "Instructors",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_AspNetUsers_ApplicationUserId",
                table: "Instructors",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_AspNetUsers_ApplicationUserId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_ApplicationUserId",
                table: "Instructors");

            migrationBuilder.AlterColumn<Guid>(
                name: "ApplicationUserId",
                table: "Instructors",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "Instructors",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_ApplicationUserId1",
                table: "Instructors",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_AspNetUsers_ApplicationUserId1",
                table: "Instructors",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
