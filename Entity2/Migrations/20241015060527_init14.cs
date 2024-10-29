using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity2.Migrations
{
    /// <inheritdoc />
    public partial class init14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Faculty",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Raiting",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "SalaryEnable",
                table: "Students",
                newName: "Class");

            migrationBuilder.RenameColumn(
                name: "Course",
                table: "Students",
                newName: "Year");

            migrationBuilder.AddColumn<int>(
                name: "Mark1",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mark2",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mark1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Mark2",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Students",
                newName: "Course");

            migrationBuilder.RenameColumn(
                name: "Class",
                table: "Students",
                newName: "SalaryEnable");

            migrationBuilder.AddColumn<string>(
                name: "Faculty",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Raiting",
                table: "Students",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
