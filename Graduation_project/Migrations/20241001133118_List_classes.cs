using Microsoft.EntityFrameworkCore.Migrations;

namespace Graduation_project.Migrations
{
    public partial class List_classes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Class_list",
                columns: table => new
                {
                    ID_class = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_class = table.Column<string>(nullable: true),
                    biology_teacher = table.Column<int>(nullable: false),
                    math_teacher = table.Column<int>(nullable: false),
                    world_history_teacher = table.Column<int>(nullable: false),
                    ID_teacher = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class_list", x => x.ID_class);
                    table.ForeignKey(
                        name: "FK_Class_list_Teachers_ID_teacher",
                        column: x => x.ID_teacher,
                        principalTable: "Teachers",
                        principalColumn: "ID_teacher",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateIndex(
                name: "IX_Class_list_ID_teacher",
                table: "Class_list",
                column: "ID_teacher");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Class_list");
        }
    }
}
