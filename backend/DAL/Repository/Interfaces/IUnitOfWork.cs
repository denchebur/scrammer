using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = DAL.Models.Task;

namespace DAL.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        IRepository<TaskList> TaskLists { get; }
        IRepository<Task> Tasks { get; }
        IRepository<Board> Boards { get; }
        void Save();
    }
}
