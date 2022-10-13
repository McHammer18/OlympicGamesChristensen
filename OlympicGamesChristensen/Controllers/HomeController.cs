using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using OlympicGamesChristensen.Models;
using System.Diagnostics;
using System.Security;

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
            var model = new CountryListViewModel
            {
                ActiveGame = activeGame,
                ActiveCat = activeCat,
                Games = context.Games.ToList(),
                Categories = context.Categories.ToList()
            };

            IQueryable<Country> query = context.Countries;
            if (activeGame != "all")
                query = query.Where(g =>
                        g.Game.GameId.ToLower() == activeGame.ToLower());
            if (activeCat != "all")
                query = query.Where(c =>
                        c.Category.CategoryID.ToLower() == activeCat.ToLower());
            model.Countries = query.ToList();
            return View(model);
        }

        public ViewResult Details(string id)
        {
            var model = new CountryViewModel
            {
                Country = context.Countries
                    .Include(c => c.Game)
                    .Include(c => c.Category)
                    .FirstOrDefault(c => c.CountryId == id),
                ActiveCat = TempData?["ActiveCat"]?.ToString() ?? "all",
                ActiveGame = TempData?["ActiveGame"]?.ToString() ?? "all"
            };
            return View(model);
        }
    }
}