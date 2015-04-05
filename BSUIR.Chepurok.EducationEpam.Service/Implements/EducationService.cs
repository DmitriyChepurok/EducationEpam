using BSUIR.Chepurok.EducationEpam.Entities.Models;
using BSUIR.Chepurok.EducationEpam.Service.Interfaces;
using Repository.Pattern.Infrastructure;
using Repository.Pattern.Repositories;
using Service.Pattern;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;

namespace BSUIR.Chepurok.EducationEpam.Service.Implements
{
  public class EducationService<T> : Service<T>, IEducationService<T> where T : class, IObjectState
  {
    private readonly IRepositoryAsync<T> _repository;

    public EducationService(
      IRepositoryAsync<T> repository) : base(repository)
    {
      _repository = repository;
    }

    public async Task<IEnumerable<T>> SelectAllAsync()
    {
      var list = _repository.Queryable();
      return await list.ToListAsync();
    }

    public IEnumerable<T> SelectAll()
    {
      return _repository.Queryable().ToList();
    }
  }
}