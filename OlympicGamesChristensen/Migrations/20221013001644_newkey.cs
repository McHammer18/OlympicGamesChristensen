using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlympicGamesChristensen.Migrations
{
    public partial class newkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 24);

            migrationBuilder.AlterColumn<string>(
                name: "CountryId",
                table: "Countries",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CategoryID", "CountryName", "FlagImage", "GameID", "Sport" },
                values: new object[,]
                {
                    { "aus", "out", "Austria", "Austria.png", "par", "Canoe Sprint" },
                    { "baz", "out", "Brazil", "Brazil.png", "sum", "Road Cycling" },
                    { "cin", "in", "China", "China.png", "sum", "Diving" },
                    { "cnd", "in", "Canada", "Canada.png", "win", "Curling" },
                    { "cyp", "in", "Cyprus", "Cyprus.png", "yth", "Break Dancing" },
                    { "fan", "in", "France", "France.png", "yth", "Break Dancing" },
                    { "fin", "out", "Finland", "Finland.png", "yth", "Skateboarding" },
                    { "gbt", "in", "Great Britain", "GreatBritain.png", "win", "Curling" },
                    { "gem", "in", "Germany", "Germany.png", "sum", "Diving" },
                    { "ity", "out", "Italy", "Italy.png", "win", "Bobsleigh" },
                    { "jam", "out", "Jamaica", "Jamaica.png", "win", "Bobsleigh" },
                    { "jap", "out", "Japan", "Japan.png", "win", "Bobsleigh" },
                    { "mex", "in", "Mexico", "Mexico.png", "sum", "Diving" },
                    { "net", "out", "Netherlands", "Netherlands.png", "sum", "Road Cycling" },
                    { "pak", "out", "Pakistan", "Pakistan.png", "par", "Canoe Sprint" },
                    { "por", "out", "Portugal", "Portugal.png", "yth", "Skateboarding" },
                    { "rus", "out", "Russia", "Russia.png", "yth", "Break Dancing" },
                    { "slo", "out", "Slovakia", "Slovakia.png", "yth", "Skateboarding" },
                    { "swd", "in", "Sweden", "Sweden.png", "win", "Curling" },
                    { "tai", "in", "Thailand", "Thailand.png", "par", "Archery" },
                    { "ukr", "in", "Ukraine", "Ukraine.png", "par", "Archery" },
                    { "urg", "in", "Uruguay", "Uruguay.png", "par", "Archery" },
                    { "usa", "out", "USA", "USA.png", "sum", "Road Cycling" },
                    { "zim", "out", "Zimbabwe", "Zimbabwe.png", "par", "Canoe Sprint" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Countries",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

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
        }
    }
}
