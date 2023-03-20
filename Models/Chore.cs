using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoreScore.Models
{
  public class Chore(string name, int id, bool isDone, )
    {
        Name = name;
        Id = id;
        IsDone = isDone;
    }

public string Name { get; set; }
public int Id { get; set; }
public bool IsDone { get; set; }
    
}