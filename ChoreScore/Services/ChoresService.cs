
using choreTracker.Models;

namespace ChoreScore.Services;


public class ChoresService
{

  private readonly ChoresRepository _repo;

  public ChoresService(ChoresRepository repo)
  {
    _repo = repo;
  }

  internal Chore CreateChore(Chore choreData)
  {
    Chore chore = _repo.CreateChore(choreData);
    return chore;
  }

  internal List<Chore> getChores()
  {
    List<Chore> chores = _repo.getAllChores();
    return chores;
  }

  internal Chore GetChoreById(int choreId)
  {
    Chore chore = _repo.GetChoreById(choreId);
    return chore;
  }

  internal string DeleteChore(int choreId)
  {
    Chore chore = this.GetChoreById(choreId);
    _repo.DeleteChore(choreId);

    return $"{chore.Name} has been removed from the list!";
  }
}