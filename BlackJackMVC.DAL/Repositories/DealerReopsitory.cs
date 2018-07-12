using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BlackJackMVC.DAL.Interfaces;
using BlackJackMVC.DAL.Entities.Participants;
using BlackJackMVC.DAL.EntityFramework;

namespace BlackJackMVC.DAL.Repositories
{
   public class DealerReopsitory : IRepository<Dealer>
    {
        private BlackJackContext db;

        public DealerReopsitory(BlackJackContext context)
        {
            db = context;
        }

        public void Create(Dealer item)
        {
            db.Dealer.Add(item);
        }

        public void Delete(int id)
        {
            Dealer dealer = db.Dealer.Find(id);
            if (dealer != null)
            {
                db.Dealer.Remove(dealer);
            }
        }

        public IEnumerable<Dealer> Find(Func<Dealer, bool> predicate)
        {
            return db.Dealer.Where(predicate).ToList();
        }

        public Dealer Get(int id)
        {
            return db.Dealer.Find(id);
        }

        public IEnumerable<Dealer> GetAll()
        {
            return db.Dealer;
        }

        public void Update(Dealer item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
