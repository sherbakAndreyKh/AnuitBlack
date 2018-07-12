using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BlackJackMVC.DAL.Entities.Participants;
using BlackJackMVC.DAL.EntityFramework;
using BlackJackMVC.DAL.Interfaces;

namespace BlackJackMVC.DAL.Repositories
{
    class BotRepository : IRepository<Bot>
    {
        private BlackJackContext db;


        public BotRepository(BlackJackContext db)
        {
            this.db = db;
        }

        public void Create(Bot item)
        {
            db.Bots.Add(item);
        }

        public void Delete(int id)
        {
            Bot bot = db.Bots.Find(id);
            if(bot != null)
            {
                db.Bots.Remove(bot);
            }
        }

        public IEnumerable<Bot> Find(Func<Bot, bool> predicate)
        {
            return db.Bots.Where(predicate).ToList();
        }

        public Bot Get(int id)
        {
            return db.Bots.Find(id);
        }

        public IEnumerable<Bot> GetAll()
        {
            return db.Bots;
        }

        public void Update(Bot item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
