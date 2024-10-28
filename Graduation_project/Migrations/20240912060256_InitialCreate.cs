using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Graduation_project.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID_student = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_student = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname_student = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Form = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count_grades = table.Column<int>(type: "int", nullable: false),
                    Average_grage = table.Column<int>(type: "int", nullable: false),
                    Position_in_class = table.Column<int>(type: "int", nullable: false),
                    Position_in_paralel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID_student);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    ID_student = table.Column<int>(type: "int", nullable: false),
                    attendent_lessons = table.Column<int>(type: "int", nullable: false),
                    missed_lessons = table.Column<int>(type: "int", nullable: false),
                    all_lessons = table.Column<int>(type: "int", nullable: false),
                    full_name_teacher = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.ID_student);
                    table.ForeignKey(
                        name: "FK_Attendances_Students_ID_student",
                        column: x => x.ID_student,
                        principalTable: "Students",
                        principalColumn: "ID_student",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    ID_teacher = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_teacher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname_teacher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName_teacher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_form_master = table.Column<bool>(type: "bit", nullable: true),
                    form_master_class = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.ID_teacher);
                });
        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "Students");
            migrationBuilder.DropTable(
          name: "Teachers");
        }
    }
}
