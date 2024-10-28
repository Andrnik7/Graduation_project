using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Graduation_project.Migrations
{
    /// <inheritdoc />
    public partial class InitialMathGrades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Current_Grades_Maths",
                columns: table => new
                {
                    ID_math = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monday = table.Column<int>(type: "int", nullable: false),
                    tuesday = table.Column<int>(type: "int", nullable: false),
                    wednesday = table.Column<int>(type: "int", nullable: false),
                    thursday = table.Column<int>(type: "int", nullable: false),
                    friday = table.Column<int>(type: "int", nullable: false),
                    type_grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_student = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Current_Grades_Maths", x => x.ID_math);
                    table.ForeignKey(
                        name: "FK_Current_Grades_Maths_Students_ID_student",
                        column: x => x.ID_student,
                        principalTable: "Students",
                        principalColumn: "ID_student",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Current_Grades_Maths_ID_student",
                table: "Current_Grades_Maths",
                column: "ID_student");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Current_Grades_Maths");
        }
    }
}
