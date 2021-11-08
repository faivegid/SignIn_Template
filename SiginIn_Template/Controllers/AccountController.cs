using Microsoft.AspNetCore.Mvc;
using SiginIn_Template.Models.DtoModels;

namespace SiginIn_Template.Controllers
{
    public class AccountController : Controller
    {
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
        public IActionResult Login(LoginModel login)
        {
            return View();
        }
    }
}
