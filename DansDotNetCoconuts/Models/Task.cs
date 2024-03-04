using Microsoft.AspNetCore.Components.Web;

class Task
{
  public int Id { get; }
  public required string Title { get; set; }
  public required string Description { get; set; }
  public required DateTime DueDate { get; set; }
  public bool IsComplete { get; set; }

  public Task(string title, string description, DateTime dueDate)
  {
    Title = title;
    Description = description;
    DueDate = dueDate;
    IsComplete = false;
  }

  public void MarkComplete()
  {
    IsComplete = true;
  }

  public void MarkIncomplete()
  {
    IsComplete = false;
  }

  public string GetDetails()
  {
    return $"Task {Title}: {Description}. This task is due on {DueDate}";
  }
}