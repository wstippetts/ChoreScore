using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoreScore.Services;

public class ChoresService
{
  private readonly ChoresRepository _repo;
  public ChoresService(ChoresRepository repo)
  {
    _repo = repo;
  }

  public List<Chore> GetAllChores()
  {
    return _repo.GetAllChores();
  }

  internal Chore completeChore(int id)
  {
    Chore chore = this.getOneChore(id);
    chore.getErDone();
    return chore;
  }

  internal Chore CreateChore(Chore choreData)
  {
    Chore chore = _repo.CreateChore(choreData);
    return chore;
  }

  internal Chore getOneChore(int id)
  {
    Chore chore = _repo.getOneChore(id);
    if (chore == null) throw new Exception($"Chore not found, it must be done already! go get yourself a vicotry beverage!!{id}");
    return chore;
  }

  internal string RemoveChore(int choreId)
  {
    Chore chore = this.getOneChore(choreId);
    bool result = _repo.removeChore(choreId);
    if (!result) throw new Exception("Chore not found, could not remove.");
    return $"{chore.Name} completed! great work, go get yourself a victory beverage!!!";
  }
}
