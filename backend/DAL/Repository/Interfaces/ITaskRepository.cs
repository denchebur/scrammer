using Task = DAL.Models.Task;

namespace DAL.Repository.Interfaces;

public interface ITaskRepository
{
    void CreateTask(Task task);
}