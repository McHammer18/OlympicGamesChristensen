using Microsoft.EntityFrameworkCore;

namespace OlympicGamesChristensen.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options)
            : base(options) { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>().HasData(
                new Game { GameId = "win", GameName = "Winter Olympics"},
                new Game { GameId = "sum", GameName = "Summer Olympics" },
                new Game { GameId = "par", GameName = "Paralympic Olympics" },
                new Game { GameId = "yth", GameName = "Youth Olympics" }

                );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = "in", CategoryName = "Indoor Olympics"},
                new Category { CategoryID = "out", CategoryName = "Outdoor Olympics"}
                );

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    ID = 1,
                    CountryId = "swd",
                    CountryName = "Sweden",
                    GameID = "win",
                    CategoryID = "in",
                    Sport = "Curling",
                    FlagImage = "Sweden.png"
                },
                new Country
                {
                    ID = 2,
                    CountryId = "cnd",
                    CountryName = "Canada",
                    GameID = "win",
                    CategoryID = "in",
                    Sport = "Curling",
                    FlagImage = "Canada.png"
                },
                new Country
                {
                    ID = 3,
                    CountryId = "gbt",
                    CountryName = "Great Britain",
                    GameID = "win",
                    CategoryID = "in",
                    Sport = "Curling",
                    FlagImage = "GreatBritain.png"
                },
                new Country
                {
                    ID = 4,
                    CountryId = "jam",
                    CountryName = "Jamaica",
                    GameID = "win",
                    CategoryID = "out",
                    Sport = "Bobsleigh",
                    FlagImage = "Jamaica.png"
                },
                new Country
                {
                    ID = 5,
                    CountryId = "ity",
                    CountryName = "Italy",
                    GameID = "win",
                    CategoryID = "out",
                    Sport = "Bobsleigh",
                    FlagImage = "Italy.png"
                },
                new Country
                {
                    ID = 6,
                    CountryId = "jap",
                    CountryName = "Japan",
                    GameID = "win",
                    CategoryID = "out",
                    Sport = "Bobsleigh",
                    FlagImage = "Japan.png"
                },
                new Country
                {
                    ID = 7,
                    CountryId = "gem",
                    CountryName = "Germany",
                    GameID = "sum",
                    CategoryID = "in",
                    Sport = "Diving",
                    FlagImage = "Germany.png"
                },
                new Country
                {
                    ID = 8,
                    CountryId = "cin",
                    CountryName = "China",
                    GameID = "sum",
                    CategoryID = "in",
                    Sport = "Diving",
                    FlagImage = "China.png"
                },
                new Country
                {
                    ID = 9,
                    CountryId = "mex",
                    CountryName = "Mexico",
                    GameID = "sum",
                    CategoryID = "in",
                    Sport = "Diving",
                    FlagImage = "Mexico.png"
                },
                new Country
                {
                    ID = 10,
                    CountryId = "baz",
                    CountryName = "Brazil",
                    GameID = "sum",
                    CategoryID = "out",
                    Sport = "Road Cycling",
                    FlagImage = "Brazil.png"
                },
                new Country
                {
                    ID = 11,
                    CountryId = "net",
                    CountryName = "Netherlands",
                    GameID = "sum",
                    CategoryID = "out",
                    Sport = "Road Cycling",
                    FlagImage = "Netherlands.png"
                },
                new Country
                {
                    ID = 12,
                    CountryId = "usa",
                    CountryName = "USA",
                    GameID = "sum",
                    CategoryID = "out",
                    Sport = "Road Cycling",
                    FlagImage = "USA.png"
                },
                new Country
                {
                    ID = 13,
                    CountryId = "tai",
                    CountryName = "Thailand",
                    GameID = "par",
                    CategoryID = "in",
                    Sport = "Archery",
                    FlagImage = "Thailand.png"
                },
                new Country
                {
                    ID = 14,
                    CountryId = "urg",
                    CountryName = "Uruguay",
                    GameID = "par",
                    CategoryID = "in",
                    Sport = "Archery",
                    FlagImage = "Uruguay.png"
                },
                new Country
                {
                    ID = 15,
                    CountryId = "ukr",
                    CountryName = "Ukraine",
                    GameID = "par",
                    CategoryID = "in",
                    Sport = "Archery",
                    FlagImage = "Ukraine.png"
                },
                new Country
                {
                    ID = 16,
                    CountryId = "aus",
                    CountryName = "Austria",
                    GameID = "par",
                    CategoryID = "out",
                    Sport = "Canoe Sprint",
                    FlagImage = "Austria.png"
                },
                new Country
                {
                    ID = 17,
                    CountryId = "pak",
                    CountryName = "Pakistan",
                    GameID = "par",
                    CategoryID = "out",
                    Sport = "Canoe Sprint",
                    FlagImage = "Pakistan.png"
                },
                new Country
                {
                    ID = 18,
                    CountryId = "zim",
                    CountryName = "Zimbabwe",
                    GameID = "par",
                    CategoryID = "out",
                    Sport = "Canoe Sprint",
                    FlagImage = "Zimbabwe.png"
                },
                new Country
                {
                    ID = 19,
                    CountryId = "fan",
                    CountryName = "France",
                    GameID = "yth",
                    CategoryID = "in",
                    Sport = "Break Dancing",
                    FlagImage = "France.png"
                },
                new Country
                {
                    ID = 20,
                    CountryId = "cyp",
                    CountryName = "Cyprus",
                    GameID = "yth",
                    CategoryID = "in",
                    Sport = "Break Dancing",
                    FlagImage = "Cyprus.png"
                },
                new Country
                {
                    ID = 21,
                    CountryId = "rus",
                    CountryName = "Russia",
                    GameID = "yth",
                    CategoryID = "out",
                    Sport = "Break Dancing",
                    FlagImage = "Russia.png"
                },
                new Country
                {
                    ID = 22,
                    CountryId = "fin",
                    CountryName = "Finland",
                    GameID = "yth",
                    CategoryID = "out",
                    Sport = "Skateboarding",
                    FlagImage = "Finland.png"
                },
                new Country
                {
                    ID = 23,
                    CountryId = "slo",
                    CountryName = "Slovakia",
                    GameID = "yth",
                    CategoryID = "out",
                    Sport = "Skateboarding",
                    FlagImage = "Slovakia.png"
                },
                new Country
                {
                    ID = 24,
                    CountryId = "por",
                    CountryName = "Portugal",
                    GameID = "yth",
                    CategoryID = "out",
                    Sport = "Skateboarding",
                    FlagImage = "Portugal.png"
                }
             );
        }


    }
}
