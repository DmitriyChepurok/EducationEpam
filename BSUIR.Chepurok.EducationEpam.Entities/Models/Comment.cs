using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSUIR.Chepurok.EducationEpam.Entities.Models
{
  public class Comment : Entity
  {
    public int CommentID { get; set; }
    public int LessionID { get; set; }
    public int UserID { get; set; }
    public string ContentComment { get; set; }
    public DateTime Created { get; set; }
    public virtual User User { get; set; }
    public virtual Lession Lession { get; set; }
  }
}