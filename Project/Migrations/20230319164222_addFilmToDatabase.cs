using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class addFilmToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmIMG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmEP = table.Column<int>(type: "int", nullable: false),
                    FilmView = table.Column<int>(type: "int", nullable: false),
                    FilmLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmMeta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmHide = table.Column<int>(type: "int", nullable: false),
                    FilmOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
