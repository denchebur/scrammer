namespace DAL.Models;

public class Board
{
    public int BoardId { get; set; }
    public List<TaskList> TaskLists { get; set; }
    public List<User> Users { get; set; }
}