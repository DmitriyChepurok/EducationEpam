using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSUIR.Chepurok.EducationEpam.Entities.Models
{
  public class Badge : Entity
  {
    public Badge()
    {
      this.Users = new List<User>();
    }
    public int BadgeID { get; set; }
    public int BadgeTo { get; set; }
    public string Image { get; set; }
    public string Description { get; set; }
    public virtual ICollection<User> Users { get; set; }
  }
}
