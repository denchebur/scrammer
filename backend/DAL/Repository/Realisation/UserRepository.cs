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
    internal class UserRepository : IRepository<User>
    {
        private readonly DatabaseContext ctx;

        public UserRepository(DatabaseContext ctx)
        {
            this.ctx = ctx;
        }

        public void Create(User item)
        {
            ctx.Users.Add(item);
        }

        public void Delete(int id)
        {
            var item = ctx.Users.Find(id);
            if (item != null)
                ctx.Users.Remove(item);
        }

        public IEnumerable<User> Find(Func<User, bool> predicate)
        {
            return ctx.Users.Where(predicate).ToList();
        }

        public User Get(int id)
        {
            return ctx.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return ctx.Users.ToList();
        }

        public void Update(User item)
        {
            ctx.Users.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
