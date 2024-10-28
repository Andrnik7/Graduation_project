using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Graduation_project.Migrations
{
    /// <inheritdoc />
    public partial class Initial_schedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "schedule_friday");

            migrationBuilder.DropTable(
                name: "schedule_monday");

            migrationBuilder.DropTable(
                name: "schedule_thursday");

            migrationBuilder.DropTable(
                name: "schedule_tuesday");

            migrationBuilder.DropTable(
                name: "schedule_wednesday");

            migrationBuilder.CreateTable(
                name: "schedule_day",
                columns: table => new
                {
                    ID_schedule_day = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    class_id = table.Column<int>(type: "int", nullable: false),
                    day_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    first_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    second_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    third_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fourth_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fifth_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schedule_day", x => x.ID_schedule_day);
                    table.ForeignKey(
                        name: "FK_schedule_day_Class_list_class_id",
                        column: x => x.class_id,
                        principalTable: "Class_list",
                        principalColumn: "ID_class",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_schedule_day_class_id",
                table: "schedule_day",
                column: "class_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "schedule_day");

            migrationBuilder.CreateTable(
                name: "schedule_friday",
                columns: table => new
                {
                    ID_friday = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    class_id = table.Column<int>(type: "int", nullable: false),
                    fifth_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    first_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fourth_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    second_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    third_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schedule_friday", x => x.ID_friday);
                    table.ForeignKey(
                        name: "FK_schedule_friday_Class_list_class_id",
                        column: x => x.class_id,
                        principalTable: "Class_list",
                        principalColumn: "ID_class",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "schedule_monday",
                columns: table => new
                {
                    ID_monday = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    class_id = table.Column<int>(type: "int", nullable: false),
                    fifth_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    first_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fourth_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    second_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    third_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schedule_monday", x => x.ID_monday);
                    table.ForeignKey(
                        name: "FK_schedule_monday_Class_list_class_id",
                        column: x => x.class_id,
                        principalTable: "Class_list",
                        principalColumn: "ID_class",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "schedule_thursday",
                columns: table => new
                {
                    ID_thuesday = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    class_id = table.Column<int>(type: "int", nullable: false),
                    fifth_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    first_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fourth_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    second_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    third_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schedule_thursday", x => x.ID_thuesday);
                    table.ForeignKey(
                        name: "FK_schedule_thursday_Class_list_class_id",
                        column: x => x.class_id,
                        principalTable: "Class_list",
                        principalColumn: "ID_class",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "schedule_tuesday",
                columns: table => new
                {
                    ID_thuesday = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    class_id = table.Column<int>(type: "int", nullable: false),
                    fifth_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    first_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fourth_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    second_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    third_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schedule_tuesday", x => x.ID_thuesday);
                    table.ForeignKey(
                        name: "FK_schedule_tuesday_Class_list_class_id",
                        column: x => x.class_id,
                        principalTable: "Class_list",
                        principalColumn: "ID_class",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "schedule_wednesday",
                columns: table => new
                {
                    ID_wednesday = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    class_id = table.Column<int>(type: "int", nullable: false),
                    fifth_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    first_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fourth_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    second_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    third_lesson = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schedule_wednesday", x => x.ID_wednesday);
                    table.ForeignKey(
                        name: "FK_schedule_wednesday_Class_list_class_id",
                        column: x => x.class_id,
                        principalTable: "Class_list",
                        principalColumn: "ID_class",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_schedule_friday_class_id",
                table: "schedule_friday",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_schedule_monday_class_id",
                table: "schedule_monday",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_schedule_thursday_class_id",
                table: "schedule_thursday",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_schedule_tuesday_class_id",
                table: "schedule_tuesday",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_schedule_wednesday_class_id",
                table: "schedule_wednesday",
                column: "class_id");
        }
    }
}
