using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Graduation_project.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Subjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Current_Grades_Maths_Students_ID_student",
                table: "Current_Grades_Maths");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Current_Grades_Maths",
                table: "Current_Grades_Maths");

            migrationBuilder.RenameTable(
                name: "Current_Grades_Maths",
                newName: "Current_Grades_maths");

            migrationBuilder.RenameIndex(
                name: "IX_Current_Grades_Maths_ID_student",
                table: "Current_Grades_maths",
                newName: "IX_Current_Grades_maths_ID_student");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Current_Grades_maths",
                table: "Current_Grades_maths",
                column: "ID_math");

            migrationBuilder.CreateTable(
                name: "Current_Grades_computer_project",
                columns: table => new
                {
                    ID_computer_project = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tuesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wednesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    thursday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    friday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_student = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Current_Grades_computer_project", x => x.ID_computer_project);
                    table.ForeignKey(
                        name: "FK_Current_Grades_computer_project_Students_ID_student",
                        column: x => x.ID_student,
                        principalTable: "Students",
                        principalColumn: "ID_student",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Current_Grades_english",
                columns: table => new
                {
                    ID_english = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tuesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wednesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    thursday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    friday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_student = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Current_Grades_english", x => x.ID_english);
                    table.ForeignKey(
                        name: "FK_Current_Grades_english_Students_ID_student",
                        column: x => x.ID_student,
                        principalTable: "Students",
                        principalColumn: "ID_student",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Current_Grades_geography",
                columns: table => new
                {
                    ID_geography = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tuesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wednesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    thursday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    friday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_student = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Current_Grades_geography", x => x.ID_geography);
                    table.ForeignKey(
                        name: "FK_Current_Grades_geography_Students_ID_student",
                        column: x => x.ID_student,
                        principalTable: "Students",
                        principalColumn: "ID_student",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Current_Grades_history",
                columns: table => new
                {
                    ID_ukr_history = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tuesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wednesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    thursday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    friday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_student = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Current_Grades_history", x => x.ID_ukr_history);
                    table.ForeignKey(
                        name: "FK_Current_Grades_history_Students_ID_student",
                        column: x => x.ID_student,
                        principalTable: "Students",
                        principalColumn: "ID_student",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Current_Grades_informathicsIT",
                columns: table => new
                {
                    ID_informathicsIT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tuesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wednesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    thursday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    friday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_student = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Current_Grades_informathicsIT", x => x.ID_informathicsIT);
                    table.ForeignKey(
                        name: "FK_Current_Grades_informathicsIT_Students_ID_student",
                        column: x => x.ID_student,
                        principalTable: "Students",
                        principalColumn: "ID_student",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Current_Grades_PE",
                columns: table => new
                {
                    ID_PE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tuesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wednesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    thursday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    friday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_student = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Current_Grades_PE", x => x.ID_PE);
                    table.ForeignKey(
                        name: "FK_Current_Grades_PE_Students_ID_student",
                        column: x => x.ID_student,
                        principalTable: "Students",
                        principalColumn: "ID_student",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Current_Grades_physics",
                columns: table => new
                {
                    ID_physics = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tuesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wednesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    thursday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    friday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_student = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Current_Grades_physics", x => x.ID_physics);
                    table.ForeignKey(
                        name: "FK_Current_Grades_physics_Students_ID_student",
                        column: x => x.ID_student,
                        principalTable: "Students",
                        principalColumn: "ID_student",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Current_Grades_programming",
                columns: table => new
                {
                    ID_programming = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tuesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wednesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    thursday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    friday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_student = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Current_Grades_programming", x => x.ID_programming);
                    table.ForeignKey(
                        name: "FK_Current_Grades_programming_Students_ID_student",
                        column: x => x.ID_student,
                        principalTable: "Students",
                        principalColumn: "ID_student",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Current_Grades_ukr_lang",
                columns: table => new
                {
                    ID_ukr_lang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tuesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wednesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    thursday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    friday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_student = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Current_Grades_ukr_lang", x => x.ID_ukr_lang);
                    table.ForeignKey(
                        name: "FK_Current_Grades_ukr_lang_Students_ID_student",
                        column: x => x.ID_student,
                        principalTable: "Students",
                        principalColumn: "ID_student",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Current_Grades_ukr_lit",
                columns: table => new
                {
                    ID_ukr_lit = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tuesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wednesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    thursday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    friday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_student = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Current_Grades_ukr_lit", x => x.ID_ukr_lit);
                    table.ForeignKey(
                        name: "FK_Current_Grades_ukr_lit_Students_ID_student",
                        column: x => x.ID_student,
                        principalTable: "Students",
                        principalColumn: "ID_student",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Current_Grades_world_lit",
                columns: table => new
                {
                    ID_world_lit = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tuesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wednesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    thursday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    friday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_student = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Current_Grades_world_lit", x => x.ID_world_lit);
                    table.ForeignKey(
                        name: "FK_Current_Grades_world_lit_Students_ID_student",
                        column: x => x.ID_student,
                        principalTable: "Students",
                        principalColumn: "ID_student",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Current_Grades_computer_project_ID_student",
                table: "Current_Grades_computer_project",
                column: "ID_student");

            migrationBuilder.CreateIndex(
                name: "IX_Current_Grades_english_ID_student",
                table: "Current_Grades_english",
                column: "ID_student");

            migrationBuilder.CreateIndex(
                name: "IX_Current_Grades_geography_ID_student",
                table: "Current_Grades_geography",
                column: "ID_student");

            migrationBuilder.CreateIndex(
                name: "IX_Current_Grades_history_ID_student",
                table: "Current_Grades_history",
                column: "ID_student");

            migrationBuilder.CreateIndex(
                name: "IX_Current_Grades_informathicsIT_ID_student",
                table: "Current_Grades_informathicsIT",
                column: "ID_student");

            migrationBuilder.CreateIndex(
                name: "IX_Current_Grades_PE_ID_student",
                table: "Current_Grades_PE",
                column: "ID_student");

            migrationBuilder.CreateIndex(
                name: "IX_Current_Grades_physics_ID_student",
                table: "Current_Grades_physics",
                column: "ID_student");

            migrationBuilder.CreateIndex(
                name: "IX_Current_Grades_programming_ID_student",
                table: "Current_Grades_programming",
                column: "ID_student");

            migrationBuilder.CreateIndex(
                name: "IX_Current_Grades_ukr_lang_ID_student",
                table: "Current_Grades_ukr_lang",
                column: "ID_student");

            migrationBuilder.CreateIndex(
                name: "IX_Current_Grades_ukr_lit_ID_student",
                table: "Current_Grades_ukr_lit",
                column: "ID_student");

            migrationBuilder.CreateIndex(
                name: "IX_Current_Grades_world_lit_ID_student",
                table: "Current_Grades_world_lit",
                column: "ID_student");

            migrationBuilder.AddForeignKey(
                name: "FK_Current_Grades_maths_Students_ID_student",
                table: "Current_Grades_maths",
                column: "ID_student",
                principalTable: "Students",
                principalColumn: "ID_student",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Current_Grades_maths_Students_ID_student",
                table: "Current_Grades_maths");

            migrationBuilder.DropTable(
                name: "Current_Grades_computer_project");

            migrationBuilder.DropTable(
                name: "Current_Grades_english");

            migrationBuilder.DropTable(
                name: "Current_Grades_geography");

            migrationBuilder.DropTable(
                name: "Current_Grades_history");

            migrationBuilder.DropTable(
                name: "Current_Grades_informathicsIT");

            migrationBuilder.DropTable(
                name: "Current_Grades_PE");

            migrationBuilder.DropTable(
                name: "Current_Grades_physics");

            migrationBuilder.DropTable(
                name: "Current_Grades_programming");

            migrationBuilder.DropTable(
                name: "Current_Grades_ukr_lang");

            migrationBuilder.DropTable(
                name: "Current_Grades_ukr_lit");

            migrationBuilder.DropTable(
                name: "Current_Grades_world_lit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Current_Grades_maths",
                table: "Current_Grades_maths");

            migrationBuilder.RenameTable(
                name: "Current_Grades_maths",
                newName: "Current_Grades_Maths");

            migrationBuilder.RenameIndex(
                name: "IX_Current_Grades_maths_ID_student",
                table: "Current_Grades_Maths",
                newName: "IX_Current_Grades_Maths_ID_student");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Current_Grades_Maths",
                table: "Current_Grades_Maths",
                column: "ID_math");

            migrationBuilder.AddForeignKey(
                name: "FK_Current_Grades_Maths_Students_ID_student",
                table: "Current_Grades_Maths",
                column: "ID_student",
                principalTable: "Students",
                principalColumn: "ID_student",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
