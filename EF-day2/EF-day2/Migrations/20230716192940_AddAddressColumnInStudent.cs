using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_day2.Migrations
{
    /// <inheritdoc />
    public partial class AddAddressColumnInStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmrntId",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "DepartmrntId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
