using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class updateDatabaseVer1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MenuLink",
                table: "Menu",
                newName: "MenuController");

            migrationBuilder.AddColumn<string>(
                name: "MenuAction",
                table: "Menu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuAction",
                table: "Menu");

            migrationBuilder.RenameColumn(
                name: "MenuController",
                table: "Menu",
                newName: "MenuLink");
        }
    }
}
