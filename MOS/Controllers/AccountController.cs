using Microsoft.AspNetCore.Mvc;

namespace MOS.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
