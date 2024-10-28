using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Graduation_project.Migrations
{
    /// <inheritdoc />
    public partial class Initial_list : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PE_teacher",
                table: "Class_list",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "computer_project_teacher",
                table: "Class_list",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "english_project_teacher",
                table: "Class_list",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "geography_teacher",
                table: "Class_list",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "informathicsIT_teacher",
                table: "Class_list",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "physics_teacher",
                table: "Class_list",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "programming_teacher",
                table: "Class_list",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ukr_history_teacher",
                table: "Class_list",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ukr_lang_teacher",
                table: "Class_list",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ukr_lit_teacher",
                table: "Class_list",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "world_lit_teacher",
                table: "Class_list",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PE_teacher",
                table: "Class_list");

            migrationBuilder.DropColumn(
                name: "computer_project_teacher",
                table: "Class_list");

            migrationBuilder.DropColumn(
                name: "english_project_teacher",
                table: "Class_list");

            migrationBuilder.DropColumn(
                name: "geography_teacher",
                table: "Class_list");

            migrationBuilder.DropColumn(
                name: "informathicsIT_teacher",
                table: "Class_list");

            migrationBuilder.DropColumn(
                name: "physics_teacher",
                table: "Class_list");

            migrationBuilder.DropColumn(
                name: "programming_teacher",
                table: "Class_list");

            migrationBuilder.DropColumn(
                name: "ukr_history_teacher",
                table: "Class_list");

            migrationBuilder.DropColumn(
                name: "ukr_lang_teacher",
                table: "Class_list");

            migrationBuilder.DropColumn(
                name: "ukr_lit_teacher",
                table: "Class_list");

            migrationBuilder.DropColumn(
                name: "world_lit_teacher",
                table: "Class_list");
        }
    }
}
