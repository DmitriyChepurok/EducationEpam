using Repository.Pattern.Ef6;

namespace BSUIR.Chepurok.EducationEpam.Entities.Models
{
  public class Subscription : Entity
  {
    public int SubscriptionID { get; set; }
    public int LessionID { get; set; }
    public int UserID { get; set; }

    public virtual Lession Lession { get; set; }
    public virtual User User { get; set; }
  }
}