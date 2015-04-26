using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSUIR.Chepurok.EducationEpam.Entities.Models
{
  public class SwapBadge : Entity
  {
    public int SwapBadgeID { get; set; }
    public int UserID { get; set; }
    public int UserToID { get; set; }
    public int BadgeID { get; set; }
    public string Comment { get; set; }
    public DateTime Created { get; set; }

    public virtual User User { get; set; }
    public virtual Badge Badge { get; set; }
  }
}