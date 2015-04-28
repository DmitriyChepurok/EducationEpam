using Repository.Pattern.Ef6;
using System.Collections.Generic;

namespace BSUIR.Chepurok.EducationEpam.Entities.Models
{
  public class Category : Entity
  {
    public Category()
    {
      this.Lessions = new List<Lession>();
    }
    public int CategoryID { get; set; }
    public string Title { get; set; }
    public string Image { get; set; }
    public virtual ICollection<Lession> Lessions { get; set; }
  }
}