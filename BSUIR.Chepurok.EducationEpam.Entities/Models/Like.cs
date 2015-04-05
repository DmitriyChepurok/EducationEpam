using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSUIR.Chepurok.EducationEpam.Entities.Models
{
  public class Like : Entity
  {
    public int LikeID { get; set; }
    public int UserID { get; set; }
    public int ContentID { get; set; }
    public int ContentType { get; set; }
    public virtual User User { get; set; }      
  }
}