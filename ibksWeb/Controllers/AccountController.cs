using Business.Abstract;
using Business.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ibksWeb.Controllers
{
    public class AccountController : Controller
    {
        IAuthService _authManager;

        public AccountController(IAuthService authService)
        {
            _authManager = authService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            UserForLoginDto userForLoginDto = new UserForLoginDto
            {
                Email = email,
                Password = password
            };

            var result = _authManager.Login(userForLoginDto);

            if (result.Success)
            {
                HttpContext.Session.SetString("UserLoggedIn", "true");

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Geçersiz e-posta veya şifre.";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserLoggedIn");

            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            ViewBag.Message = "Lütfen yetkili ile iletişime geçin.";
            return View("Login");
        }

        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.Message = "Lütfen yetkili ile iletişime geçin.";
            return View("Login");
        }
    }
}
