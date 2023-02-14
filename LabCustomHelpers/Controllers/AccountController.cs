using Microsoft.AspNetCore.Mvc;

namespace LabCustomHelpers.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
