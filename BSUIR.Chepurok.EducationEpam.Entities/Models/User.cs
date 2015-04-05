using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BSUIR.Chepurok.EducationEpam.Entities.Models
{
  public class User : Entity
  {
    public User()
    {
      this.News = new List<News>();
      this.Likes = new List<Like>();
      this.Badges = new List<Badge>();
      this.Topics = new List<Topic>();
      this.Posts = new List<Post>();
      this.Lessions = new List<Lession>();
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
    public virtual ICollection<Badge> Badges { get; set; }
    public virtual ICollection<Topic> Topics { get; set; }
    public virtual ICollection<Post> Posts { get; set; }
    public virtual ICollection<Lession> Lessions { get; set; }
  }
}