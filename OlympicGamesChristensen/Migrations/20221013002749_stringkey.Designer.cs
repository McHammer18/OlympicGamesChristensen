// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OlympicGamesChristensen.Models;

#nullable disable

namespace OlympicGamesChristensen.Migrations
{
    [DbContext(typeof(CountryContext))]
    [Migration("20221013002749_stringkey")]
    partial class stringkey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OlympicGamesChristensen.Models.Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = "in",
                            CategoryName = "Indoor Olympics"
                        },
                        new
                        {
                            CategoryID = "out",
                            CategoryName = "Outdoor Olympics"
                        });
                });

            modelBuilder.Entity("OlympicGamesChristensen.Models.Country", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CategoryID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CountryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlagImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Sport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("GameID");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = "in",
                            CountryId = "swd",
                            CountryName = "Sweden",
                            FlagImage = "Sweden.png",
                            GameID = "win",
                            Sport = "Curling"
                        },
                        new
                        {
                            ID = 2,
                            CategoryID = "in",
                            CountryId = "cnd",
                            CountryName = "Canada",
                            FlagImage = "Canada.png",
                            GameID = "win",
                            Sport = "Curling"
                        },
                        new
                        {
                            ID = 3,
                            CategoryID = "in",
                            CountryId = "gbt",
                            CountryName = "Great Britain",
                            FlagImage = "GreatBritain.png",
                            GameID = "win",
                            Sport = "Curling"
                        },
                        new
                        {
                            ID = 4,
                            CategoryID = "out",
                            CountryId = "jam",
                            CountryName = "Jamaica",
                            FlagImage = "Jamaica.png",
                            GameID = "win",
                            Sport = "Bobsleigh"
                        },
                        new
                        {
                            ID = 5,
                            CategoryID = "out",
                            CountryId = "ity",
                            CountryName = "Italy",
                            FlagImage = "Italy.png",
                            GameID = "win",
                            Sport = "Bobsleigh"
                        },
                        new
                        {
                            ID = 6,
                            CategoryID = "out",
                            CountryId = "jap",
                            CountryName = "Japan",
                            FlagImage = "Japan.png",
                            GameID = "win",
                            Sport = "Bobsleigh"
                        },
                        new
                        {
                            ID = 7,
                            CategoryID = "in",
                            CountryId = "gem",
                            CountryName = "Germany",
                            FlagImage = "Germany.png",
                            GameID = "sum",
                            Sport = "Diving"
                        },
                        new
                        {
                            ID = 8,
                            CategoryID = "in",
                            CountryId = "cin",
                            CountryName = "China",
                            FlagImage = "China.png",
                            GameID = "sum",
                            Sport = "Diving"
                        },
                        new
                        {
                            ID = 9,
                            CategoryID = "in",
                            CountryId = "mex",
                            CountryName = "Mexico",
                            FlagImage = "Mexico.png",
                            GameID = "sum",
                            Sport = "Diving"
                        },
                        new
                        {
                            ID = 10,
                            CategoryID = "out",
                            CountryId = "baz",
                            CountryName = "Brazil",
                            FlagImage = "Brazil.png",
                            GameID = "sum",
                            Sport = "Road Cycling"
                        },
                        new
                        {
                            ID = 11,
                            CategoryID = "out",
                            CountryId = "net",
                            CountryName = "Netherlands",
                            FlagImage = "Netherlands.png",
                            GameID = "sum",
                            Sport = "Road Cycling"
                        },
                        new
                        {
                            ID = 12,
                            CategoryID = "out",
                            CountryId = "usa",
                            CountryName = "USA",
                            FlagImage = "USA.png",
                            GameID = "sum",
                            Sport = "Road Cycling"
                        },
                        new
                        {
                            ID = 13,
                            CategoryID = "in",
                            CountryId = "tai",
                            CountryName = "Thailand",
                            FlagImage = "Thailand.png",
                            GameID = "par",
                            Sport = "Archery"
                        },
                        new
                        {
                            ID = 14,
                            CategoryID = "in",
                            CountryId = "urg",
                            CountryName = "Uruguay",
                            FlagImage = "Uruguay.png",
                            GameID = "par",
                            Sport = "Archery"
                        },
                        new
                        {
                            ID = 15,
                            CategoryID = "in",
                            CountryId = "ukr",
                            CountryName = "Ukraine",
                            FlagImage = "Ukraine.png",
                            GameID = "par",
                            Sport = "Archery"
                        },
                        new
                        {
                            ID = 16,
                            CategoryID = "out",
                            CountryId = "aus",
                            CountryName = "Austria",
                            FlagImage = "Austria.png",
                            GameID = "par",
                            Sport = "Canoe Sprint"
                        },
                        new
                        {
                            ID = 17,
                            CategoryID = "out",
                            CountryId = "pak",
                            CountryName = "Pakistan",
                            FlagImage = "Pakistan.png",
                            GameID = "par",
                            Sport = "Canoe Sprint"
                        },
                        new
                        {
                            ID = 18,
                            CategoryID = "out",
                            CountryId = "zim",
                            CountryName = "Zimbabwe",
                            FlagImage = "Zimbabwe.png",
                            GameID = "par",
                            Sport = "Canoe Sprint"
                        },
                        new
                        {
                            ID = 19,
                            CategoryID = "in",
                            CountryId = "fan",
                            CountryName = "France",
                            FlagImage = "France.png",
                            GameID = "yth",
                            Sport = "Break Dancing"
                        },
                        new
                        {
                            ID = 20,
                            CategoryID = "in",
                            CountryId = "cyp",
                            CountryName = "Cyprus",
                            FlagImage = "Cyprus.png",
                            GameID = "yth",
                            Sport = "Break Dancing"
                        },
                        new
                        {
                            ID = 21,
                            CategoryID = "out",
                            CountryId = "rus",
                            CountryName = "Russia",
                            FlagImage = "Russia.png",
                            GameID = "yth",
                            Sport = "Break Dancing"
                        },
                        new
                        {
                            ID = 22,
                            CategoryID = "out",
                            CountryId = "fin",
                            CountryName = "Finland",
                            FlagImage = "Finland.png",
                            GameID = "yth",
                            Sport = "Skateboarding"
                        },
                        new
                        {
                            ID = 23,
                            CategoryID = "out",
                            CountryId = "slo",
                            CountryName = "Slovakia",
                            FlagImage = "Slovakia.png",
                            GameID = "yth",
                            Sport = "Skateboarding"
                        },
                        new
                        {
                            ID = 24,
                            CategoryID = "out",
                            CountryId = "por",
                            CountryName = "Portugal",
                            FlagImage = "Portugal.png",
                            GameID = "yth",
                            Sport = "Skateboarding"
                        });
                });

            modelBuilder.Entity("OlympicGamesChristensen.Models.Game", b =>
                {
                    b.Property<string>("GameId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GameName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameId = "win",
                            GameName = "Winter Olympics"
                        },
                        new
                        {
                            GameId = "sum",
                            GameName = "Summer Olympics"
                        },
                        new
                        {
                            GameId = "par",
                            GameName = "Paralympic Olympics"
                        },
                        new
                        {
                            GameId = "yth",
                            GameName = "Youth Olympics"
                        });
                });

            modelBuilder.Entity("OlympicGamesChristensen.Models.Country", b =>
                {
                    b.HasOne("OlympicGamesChristensen.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OlympicGamesChristensen.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Game");
                });
#pragma warning restore 612, 618
        }
    }
}
