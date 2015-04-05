using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    public virtual ICollection<Lession> Lessions { get; set; }
  }
}