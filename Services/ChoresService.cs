using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoreScore.Services
{
  public class ChoresService
  {
    private readonly ChoresRepository _repo;
    public ChoresService(ChoresRepository repo)
    {
      _repo = repo;
    }

  }
}