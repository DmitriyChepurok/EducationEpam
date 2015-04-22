using BSUIR.Chepurok.EducationEpam.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BSUIR.Chepurok.EducationEpam.UI.Models
{
  public class LessionsCategoriesViewModel
  {
    public LessionsCategoriesViewModel()
    {
      LessionList = new List<LessionEntity>();
      CategoryList = new List<CategoryEntity>();
    }
    public IEnumerable<LessionEntity> LessionList { get; set; }
    public IEnumerable<CategoryEntity> CategoryList { get; set; }
  }
}