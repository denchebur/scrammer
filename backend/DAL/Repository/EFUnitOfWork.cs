using DAL.DatabaseContextDir;
using DAL.Models;
using DAL.Repository.Interfaces;
using DAL.Repository.Realisation;


namespace DAL.Repository
{
    public class EFUnitOfWork : IUnitOfWork
    {

        private readonly DatabaseContext ctx;
        private UserRepository userRepository;
        private TaskRepository taskRepository;
        private TaskListRepository taskListRepository;  
        private BoardRepository boardRepository;

        public EFUnitOfWork(DatabaseContext ctx)
        {
            this.ctx = ctx;
        }

        public IRepository<User> Users 
        { 
            get 
            {
                if (userRepository == null)
                    userRepository = new UserRepository(ctx);
                return userRepository;
            } 
        }

        public IRepository<TaskList> TaskLists
        {
            get
            {
                if(taskListRepository == null)
                    taskListRepository = new TaskListRepository(ctx);
                return taskListRepository;
            }
        }

        public IRepository<Models.Task> Tasks
        {
            get
            {
                if(taskRepository == null)
                    taskRepository = new TaskRepository(ctx);
                return taskRepository;
            }
        }

        public IRepository<Board> Boards
        {
            get
            {
                if(boardRepository == null)
                    boardRepository = new BoardRepository(ctx);
                return boardRepository;
            }
        }

        public void Save() => ctx.SaveChanges();

        public void Dispose() => ctx.Dispose();

    }
}
