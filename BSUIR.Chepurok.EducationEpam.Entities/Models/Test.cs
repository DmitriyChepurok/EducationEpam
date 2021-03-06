﻿using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;

namespace BSUIR.Chepurok.EducationEpam.Entities.Models
{
  public class Test : Entity
  {
    public int TestID { get; set; }
    public int LessionID { get; set; }
    public int UserID { get; set; }
    public DateTime Created { get; set; }
    public virtual Lession Lession { get; set; }
    public virtual ICollection<Question> Questions { get; set; }
    public double Score { get; set; }
  }
}