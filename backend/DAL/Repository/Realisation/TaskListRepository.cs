using DAL.DatabaseContextDir;
using DAL.Models;
using DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Realisation
{
    internal class TaskListRepository : IRepository<TaskList>
    {

        private readonly DatabaseContext ctx;

        public TaskListRepository(DatabaseContext ctx)
        {
            this.ctx = ctx;
        }

        public void Create(TaskList item)
        {
            ctx.TaskLists.Add(item);
        }

        public void Delete(int id)
        {
            var item = ctx.TaskLists.Find(id);
            if (item != null)
                ctx.TaskLists.Remove(item);
        }

        public IEnumerable<TaskList> Find(Func<TaskList, bool> predicate)
        {
            return ctx.TaskLists.Where(predicate).ToList();
        }

        public TaskList Get(int id)
        {
            return ctx.TaskLists.Find(id);
        }

        public IEnumerable<TaskList> GetAll()
        {
            return ctx.TaskLists.ToList();
        }

        public void Update(TaskList item)
        {
            ctx.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
