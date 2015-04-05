using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSUIR.Chepurok.EducationEpam.Entities.Models
{
  public class Answer : Entity
  {
    public int AnswerID { get; set; }
    public int QuestionID { get; set; }
    public string ContentAnswer { get; set; }
    public bool IsTrue { get; set; }
    public virtual Question Question { get; set; }
  }
}