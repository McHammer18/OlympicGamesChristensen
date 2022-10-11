using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlympicGamesChristensen.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GameName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Sport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlagImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                    table.ForeignKey(
                        name: "FK_Countries_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Countries_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { "in", "Indoor Olympics" },
                    { "out", "Outdoor Olympics" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "GameName" },
                values: new object[,]
                {
                    { "par", "Paralympic Olympics" },
                    { "sum", "Summer Olympics" },
                    { "win", "Winter Olympics" },
                    { "yth", "Youth Olympics" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CategoryID", "CountryName", "FlagImage", "GameID", "Sport" },
                values: new object[,]
                {
                    { 1, "in", "Sweden", "Sweden.png", "win", "Curling" },
                    { 2, "in", "Canada", "Canada.png", "win", "Curling" },
                    { 3, "in", "Great Britain", "GreatBritain.png", "win", "Curling" },
                    { 4, "out", "Jamaica", "Jamaica.png", "win", "Bobsleigh" },
                    { 5, "out", "Italy", "Italy.png", "win", "Bobsleigh" },
                    { 6, "out", "Japan", "Japan.png", "win", "Bobsleigh" },
                    { 7, "in", "Germany", "Germany.png", "sum", "Diving" },
                    { 8, "in", "China", "China.png", "sum", "Diving" },
                    { 9, "in", "Mexico", "Mexico.png", "sum", "Diving" },
                    { 10, "out", "Brazil", "Brazil.png", "sum", "Road Cycling" },
                    { 11, "out", "Netherlands", "Netherlands.png", "sum", "Road Cycling" },
                    { 12, "out", "USA", "USA.png", "sum", "Road Cycling" },
                    { 13, "in", "Thailand", "Thailand.png", "par", "Archery" },
                    { 14, "in", "Uruguay", "Uruguay.png", "par", "Archery" },
                    { 15, "in", "Ukraine", "Ukraine.png", "par", "Archery" },
                    { 16, "out", "Austria", "Austria.png", "par", "Canoe Sprint" },
                    { 17, "out", "Pakistan", "Pakistan.png", "par", "Canoe Sprint" },
                    { 18, "out", "Zimbabwe", "Zimbabwe.png", "par", "Canoe Sprint" },
                    { 19, "in", "France", "France.png", "yth", "Break Dancing" },
                    { 20, "in", "Cyprus", "Cyprus.png", "yth", "Break Dancing" },
                    { 21, "out", "Russia", "Russia.png", "yth", "Break Dancing" },
                    { 22, "out", "Finland", "Finland.png", "yth", "Skateboarding" },
                    { 23, "out", "Slovakia", "Slovakia.png", "yth", "Skateboarding" },
                    { 24, "out", "Portugal", "Portugal.png", "yth", "Skateboarding" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CategoryID",
                table: "Countries",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameID",
                table: "Countries",
                column: "GameID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
