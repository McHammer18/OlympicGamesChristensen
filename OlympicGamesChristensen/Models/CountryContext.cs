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
                    CountryId = 1,
                    CountryName = "Sweden",
                    GameID = "win",
                    CategoryID = "in",
                    Sport = "Curling",
                    FlagImage = "Sweden.png"
                },
                new Country
                {
                    CountryId = 2,
                    CountryName = "Canada",
                    GameID = "win",
                    CategoryID = "in",
                    Sport = "Curling",
                    FlagImage = "Canada.png"
                },
                new Country
                {
                    CountryId = 3,
                    CountryName = "Great Britain",
                    GameID = "win",
                    CategoryID = "in",
                    Sport = "Curling",
                    FlagImage = "GreatBritain.png"
                },
                new Country
                {
                    CountryId = 4,
                    CountryName = "Jamaica",
                    GameID = "win",
                    CategoryID = "out",
                    Sport = "Bobsleigh",
                    FlagImage = "Jamaica.png"
                },
                new Country
                {
                    CountryId = 5,
                    CountryName = "Italy",
                    GameID = "win",
                    CategoryID = "out",
                    Sport = "Bobsleigh",
                    FlagImage = "Italy.png"
                },
                new Country
                {
                    CountryId = 6,
                    CountryName = "Japan",
                    GameID = "win",
                    CategoryID = "out",
                    Sport = "Bobsleigh",
                    FlagImage = "Japan.png"
                },
                new Country
                {
                    CountryId = 7,
                    CountryName = "Germany",
                    GameID = "sum",
                    CategoryID = "in",
                    Sport = "Diving",
                    FlagImage = "Germany.png"
                },
                new Country
                {
                    CountryId = 8,
                    CountryName = "China",
                    GameID = "sum",
                    CategoryID = "out",
                    Sport = "Diving",
                    FlagImage = "China.png"
                },
                new Country
                {
                    CountryId = 9,
                    CountryName = "Mexico",
                    GameID = "sum",
                    CategoryID = "out",
                    FlagImage = "Mexico.png"
                },
                new Country
                {
                    CountryId = 10,
                    CountryName = "Brazil",
                    GameID = "sum",
                    CategoryID = "out",
                    Sport = "Road Cycling",
                    FlagImage = "Brazil.png"
                },
                new Country
                {
                    CountryId = 11,
                    CountryName = "Netherlands",
                    GameID = "sum",
                    CategoryID = "out",
                    Sport = "Road Cycling",
                    FlagImage = "Netherlands.png"
                },
                new Country
                {
                    CountryId = 12,
                    CountryName = "USA",
                    GameID = "sum",
                    CategoryID = "out",
                    Sport = "Road Cycling",
                    FlagImage = "USA.png"
                },
                new Country
                {
                    CountryId = 13,
                    CountryName = "Thailand",
                    GameID = "par",
                    CategoryID = "in",
                    Sport = "Archery",
                    FlagImage = "Thailand.png"
                },
                new Country
                {
                    CountryId = 14,
                    CountryName = "Uruguay",
                    GameID = "par",
                    CategoryID = "in",
                    Sport = "Archery",
                    FlagImage = "Uruguay.png"
                },
                new Country
                {
                    CountryId = 15,
                    CountryName = "Ukraine",
                    GameID = "par",
                    CategoryID = "in",
                    Sport = "Archery",
                    FlagImage = "Ukraine.png"
                },
                new Country
                {
                    CountryId = 16,
                    CountryName = "Austria",
                    GameID = "par",
                    CategoryID = "out",
                    Sport = "Canoe Sprint",
                    FlagImage = "Austria.png"
                },
                new Country
                {
                    CountryId = 17,
                    CountryName = "Pakistan",
                    GameID = "par",
                    CategoryID = "out",
                    Sport = "Canoe Sprint",
                    FlagImage = "Pakistan.png"
                },
                new Country
                {
                    CountryId = 18,
                    CountryName = "Zimbabwe",
                    GameID = "par",
                    CategoryID = "out",
                    Sport = "Canoe Sprint",
                    FlagImage = "Zimbabwe.png"
                },
                new Country
                {
                    CountryId = 19,
                    CountryName = "France",
                    GameID = "yth",
                    CategoryID = "in",
                    Sport = "Break Dancing",
                    FlagImage = "France.png"
                },
                new Country
                {
                    CountryId = 20,
                    CountryName = "Cyprus",
                    GameID = "yth",
                    CategoryID = "in",
                    Sport = "Break Dancing",
                    FlagImage = "Cyprus.png"
                },
                new Country
                {
                    CountryId = 21,
                    CountryName = "Russia",
                    GameID = "yth",
                    CategoryID = "out",
                    Sport = "Break Dancing",
                    FlagImage = "Russia.png"
                },
                new Country
                {
                    CountryId = 22,
                    CountryName = "Finland",
                    GameID = "yth",
                    CategoryID = "out",
                    Sport = "Skateboarding",
                    FlagImage = "Finland.png"
                },
                new Country
                {
                    CountryId = 23,
                    CountryName = "Slovakia",
                    GameID = "yth",
                    CategoryID = "out",
                    Sport = "Skateboarding",
                    FlagImage = "Slovakia.png"
                },
                new Country
                {
                    CountryId = 24,
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
