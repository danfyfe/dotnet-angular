
class Tasks
{
  private readonly List<Task> tasks;

  public Tasks()
  {
    tasks = new List<Task>();
  }

  public List<Task> AddTask(Task task)
  {
    tasks.Add(task);
    return tasks;
  }

  public List<Task> RemoveTask(Task task)
  {
    tasks.Remove(task);
    return tasks;
  }

  public List<Task> GetAllTasks()
  {
    return tasks;
  }

  public static implicit operator List<object>(Tasks v)
  {
    throw new NotImplementedException();
  }
}
