
using choreTracker.Models;

namespace ChoreScore.Repositories;

public class ChoresRepository
{

  private List<Chore> _FakeDb;

  public ChoresRepository()
  {

    // id = Guid.NewGuid() //< ---possibly add generate unique ID here.
    _FakeDb = new List<Chore>();
    _FakeDb.Add(new Chore(1, "Dishes", 10, false, true));
    _FakeDb.Add(new Chore(2, "Trash", 2, false, true));
    _FakeDb.Add(new Chore(3, "Dusting", 15, false, false));
  }

  internal Chore CreateChore(Chore choreData)
  {
    int choreId = _FakeDb[_FakeDb.Count - 1].Id;  //weirdness for sequenced ids
    choreData.Id = choreId + 1;
    _FakeDb.Add(choreData);
    return choreData;
  }

  internal List<Chore> getAllChores()
  {
    return _FakeDb;
  }

  internal Chore GetChoreById(int choreId)
  {
    Chore chore = _FakeDb.Find(c => c.Id == choreId);
    return chore;
  }

  internal void DeleteChore(int choreId)
  {
    Chore chore = _FakeDb.Find(c => c.Id == choreId);
    _FakeDb.Remove(chore);
  }
}
