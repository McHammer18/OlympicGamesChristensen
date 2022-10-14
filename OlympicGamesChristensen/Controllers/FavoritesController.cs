using Microsoft.AspNetCore.Mvc;
using OlympicGamesChristensen.Models;

namespace OlympicGamesChristensen.Controllers
{
    public class FavoritesController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            var session = new CountrySession(HttpContext.Session);
            var model = new CountryListViewModel
            {
                ActiveGame = session.GetActiveGame(),
                ActiveCat = session.GetActiveCat(),
                Countries = session.GetMyCountries()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new CountrySession(HttpContext.Session);
            session.RemoveMyTeams();

            TempData["message"] = "Favorite teams cleared";

            return RedirectToAction("Index", "Home",
                new
                {
                    ActiveGame = session.GetActiveGame(),
                    ActiveCat = session.GetActiveCat()
                });
        }
    }
}
