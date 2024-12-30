using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MOS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        // 로그인화면 표시
        public IActionResult LogIn()
        {
            return View();
        }
        // 로그인 처리(임시)
        [HttpPost]
        public IActionResult Login(string userAccount)
        {
            if (userAccount == "seongjekim")
            {
                return RedirectToAction("Index", "Home"); // 올바른 리다이렉트
            }
            else
            {
                ViewBag.ErrorMessage = "아이디가 올바르지 않습니다.";
                return View(); // 실패 시 다시 로그인 페이지 렌더링
            }
        }
    }
}
