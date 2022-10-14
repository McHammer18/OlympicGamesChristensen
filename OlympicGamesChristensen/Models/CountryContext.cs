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
                    CountryId = "swd",
                    CountryName = "Sweden",
                    GameID = "win",
                    CategoryID = "in",
                    Sport = "Curling",
                    FlagImage = "Sweden.png"
                },
                new Country
                {
                    CountryId = "cnd",
                    CountryName = "Canada",
                    GameID = "win",
                    CategoryID = "in",
                    Sport = "Curling",
                    FlagImage = "Canada.png"
                },
                new Country
                {
                    
                    CountryId = "gbt",
                    CountryName = "Great Britain",
                    GameID = "win",
                    CategoryID = "in",
                    Sport = "Curling",
                    FlagImage = "GreatBritain.png"
                },
                new Country
                {
                    
                    CountryId = "jam",
                    CountryName = "Jamaica",
                    GameID = "win",
                    CategoryID = "out",
                    Sport = "Bobsleigh",
                    FlagImage = "Jamaica.png"
                },
                new Country
                {
                    
                    CountryId = "ity",
                    CountryName = "Italy",
                    GameID = "win",
                    CategoryID = "out",
                    Sport = "Bobsleigh",
                    FlagImage = "Italy.png"
                },
                new Country
                {
                   
                    CountryId = "jap",
                    CountryName = "Japan",
                    GameID = "win",
                    CategoryID = "out",
                    Sport = "Bobsleigh",
                    FlagImage = "Japan.png"
                },
                new Country
                {
                    
                    CountryId = "gem",
                    CountryName = "Germany",
                    GameID = "sum",
                    CategoryID = "in",
                    Sport = "Diving",
                    FlagImage = "Germany.png"
                },
                new Country
                {
                 
                    CountryId = "cin",
                    CountryName = "China",
                    GameID = "sum",
                    CategoryID = "in",
                    Sport = "Diving",
                    FlagImage = "China.png"
                },
                new Country
                {
                    
                    CountryId = "mex",
                    CountryName = "Mexico",
                    GameID = "sum",
                    CategoryID = "in",
                    Sport = "Diving",
                    FlagImage = "Mexico.png"
                },
                new Country
                {
                   
                    CountryId = "baz",
                    CountryName = "Brazil",
                    GameID = "sum",
                    CategoryID = "out",
                    Sport = "Road Cycling",
                    FlagImage = "Brazil.png"
                },
                new Country
                {
                    
                    CountryId = "net",
                    CountryName = "Netherlands",
                    GameID = "sum",
                    CategoryID = "out",
                    Sport = "Road Cycling",
                    FlagImage = "Netherlands.png"
                },
                new Country
                {
                    
                    CountryId = "usa",
                    CountryName = "USA",
                    GameID = "sum",
                    CategoryID = "out",
                    Sport = "Road Cycling",
                    FlagImage = "USA.png"
                },
                new Country
                {
                   
                    CountryId = "tai",
                    CountryName = "Thailand",
                    GameID = "par",
                    CategoryID = "in",
                    Sport = "Archery",
                    FlagImage = "Thailand.png"
                },
                new Country
                {
                  
                    CountryId = "urg",
                    CountryName = "Uruguay",
                    GameID = "par",
                    CategoryID = "in",
                    Sport = "Archery",
                    FlagImage = "Uruguay.png"
                },
                new Country
                {
                   
                    CountryId = "ukr",
                    CountryName = "Ukraine",
                    GameID = "par",
                    CategoryID = "in",
                    Sport = "Archery",
                    FlagImage = "Ukraine.png"
                },
                new Country
                {
                   
                    CountryId = "aus",
                    CountryName = "Austria",
                    GameID = "par",
                    CategoryID = "out",
                    Sport = "Canoe Sprint",
                    FlagImage = "Austria.png"
                },
                new Country
                {
                  
                    CountryId = "pak",
                    CountryName = "Pakistan",
                    GameID = "par",
                    CategoryID = "out",
                    Sport = "Canoe Sprint",
                    FlagImage = "Pakistan.png"
                },
                new Country
                {
                  
                    CountryId = "zim",
                    CountryName = "Zimbabwe",
                    GameID = "par",
                    CategoryID = "out",
                    Sport = "Canoe Sprint",
                    FlagImage = "Zimbabwe.png"
                },
                new Country
                {
              
                    CountryId = "fan",
                    CountryName = "France",
                    GameID = "yth",
                    CategoryID = "in",
                    Sport = "Break Dancing",
                    FlagImage = "France.png"
                },
                new Country
                {
                   
                    CountryId = "cyp",
                    CountryName = "Cyprus",
                    GameID = "yth",
                    CategoryID = "in",
                    Sport = "Break Dancing",
                    FlagImage = "Cyprus.png"
                },
                new Country
                {
                   
                    CountryId = "rus",
                    CountryName = "Russia",
                    GameID = "yth",
                    CategoryID = "out",
                    Sport = "Break Dancing",
                    FlagImage = "Russia.png"
                },
                new Country
                {
                   
                    CountryId = "fin",
                    CountryName = "Finland",
                    GameID = "yth",
                    CategoryID = "out",
                    Sport = "Skateboarding",
                    FlagImage = "Finland.png"
                },
                new Country
                {
                    
                    CountryId = "slo",
                    CountryName = "Slovakia",
                    GameID = "yth",
                    CategoryID = "out",
                    Sport = "Skateboarding",
                    FlagImage = "Slovakia.png"
                },
                new Country
                {
                  
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
