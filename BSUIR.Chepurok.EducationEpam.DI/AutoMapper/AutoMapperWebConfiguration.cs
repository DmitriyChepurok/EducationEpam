using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSUIR.Chepurok.EducationEpam.DI.AutoMapper
{
  public static class AutoMapperWebConfiguration
  {
    public static void Configure()
    {
      Mapper.Initialize(cfg =>
        {
          cfg.AddProfile<EducationProfile>();
        });
    }
  }
}