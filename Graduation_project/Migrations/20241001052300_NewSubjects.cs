using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Graduation_project.Migrations
{
    /// <inheritdoc />
    public partial class NewSubjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Current_Grades_biology",
                columns: table => new
                {
                    ID_biology = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Current_Grades_biology", x => x.ID_biology);
                    table.ForeignKey(
                        name: "FK_Current_Grades_biology_Students_ID_student",
                        column: x => x.ID_student,
                        principalTable: "Students",
                        principalColumn: "ID_student",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Current_Grades_world_history",
                columns: table => new
                {
                    ID_world_history = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Current_Grades_world_history", x => x.ID_world_history);
                    table.ForeignKey(
                        name: "FK_Current_Grades_world_history_Students_ID_student",
                        column: x => x.ID_student,
                        principalTable: "Students",
                        principalColumn: "ID_student",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Current_Grades_biology_ID_student",
                table: "Current_Grades_biology",
                column: "ID_student");

            migrationBuilder.CreateIndex(
                name: "IX_Current_Grades_world_history_ID_student",
                table: "Current_Grades_world_history",
                column: "ID_student");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Current_Grades_biology");

            migrationBuilder.DropTable(
                name: "Current_Grades_world_history");
        }
    }
}
