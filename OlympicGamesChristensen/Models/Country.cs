using System.ComponentModel;

namespace OlympicGamesChristensen.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public string GameID { get; set; }
        public Game Game { get; set; }

        public string CategoryID { get; set; }
        public Category Category { get; set; }
        public string Sport { get; set; }

        public string FlagImage { get; set; }
    }
}
