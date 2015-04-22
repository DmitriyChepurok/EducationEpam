using BSUIR.Chepurok.EducationEpam.BLL.Entities;
using BSUIR.Chepurok.EducationEpam.BLL.Interfaces;
using BSUIR.Chepurok.EducationEpam.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BSUIR.Chepurok.EducationEpam.UI.Controllers
{  
  [Authorize]
  public class HomeController : Controller
  {
    private readonly IUserServiceBll _userService;
    private readonly IServiceBll<NewsEntity> _newsService;
    private readonly IServiceBll<CategoryEntity> _categoryService;
    private readonly IServiceBll<LessionEntity> _lessionService;

    public HomeController(
      IUserServiceBll userService,
      IServiceBll<NewsEntity> newsService,
      IServiceBll<CategoryEntity> categoryService,
      IServiceBll<LessionEntity> lessionService)
    {
      _userService = userService;
      _newsService = newsService;
      _categoryService = categoryService;
      _lessionService = lessionService;
    }

    public ActionResult Dashboard()
    {
      var user = _userService.FindByEmail(User.Identity.Name);
      return View(user);
    }

    public ActionResult Lessions()
    {
      var list = new LessionsCategoriesViewModel
      {
        CategoryList = _categoryService.SelectAll(),
        LessionList = _lessionService.SelectAll()
      };
      return View(list);
    }

    public async Task<ActionResult> News()
    {
      var list = await _newsService.SelectAllAsync();
      return View(list);
    }
  }
}