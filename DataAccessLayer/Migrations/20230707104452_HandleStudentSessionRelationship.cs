using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class HandleStudentSessionRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SessionStudent_Sessions_SessionsId",
                table: "SessionStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionStudent_Students_StudentsId",
                table: "SessionStudent");

            migrationBuilder.RenameColumn(
                name: "StudentsId",
                table: "SessionStudent",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "SessionsId",
                table: "SessionStudent",
                newName: "SessionId");

            migrationBuilder.RenameIndex(
                name: "IX_SessionStudent_StudentsId",
                table: "SessionStudent",
                newName: "IX_SessionStudent_StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_SessionStudent_Sessions_SessionId",
                table: "SessionStudent",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionStudent_Students_StudentId",
                table: "SessionStudent",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SessionStudent_Sessions_SessionId",
                table: "SessionStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionStudent_Students_StudentId",
                table: "SessionStudent");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "SessionStudent",
                newName: "StudentsId");

            migrationBuilder.RenameColumn(
                name: "SessionId",
                table: "SessionStudent",
                newName: "SessionsId");

            migrationBuilder.RenameIndex(
                name: "IX_SessionStudent_StudentId",
                table: "SessionStudent",
                newName: "IX_SessionStudent_StudentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_SessionStudent_Sessions_SessionsId",
                table: "SessionStudent",
                column: "SessionsId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SessionStudent_Students_StudentsId",
                table: "SessionStudent",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
