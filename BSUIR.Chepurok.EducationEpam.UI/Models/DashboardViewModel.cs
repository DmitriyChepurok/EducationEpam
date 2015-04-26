using BSUIR.Chepurok.EducationEpam.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BSUIR.Chepurok.EducationEpam.UI.Models
{
  public class DashboardViewModel
  {
    public DashboardViewModel()
    {
      this.Lessions = new List<LessionEntity>();
      this.SwapBadges = new List<SwapBadgeEntity>();
    }
    public IEnumerable<LessionEntity> Lessions { get; set; }
    public IEnumerable<SwapBadgeEntity> SwapBadges { get; set; }
    public UserEntity Profile { get; set; }
  }
}