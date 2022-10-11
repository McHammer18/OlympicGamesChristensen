using Microsoft.AspNetCore.Mvc;
using OlympicGamesChristensen.Models;
using System.Diagnostics;

namespace OlympicGamesChristensen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CountryContext context;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            context = context;
        }

        public ViewResult Index(string activeGame = "all",
                                   string activeCat = "all")
        {
            ViewBag.ActiveGame = activeGame;
            ViewBag.ActiveCat = activeCat;

            List<Game> games = context.Games.ToList();
            List<Category> categories = context.Categories.ToList();

            games.Insert(0, new Game { GameId = "all", GameName = "All" });
            categories.Insert(0, new Category { CategoryID = "all", CategoryName = "All" });

            ViewBag.Games = games;
            ViewBag.Categories = categories;

            IQueryable<Country> query = context.Countries;
            if (activeGame != "all")
                query = query.Where(
                    c => c.Game.GameId.ToLower() ==
                            activeGame.ToLower());
            if (activeCat != "all")
                query = query.Where(
                    c => c.Category.CategoryID.ToLower() ==
                            activeCat.ToLower());
            var countries = query.ToList();
            return View(countries);
        }
    }
}