using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Data;

namespace PortfolioApp.Controllers;

// Page: About  (URL: /About)
public class AboutController : Controller
{
    public IActionResult Index()
    {
        var profile = ProfileData.Get();
        ViewData["FullName"] = profile.FullName;
        return View(profile.About);
    }
}
