using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project_Onion_architecture.Models;
using Project_Onion_architecture.ViewModels;

namespace Project_Onion_architecture.Controllers
{
    public class ContactController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        public ContactController(UserManager<AppUser>userManager,SignInManager<AppUser>signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;

        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {
            if(ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.UserName!, model.Password!, false, false);
                if(result.Succeeded)
                {
                    return RedirectToAction("Create","Category");
                }
                return View(model);
            }
            return View(model);
        }
        
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Register(Register model)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                };
                var result= await userManager.CreateAsync(user,model.Password);
                if(result.Succeeded)
                {
                    var SignInResult = await signInManager.PasswordSignInAsync(user.UserName, model.Password, false, false);
                    if (SignInResult.Succeeded)
                    {
                        return RedirectToAction("Create", "Category");
                    }
                }
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index","Category");
        }
    }
}
