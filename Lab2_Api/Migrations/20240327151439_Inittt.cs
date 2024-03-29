using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2_Api.Migrations
{
    /// <inheritdoc />
    public partial class Inittt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    wejscie = table.Column<string>(type: "TEXT", nullable: false),
                    Temp = table.Column<float>(type: "REAL", nullable: false),
                    Lat = table.Column<float>(type: "REAL", nullable: false),
                    Lon = table.Column<float>(type: "REAL", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weather");
        }
    }
}
