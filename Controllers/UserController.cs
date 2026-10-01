using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var users = UserModel.GetAll();
            ViewData["Title"] = "MVC Member List";
            return View(users);
        }

        [HttpPost]
        public IActionResult Create(string name, string role)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(role))
            {
                UserModel.Add(new UserModel { Name = name, Role = role });
            }
            return RedirectToAction(nameof(Index));
        }
    }
}