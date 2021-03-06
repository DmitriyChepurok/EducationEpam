﻿using Repository.Pattern.Ef6;
using System.Collections.Generic;

namespace BSUIR.Chepurok.EducationEpam.Entities.Models
{
  public class Badge : Entity
  {
    public Badge()
    {
      this.SwapBadges = new List<SwapBadge>();
    }
    public int BadgeID { get; set; }
    public string Image { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public virtual ICollection<SwapBadge> SwapBadges { get; set; }
  }
}