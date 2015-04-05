using BSUIR.Chepurok.EducationEpam.Entities.Models;
using Repository.Pattern.Infrastructure;
using Repository.Pattern.Repositories;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BSUIR.Chepurok.EducationEpam.Service.Interfaces
{
  public interface IEducationService<T> : IService<T> where T : IObjectState
  {
    Task<IEnumerable<T>> SelectAllAsync();
    IEnumerable<T> SelectAll();
  }
}