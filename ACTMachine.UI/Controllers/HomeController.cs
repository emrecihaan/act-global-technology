using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace ACTMachine.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Machinery()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }

        public IActionResult EFMDetail()
        {
            return View();
        }

        public IActionResult AutomoticWorkCellDetail()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Skw25Detail()
        {
            return View();
        }

        public IActionResult Production()
        {
            return View();
        }

        public IActionResult BrazingMachine()
        {
            return View();
        }
    }
}
