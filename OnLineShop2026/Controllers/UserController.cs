using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Models;
namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            User user = new User("Арина", "Цагараева", "tsagaraevaarina@gmail.com");
            return View(user);
        }
    }
}
