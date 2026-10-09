using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Data;

namespace PortfolioApp.Controllers;

// Page: Contact  (URL: /Contact)
public class ContactController : Controller
{
    public IActionResult Index()
    {
        var profile = ProfileData.Get();
        ViewData["FullName"] = profile.FullName;
        return View(profile.Contact);
    }
}
