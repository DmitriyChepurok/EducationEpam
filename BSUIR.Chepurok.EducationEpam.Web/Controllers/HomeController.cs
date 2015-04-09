using BSUIR.Chepurok.EducationEpam.BLL.Entities;
using BSUIR.Chepurok.EducationEpam.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BSUIR.Chepurok.EducationEpam.Web.Controllers
{
  public class HomeController : Controller
  {
    private readonly IRoleServiceBLL _roleService;

    public HomeController(
      IRoleServiceBLL roleServiceBLL)
    {
      _roleService = roleServiceBLL;
    }

    public ActionResult Index()
    {
      return View();
    }

    public ActionResult About()
    {
      //var entity = _roleService.Find(1);
      //entity.NameRole = "Admin";
      //_roleService.Update(entity);
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}