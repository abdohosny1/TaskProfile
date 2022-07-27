using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using ProfileWeb.ViewModel;
using ProfileWithCore.Model.identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileWeb.Controllers
{
    public class AccountController : Controller
    {
    //    private readonly UserManager<ApplicationUser> _userManager;
    //    private readonly SignInManager<ApplicationUser> _signInManager;
    //    private readonly IHtmlLocalizer<AccountController> _localizer;

    //    public AccountController(
    //UserManager<ApplicationUser> userManager,
    //SignInManager<ApplicationUser> signInManager,
    //IHtmlLocalizer<AccountController> localizer
    //)
    //    {
    //        _userManager = userManager;
    //        _signInManager = signInManager;
    //        _localizer = localizer;
    //    }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
            //var response = new RegisterVM();
            //return View(response);
        }

        //[HttpPost]
        //public async Task<IActionResult> Register(RegisterVM registerVM)
        //{
        //    if (!ModelState.IsValid) return View(registerVM);

        //    var user = await _userManager.FindByEmailAsync(registerVM.Emaill);

        //    if (user != null)
        //    {
        //        TempData["Error"] = _localizer["inUse"];
        //        return View(registerVM);

        //    }
        //    var newUser = new ApplicationUser()
        //    {
        //        FullName = registerVM.FullName,
        //        Email = registerVM.Emaill,
        //        UserName = registerVM.Emaill,
        //    };

        //    var newUserResponse = await _userManager.CreateAsync(newUser, registerVM.Password);
        //    if (newUserResponse.Succeeded)

        //        await _userManager.AddToRoleAsync(newUser, UserRoles.User);

        //    //update
        //    var result = await _signInManager.PasswordSignInAsync(newUser, registerVM.Password, false, false);
        //    HttpContext.Session.SetString("USERID", $"{newUser.Id}");

          
        //    return RedirectToAction("Index", "Home");




        //}

    }
}
