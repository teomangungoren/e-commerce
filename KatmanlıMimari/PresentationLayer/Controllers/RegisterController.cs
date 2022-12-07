using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PresentationLayer.Models;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel model)
        {
            AppUser appUser = new AppUser()
            {
                Name = model.Name,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.Username,

            };
            if (model.Password == model.ConfirmPassword)
            {
                var result=await _userManager.CreateAsync(appUser,model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(model);
        }

    }
}
