using Microsoft.EntityFrameworkCore.Migrations;

namespace getting_started.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Courses_CourseId",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_students_StudentId",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "students",
                newName: "Student_table");

            migrationBuilder.RenameTable(
                name: "StudentCourse",
                newName: "StudentCourse_table");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course_table");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_StudentId",
                table: "StudentCourse_table",
                newName: "IX_StudentCourse_table_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_CourseId",
                table: "StudentCourse_table",
                newName: "IX_StudentCourse_table_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student_table",
                table: "Student_table",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourse_table",
                table: "StudentCourse_table",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_table",
                table: "Course_table",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_table_Course_table_CourseId",
                table: "StudentCourse_table",
                column: "CourseId",
                principalTable: "Course_table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_table_Student_table_StudentId",
                table: "StudentCourse_table",
                column: "StudentId",
                principalTable: "Student_table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_table_Course_table_CourseId",
                table: "StudentCourse_table");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_table_Student_table_StudentId",
                table: "StudentCourse_table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourse_table",
                table: "StudentCourse_table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student_table",
                table: "Student_table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_table",
                table: "Course_table");

            migrationBuilder.RenameTable(
                name: "StudentCourse_table",
                newName: "StudentCourse");

            migrationBuilder.RenameTable(
                name: "Student_table",
                newName: "students");

            migrationBuilder.RenameTable(
                name: "Course_table",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_table_StudentId",
                table: "StudentCourse",
                newName: "IX_StudentCourse_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_table_CourseId",
                table: "StudentCourse",
                newName: "IX_StudentCourse_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Courses_CourseId",
                table: "StudentCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_students_StudentId",
                table: "StudentCourse",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
