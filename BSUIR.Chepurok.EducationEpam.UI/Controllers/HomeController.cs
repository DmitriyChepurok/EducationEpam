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
    private readonly IServiceBll<BadgeEntity> _badgeService;
    private readonly IServiceBll<SwapBadgeEntity> _swapService;

    public HomeController(
      IUserServiceBll userService,
      IServiceBll<NewsEntity> newsService,
      IServiceBll<CategoryEntity> categoryService,
      IServiceBll<LessionEntity> lessionService,
      IServiceBll<BadgeEntity> badgeService,
      IServiceBll<SwapBadgeEntity> swapService)
    {
      _userService = userService;
      _newsService = newsService;
      _categoryService = categoryService;
      _lessionService = lessionService;
      _badgeService = badgeService;
      _swapService = swapService;
    }

    public ActionResult Dashboard()
    {
      var user = _userService.FindByEmail(User.Identity.Name);
      var viewModel = new DashboardViewModel
      {
        SwapBadges = _swapService.SelectAll().Where(p => p.UserToID == user.UserID),
        Profile = user
      };
      return View(viewModel);
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

    [HttpGet]
    public async Task<ActionResult> AddBadge(int userId)
    {
      var user = await _userService.FindAsync(userId);
      var model = new AdditionBadgeViewModel{
        Badges = _badgeService.SelectAll(),
        UserNameTo = user.NameUser,
        UserToID = user.UserID
      };
      return View(model);
    }

    [HttpPost]
    public ActionResult AddBadge(AdditionBadgeViewModel entity)
    {
      var user = _userService.FindByEmail(User.Identity.Name);
      var swapEntity = new SwapBadgeEntity
      {
        BadgeID = entity.BadgeID,
        Comment = entity.Comment,
        Created = DateTime.Now.ToString("F"),
        UserID = user.UserID,
        UserToID = entity.UserToID
      };
      _swapService.Insert(swapEntity);
      return RedirectToAction("ProfileView", "People", new { id = entity.UserToID });
    }


    public PartialViewResult ViewSwapBadge(int id)
    {
      return PartialView("ViewBadge",_swapService.Find(id));
    }
  }
}