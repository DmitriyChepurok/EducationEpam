using BSUIR.Chepurok.EducationEpam.Entities.DbContext;
using BSUIR.Chepurok.EducationEpam.Service.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
  class Program
  {
    static void Main(string[] args)
    {
      var db = new EducationEpamDbContext();
      db.Database.CreateIfNotExists();
      db.Database.Initialize(true);
      Console.ReadKey();
    }
  }
}
