using backend.Models.Enums;

namespace backend.Models;

public class Task
{
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public string TaskDescription { get; set; }
    public TaskPriorityEnum TaskPriority { get; set; }
    public DateTime TaskAddingDate { get; set; }
    public TaskStatusEnum TaskStatus { get; set; }
}