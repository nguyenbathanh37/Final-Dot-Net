using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class updateDatabaseVer4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FilmTypeDescription",
                table: "FilmTypes",
                newName: "FilmTypeMeta");

            migrationBuilder.AddColumn<bool>(
                name: "FilmTypeHide",
                table: "FilmTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "FilmTypeOrder",
                table: "FilmTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "CommentHide",
                table: "Comments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilmTypeHide",
                table: "FilmTypes");

            migrationBuilder.DropColumn(
                name: "FilmTypeOrder",
                table: "FilmTypes");

            migrationBuilder.DropColumn(
                name: "CommentHide",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "FilmTypeMeta",
                table: "FilmTypes",
                newName: "FilmTypeDescription");
        }
    }
}
