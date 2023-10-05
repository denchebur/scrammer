using DAL.DatabaseContextDir;
using DAL.Models;
using DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Realisation
{
    public class BoardRepository : IRepository<Board>
    {
        private readonly DatabaseContext ctx;
        public BoardRepository(DatabaseContext ctx)
        {
            this.ctx = ctx;
        }

        public void Create(Board item)
        {
            ctx.Boards.Add(item);
        }

        public void Delete(int id)
        {
            var item = ctx.Boards.Find(id);
            if (item != null)
                ctx.Boards.Remove(item);
        }

        public IEnumerable<Board> Find(Func<Board, bool> predicate)
        {
            return ctx.Boards.Where(predicate).ToList();
        }

        public Board Get(int id)
        {
            return ctx.Boards.Find(id);
        }

        public IEnumerable<Board> GetAll()
        {
            return ctx.Boards.ToList();
        }

        public void Update(Board item)
        {
            ctx.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
