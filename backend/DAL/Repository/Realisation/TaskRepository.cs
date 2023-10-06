using DAL.DatabaseContextDir;
using DAL.Repository.Interfaces;
using Task = DAL.Models.Task;

namespace DAL.Repository.Realisation;

public class TaskRepository : IRepository<Task>
{
    private readonly DatabaseContext ctx;
    public TaskRepository(DatabaseContext ctx)
    {
        this.ctx = ctx;
    }

    public void Create(Task item)
    {
        ctx.Tasks.Add(item);
    }

    public void Delete(int id)
    {
        var item = ctx.Tasks.Find(id);
        if(item != null)
            ctx.Tasks.Remove(item);
    }

    public IEnumerable<Task> Find(Func<Task, bool> predicate)
    {
        return ctx.Tasks.Where(predicate).ToList();
    }

    public Task Get(int id)
    {
        return ctx.Tasks.Find(id);
    }

    public IEnumerable<Task> GetAll()
    {
        return ctx.Tasks.ToList();
    }

    public void Update(Task item)
    {
        ctx.Tasks.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    }
}