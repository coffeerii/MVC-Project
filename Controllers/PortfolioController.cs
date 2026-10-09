using Microsoft.AspNetCore.Mvc;

namespace MVC_Project.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}