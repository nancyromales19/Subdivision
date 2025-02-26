using Microsoft.AspNetCore.Mvc;


namespace Subdivision.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
