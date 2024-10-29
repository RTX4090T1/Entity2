using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity2.Migrations
{
    /// <inheritdoc />
    public partial class init32 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mark1",
                table: "SportResults");

            migrationBuilder.DropColumn(
                name: "Mark2",
                table: "SportResults");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "SportResults",
                newName: "Result");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "SportResults",
                newName: "SportType");

            migrationBuilder.RenameColumn(
                name: "Class",
                table: "SportResults",
                newName: "Medal");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SportType",
                table: "SportResults",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "Result",
                table: "SportResults",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "Medal",
                table: "SportResults",
                newName: "Class");

            migrationBuilder.AddColumn<int>(
                name: "Mark1",
                table: "SportResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mark2",
                table: "SportResults",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
