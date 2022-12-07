using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel m)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(m.Username, m.Password,false,true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Product");
                }

                else
                {
                    ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre");
                }
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Login");
        }

    }
}
