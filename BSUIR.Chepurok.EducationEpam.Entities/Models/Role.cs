using Repository.Pattern.Ef6;
using System.Collections.Generic;

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