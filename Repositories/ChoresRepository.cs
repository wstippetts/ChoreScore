using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoreScore.Repositories
{
  public class ChoresRepository
  {
    private List<Chore> dbChores = new List<Chore>();

    public ChoresRepository()
    {
      dbChores.Add(new Chore("draw the cuss owl", 7346387, ));
      dbChores.Add(new Chore("give the owl some eyes", 8377663));
    }
    internal Chore CreateChore(Chore choreData)
    {
      choreData.Id = dbChores[dbChores.Count - 1].Id + 1;
      dbChores.Add(new Chore(choreData.Name, ChoresData.Id));
      return choreData;
    }

    internal List<Chore> GetAllChores()
    {
      return dbChores;
    }
  }
}