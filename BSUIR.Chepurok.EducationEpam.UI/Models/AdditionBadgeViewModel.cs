using BSUIR.Chepurok.EducationEpam.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BSUIR.Chepurok.EducationEpam.UI.Models
{
  public class AdditionBadgeViewModel : SwapBadgeEntity
  {
    public AdditionBadgeViewModel()
    {
      this.Badges = new List<BadgeEntity>();
    }
    public IEnumerable<BadgeEntity> Badges { get; set; }
  }
}