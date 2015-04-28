using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BSUIR.Chepurok.EducationEpam.Entities.Models
{
  public class User : Entity
  {
    public User()
    {
      this.News = new List<News>();
      this.Likes = new List<Like>();
      this.SwapBadges = new List<SwapBadge>();
      this.Topics = new List<Topic>();
      this.Posts = new List<Post>();
      this.Subscriptions = new List<Subscription>();
      this.Skills = new List<Skill>();
    }
    [Key]
    public int UserID { get; set; }
    public int RoleID { get; set; }
    public string Firstname { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Image { get; set; }
    public string Password { get; set; }
    public string PostInCompany { get; set; }
    public virtual Role Role { get; set; }
    public virtual ICollection<Like> Likes { get; set; }
    public virtual ICollection<News> News { get; set; }
    public virtual ICollection<SwapBadge> SwapBadges { get; set; }
    public virtual ICollection<Topic> Topics { get; set; }
    public virtual ICollection<Post> Posts { get; set; }
    public virtual ICollection<Subscription> Subscriptions { get; set; }
    public virtual ICollection<Skill> Skills { get; set; }
  }
}