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
        // �α���ȭ�� ǥ��
        public IActionResult LogIn()
        {
            return View();
        }
        // �α��� ó��(�ӽ�)
        [HttpPost]
        public IActionResult Login(string userAccount)
        {
            if (userAccount == "seongjekim")
            {
                return RedirectToAction("Index", "Home"); // �ùٸ� �����̷�Ʈ
            }
            else
            {
                ViewBag.ErrorMessage = "���̵� �ùٸ��� �ʽ��ϴ�.";
                return View(); // ���� �� �ٽ� �α��� ������ ������
            }
        }
    }
}
