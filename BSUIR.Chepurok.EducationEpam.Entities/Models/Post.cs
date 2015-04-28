using Repository.Pattern.Ef6;
using System;

namespace BSUIR.Chepurok.EducationEpam.Entities.Models
{
  public class Post : Entity
  {
    public int PostID { get; set; }
    public int UserID { get; set; }
    public int TopicID { get; set; }
    public string Text { get; set; }
    public DateTime Created { get; set; }
    public virtual User User { get; set; }
    public virtual Topic Topic { get; set; }
  }
}