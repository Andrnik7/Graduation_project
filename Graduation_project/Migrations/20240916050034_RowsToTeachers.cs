using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Graduation_project.Migrations
{
    /// <inheritdoc />
    public partial class RowsToTeachers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    form_master_class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_teacher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password_teacher = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Teachers");
        }
    }
}
