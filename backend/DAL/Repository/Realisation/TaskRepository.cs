using DAL.Repository.Interfaces;
using Task = DAL.Models.Task;

namespace DAL.Repository.Realisation;

public class TaskRepository : ITaskRepository
{
    public void CreateTask(Task task)
    {
        throw new NotImplementedException();
    }
}