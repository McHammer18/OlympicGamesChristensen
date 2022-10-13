using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlympicGamesChristensen.Migrations
{
    public partial class stringkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "aus");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "baz");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "cin");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "cnd");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "cyp");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "fan");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "fin");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "gbt");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "gem");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "ity");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "jam");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "jap");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "mex");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "net");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "pak");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "por");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "rus");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "slo");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "swd");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "tai");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "ukr");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "urg");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "usa");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: "zim");

            migrationBuilder.AlterColumn<string>(
                name: "CountryId",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "ID");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "CategoryID", "CountryId", "CountryName", "FlagImage", "GameID", "Sport" },
                values: new object[,]
                {
                    { 1, "in", "swd", "Sweden", "Sweden.png", "win", "Curling" },
                    { 2, "in", "cnd", "Canada", "Canada.png", "win", "Curling" },
                    { 3, "in", "gbt", "Great Britain", "GreatBritain.png", "win", "Curling" },
                    { 4, "out", "jam", "Jamaica", "Jamaica.png", "win", "Bobsleigh" },
                    { 5, "out", "ity", "Italy", "Italy.png", "win", "Bobsleigh" },
                    { 6, "out", "jap", "Japan", "Japan.png", "win", "Bobsleigh" },
                    { 7, "in", "gem", "Germany", "Germany.png", "sum", "Diving" },
                    { 8, "in", "cin", "China", "China.png", "sum", "Diving" },
                    { 9, "in", "mex", "Mexico", "Mexico.png", "sum", "Diving" },
                    { 10, "out", "baz", "Brazil", "Brazil.png", "sum", "Road Cycling" },
                    { 11, "out", "net", "Netherlands", "Netherlands.png", "sum", "Road Cycling" },
                    { 12, "out", "usa", "USA", "USA.png", "sum", "Road Cycling" },
                    { 13, "in", "tai", "Thailand", "Thailand.png", "par", "Archery" },
                    { 14, "in", "urg", "Uruguay", "Uruguay.png", "par", "Archery" },
                    { 15, "in", "ukr", "Ukraine", "Ukraine.png", "par", "Archery" },
                    { 16, "out", "aus", "Austria", "Austria.png", "par", "Canoe Sprint" },
                    { 17, "out", "pak", "Pakistan", "Pakistan.png", "par", "Canoe Sprint" },
                    { 18, "out", "zim", "Zimbabwe", "Zimbabwe.png", "par", "Canoe Sprint" },
                    { 19, "in", "fan", "France", "France.png", "yth", "Break Dancing" },
                    { 20, "in", "cyp", "Cyprus", "Cyprus.png", "yth", "Break Dancing" },
                    { 21, "out", "rus", "Russia", "Russia.png", "yth", "Break Dancing" },
                    { 22, "out", "fin", "Finland", "Finland.png", "yth", "Skateboarding" },
                    { 23, "out", "slo", "Slovakia", "Slovakia.png", "yth", "Skateboarding" },
                    { 24, "out", "por", "Portugal", "Portugal.png", "yth", "Skateboarding" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Countries");

            migrationBuilder.AlterColumn<string>(
                name: "CountryId",
                table: "Countries",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "CountryId");
        }
    }
}
