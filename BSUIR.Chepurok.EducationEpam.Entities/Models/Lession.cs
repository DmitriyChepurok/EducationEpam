using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;

namespace BSUIR.Chepurok.EducationEpam.Entities.Models
{
  public class Lession : Entity
  {
    public Lession()
    {
      this.Subscriptions = new List<Subscription>();
      this.Comments = new List<Comment>();
      this.Tests = new List<Test>();
    }
    public int LessionID { get; set; }
    public int CreatorID { get; set; }
    public int CategoryID { get; set; }
    public string TitleLession { get; set; }
    public string Description { get; set; }
    public DateTime DateAndTime { get; set; }
    public string Place { get; set; }
    public string Link { get; set; }
    public bool IsApproved { get; set; }
    public virtual Category Category { get; set; }
    public virtual ICollection<Subscription> Subscriptions { get; set; }
    public virtual ICollection<Comment> Comments { get; set; }
    public virtual ICollection<Test> Tests { get; set; }
  }
}