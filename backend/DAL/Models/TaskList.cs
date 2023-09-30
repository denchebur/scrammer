namespace DAL.Models;

public class TaskList
{
    public int TaskListId { get; set; }
    public string TaskListName { get; set; }
    public List<Task> Tasks { get; set; }
    
}