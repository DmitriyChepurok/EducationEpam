using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSUIR.Chepurok.EducationEpam.Entities.Models
{
  public class Role : Entity
  {
    public Role()
    {
      this.Users = new List<User>();
    }
    public int RoleID { get; set; }
    public string NameRole { get; set; }

    public virtual ICollection<User> Users{ get; set; }
  }
}