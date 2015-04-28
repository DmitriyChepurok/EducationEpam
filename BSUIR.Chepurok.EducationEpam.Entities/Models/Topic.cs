using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;

namespace BSUIR.Chepurok.EducationEpam.Entities.Models
{
  public class Topic : Entity
  {
    public Topic()
    {
      this.Posts = new List<Post>();
    }
    public int TopicID { get; set; }
    public int UserID { get; set; }
    public string NameTopic { get; set; }
    public DateTime Created { get; set; }
    public virtual User User { get; set; }
    public virtual ICollection<Post> Posts { get; set; }
  }
}