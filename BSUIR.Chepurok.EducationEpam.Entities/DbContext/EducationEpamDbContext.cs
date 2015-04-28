using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Repository.Pattern.Ef6;
using BSUIR.Chepurok.EducationEpam.Entities.Models;

namespace BSUIR.Chepurok.EducationEpam.Entities.DbContext
{
  public partial class EducationEpamDbContext : DataContext
  {
    static EducationEpamDbContext()
    {
      Database.SetInitializer<EducationEpamDbContext>(new DropCreateDatabaseIfModelChanges<EducationEpamDbContext>());
    }

    public EducationEpamDbContext()
      : base("name=EducationEpamDbContext")
    {
      this.Configuration.ProxyCreationEnabled = true;
      this.Configuration.LazyLoadingEnabled = true;
    }

    public DbSet<Answer> Answer { get; set; }
    public DbSet<Badge> Badge { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Comment> Comment { get; set; }
    public DbSet<Lession> Lession { get; set; }
    public DbSet<Like> Like { get; set; }
    public DbSet<News> News { get; set; }
    public DbSet<Post> Post { get; set; }
    public DbSet<Question> Question { get; set; }
    public DbSet<Role> Role { get; set; }
    public DbSet<Test> Test { get; set; }
    public DbSet<Topic> Topic { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Subscription> Subscriptions { get; set; }
    public DbSet<Skill> Skill { get; set; }
    public DbSet<SwapBadge> SwapBadges { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Topic>().HasMany(e => e.Posts).WithRequired(e => e.Topic).WillCascadeOnDelete(false);
      modelBuilder.Entity<User>().HasMany(e => e.Topics).WithRequired(e => e.User).WillCascadeOnDelete(false);
      modelBuilder.Entity<User>().HasMany(e => e.Posts).WithRequired(e => e.User).WillCascadeOnDelete(false);
    }
  }
}