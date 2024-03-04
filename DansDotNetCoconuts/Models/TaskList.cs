class TaskList
{
  private readonly List<Task> tasks;

  public TaskList()
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
}
