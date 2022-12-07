using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name = values.Name;
            userEditViewModel.LastName = values.LastName;
            userEditViewModel.Email = values.Email;
            userEditViewModel.Gender = values.Gender;
            return View(userEditViewModel);
        }
        [HttpPost]

        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user =await _userManager.FindByNameAsync(User.Identity.Name);
            user.Name= p.Name;
            user.Email = p.Email;
            user.Gender = p.Gender;
            user.LastName=p.LastName;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            var result=await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Product");
            }
            else
            {

            }
            return View(result);
        }

     
        
    }
}
