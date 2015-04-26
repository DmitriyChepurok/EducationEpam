using BSUIR.Chepurok.EducationEpam.BLL.Entities;
using BSUIR.Chepurok.EducationEpam.BLL.Interfaces;
using BSUIR.Chepurok.EducationEpam.UI.Models;
using BSUIR.Chepurok.EducationEpam.UI.Providers;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BSUIR.Chepurok.EducationEpam.UI.Controllers
{    
    public class AccountController : Controller
    {
      private readonly IServiceBll<UserEntity> _userService;
      
      public AccountController(IServiceBll<UserEntity> userService)
      {
        _userService = userService;
      }

      [HttpGet]
      public ActionResult Login(string returnUrl)
      {
        ViewBag.ReturnUrl = returnUrl;
        return View();
      }

      [HttpPost]
      public async Task<ActionResult> Login(LogOnViewModel viewModel, string returnUrl)
      {
        if (!ModelState.IsValid) return View(viewModel);
        if (Membership.ValidateUser(viewModel.Email, viewModel.Password))
        {
          FormsAuthentication.SetAuthCookie(viewModel.Email, viewModel.RememberMe);
          var listUsers = await _userService.SelectAllAsync();
          var user = listUsers.FirstOrDefault(u => u.Email == viewModel.Email && u.Password == viewModel.Password);
          if (Url.IsLocalUrl(returnUrl))
          {
            return Redirect(returnUrl);
          }
          if (user != null && user.RoleID == 1)
          {
            return RedirectToAction("News", "Admin");
          }
          return RedirectToAction("Dashboard", "Home");
        }
        ModelState.AddModelError("", "Неправильный логин или пароль");

        return View(viewModel);
      }

      public ActionResult Logoff()
      {
        FormsAuthentication.SignOut();
        return RedirectToAction("Login", "Account");
      }

      [HttpGet]
      public ActionResult Register()
      {
        return View();
      }

      [HttpPost]
      public async Task<ActionResult> Register(RegisterViewModel viewModel)
      {
        if (!ModelState.IsValid)
        {
          return View();
        }

        var listUsers = await _userService.SelectAllAsync();
        var anyUser = listUsers.Any(u => u.Email == viewModel.Email);
        if (anyUser)
        {
          ModelState.AddModelError("Email", "Пользователь с таким адресом уже зарегистрирован");
          return View();
        }

        MembershipUser membershipUser = await ((EducationMembershipProvider)Membership.Provider).CreateUser(viewModel.Email,
          viewModel.Password, viewModel.Firstname, viewModel.Surname,
          viewModel.Image, viewModel.Post);

        if (membershipUser != null)
        {
          FormsAuthentication.SetAuthCookie(viewModel.Email, false);

          var newListUsers = await _userService.SelectAllAsync();
          var user = newListUsers.FirstOrDefault(u => u.Email == viewModel.Email && u.Password == viewModel.Password);

          if (user != null && user.RoleID == 1)
          {
            return RedirectToAction("Projects", "Admin");
          }
          return RedirectToAction("Projects", "User");
        }
        else
        {
          ModelState.AddModelError("", "Ошибка при регистрации");
        }
        return View();
      }
        
    }
}