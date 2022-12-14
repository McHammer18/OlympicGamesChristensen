using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.IdentityModel.Tokens;
using OlympicGamesChristensen.Models;
using System.Diagnostics;
using System.Security;

namespace OlympicGamesChristensen.Controllers
{
    public class HomeController : Controller
    {
        private CountryContext context;

        public HomeController(CountryContext ctx)
        {
            context = ctx;
        }

        public ViewResult Details(string id)
        {
            var session = new CountrySession(HttpContext.Session);
            var model = new CountryViewModel
            {
                Country = context.Countries
                .Include(c => c.Game)
                .Include(c => c.Category)
                .FirstOrDefault(c => c.CountryId == id),
                ActiveGame = session.GetActiveGame(),
                ActiveCat = session.GetActiveCat()
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Add(CountryViewModel model)
        {
            model.Country = context.Countries
                .Include(c => c.Game)
                .Include(c => c.Category)
                .Where(c => c.CountryId == model.Country.CountryId)
                .FirstOrDefault();

            var session = new CountrySession(HttpContext.Session);
            var countries = session.GetMyCountries();
            countries.Add(model.Country);
            session.SetMyCountries(countries);

            return RedirectToAction("Index",
                new
                {
                    ActiveGame = session.GetActiveGame(),
                    ActiveCat = session.GetActiveCat()
                });

        }

        public IActionResult Index(CountryListViewModel model)
        {
            model.Games = context.Games.ToList();
            model.Categories = context.Categories.ToList();
            string activeGame = model.ActiveGame;
            string activeCat = model.ActiveCat;

            IQueryable<Country> query = context.Countries;

            if (activeGame != "all")
            {
                query = query.Where(
                    c => c.Game.GameId.ToLower() == activeGame.ToLower()
                    );
            }

            if (activeCat != "all")
            {
                query = query.Where(
                    c => c.Category.CategoryID.ToLower() == activeCat.ToLower()
                    );
            }

            model.Countries = query.ToList();
            return View(model);
        }
    }
}