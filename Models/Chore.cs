using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoreScore.Models;

public class Chore
{

  public Chore(string name, int id)
  {
    Name = name;
    Id = id;
  }

  public string Name { get; set; }
  public int Id { get; set; }
  public bool IsDone { get; private set; } = false;

  public void getErDone()
  {
    this.IsDone = true;
  }
}
