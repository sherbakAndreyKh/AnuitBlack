using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BlackJackMVC.DAL.Entities;
using BlackJackMVC.DAL.Entities.Participants;
using BlackJackMVC.DAL.EntityFramework;
using BlackJackMVC.DAL.Interfaces;

namespace BlackJackMVC.DAL.Repositories
{
    class PlayerRepository : IRepository<Player> 
    {
        private BlackJackContext db;

        public PlayerRepository(BlackJackContext db)
        {
            this.db = db;
        }

        public IEnumerable<Player> GetAll()
        {
            return db.Players;
        }

        public void Create(Player item)
        {
            db.Players.Add(item);           
        }

        public void Delete(int id)
        {
            Player player = db.Players.Find(id);
            if(player != null)
            {
                db.Players.Remove(player);
            }
        }

        public IEnumerable<Player> Find(Func<Player, bool> predicate)
        {
            return db.Players.Where(predicate).ToList();
        }

        public Player Get(int id)
        {
            return db.Players.Find(id);
        }

        public void Update(Player item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
