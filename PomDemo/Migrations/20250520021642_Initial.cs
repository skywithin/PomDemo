using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PomDemo.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Servers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "City", "IsOnline", "Name" },
                values: new object[,]
                {
                    { 1, "Toronto", true, "Server1" },
                    { 2, "Toronto", true, "Server2" },
                    { 3, "Toronto", false, "Server3" },
                    { 4, "Toronto", false, "Server4" },
                    { 5, "Montreal", false, "Server5" },
                    { 6, "Montreal", false, "Server6" },
                    { 7, "Montreal", true, "Server7" },
                    { 8, "Ottawa", false, "Server8" },
                    { 9, "Ottawa", true, "Server9" },
                    { 10, "Calgary", false, "Server10" },
                    { 11, "Calgary", false, "Server11" },
                    { 12, "Halifax", true, "Server12" },
                    { 13, "Halifax", false, "Server13" },
                    { 14, "Halifax", true, "Server14" },
                    { 15, "Halifax", true, "Server15" },
                    { 16, "Halifax", false, "Server16" },
                    { 17, "Halifax", true, "Server17" },
                    { 18, "Halifax", false, "Server18" },
                    { 19, "Halifax", true, "Server19" },
                    { 20, "Halifax", true, "Server20" },
                    { 21, "Halifax", true, "Server21" },
                    { 22, "Halifax", true, "Server22" },
                    { 23, "Halifax", true, "Server23" },
                    { 24, "Halifax", false, "Server24" },
                    { 25, "Halifax", false, "Server25" },
                    { 26, "Halifax", true, "Server26" },
                    { 27, "Halifax", false, "Server27" },
                    { 28, "Halifax", false, "Server28" },
                    { 29, "Halifax", true, "Server29" },
                    { 30, "Halifax", false, "Server30" },
                    { 31, "Halifax", false, "Server31" },
                    { 32, "Halifax", false, "Server32" },
                    { 33, "Halifax", true, "Server33" },
                    { 34, "Halifax", true, "Server34" },
                    { 35, "Halifax", false, "Server35" },
                    { 36, "Halifax", true, "Server36" },
                    { 37, "Halifax", true, "Server37" },
                    { 38, "Halifax", true, "Server38" },
                    { 39, "Halifax", true, "Server39" },
                    { 40, "Halifax", true, "Server40" },
                    { 41, "Halifax", true, "Server41" },
                    { 42, "Halifax", false, "Server42" },
                    { 43, "Halifax", true, "Server43" },
                    { 44, "Halifax", false, "Server44" },
                    { 45, "Halifax", true, "Server45" },
                    { 46, "Halifax", true, "Server46" },
                    { 47, "Halifax", true, "Server47" },
                    { 48, "Halifax", true, "Server48" },
                    { 49, "Halifax", true, "Server49" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Servers");
        }
    }
}
