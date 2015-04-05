using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSUIR.Chepurok.EducationEpam.Entities.Models
{
  public class News : Entity
  {
    public int NewsID { get; set; }
    public int UserID { get; set; }
    public string Title { get; set; }
    public string ContentText { get; set; }
    public DateTime Created { get; set; }
    public virtual User User { get; set; }
  }
}