using Repository.Pattern.Ef6;
using System.Collections.Generic;

namespace BSUIR.Chepurok.EducationEpam.Entities.Models
{
  public class Question : Entity
  {
    public Question()
    {
      this.Answers = new List<Answer>();
    }
    public int QuestionID { get; set; }
    public int TestID { get; set; }
    public string ContentQuestion { get; set; }
    public virtual Test Test { get; set; }
    public virtual ICollection<Answer> Answers { get; set; }
  }
}