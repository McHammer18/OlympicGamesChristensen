using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OlympicGamesChristensen.Models
{
    public class Country
    {
        [Key]
        public string CountryId { get; set; }
        public string CountryName { get; set; }

        public string GameID { get; set; }
        public Game Game { get; set; }

        public string CategoryID { get; set; }
        public Category Category { get; set; }
        public string Sport { get; set; }

        public string FlagImage { get; set; }
    }
}
