using Microsoft.Net.Http.Headers;

namespace choreTracker.Models;

public class Chore
{
  public int Id { get; set; }
  public string Name { get; set; }
  public int TimeToComplete { get; set; }
  public bool IsCompleted { get; set; }
  public bool IsImportant { get; set; }

  public Chore(int id, string name, int timeToComplete, bool isCompleted, bool isImportant)
  {
    Id = id;
    Name = name;
    TimeToComplete = timeToComplete;
    IsCompleted = isCompleted;
    IsImportant = isImportant;
  }
}