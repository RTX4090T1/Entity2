using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity2.Migrations
{
    /// <inheritdoc />
    public partial class init8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Productss",
                table: "Productss");

            migrationBuilder.RenameTable(
                name: "Productss",
                newName: "Students");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Students",
                newName: "Course");

            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "Students",
                newName: "SalaryEnable");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "NameSurname");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Students",
                newName: "Gender");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Faculty",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Raiting",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Productss");

            migrationBuilder.RenameColumn(
                name: "SalaryEnable",
                table: "Productss",
                newName: "Photo");

            migrationBuilder.RenameColumn(
                name: "NameSurname",
                table: "Productss",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Productss",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Course",
                table: "Productss",
                newName: "Price");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productss",
                table: "Productss",
                column: "Id");
        }
    }
}
