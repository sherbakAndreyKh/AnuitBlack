using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BlackJackMVC.DAL.Entities.Participants;

namespace BlackJackMVC.DAL.EntityFramework
{
    class BlackJackContext : DbContext
    {

        public DbSet<Player> Players { get; set; }
        public DbSet<Dealer> Dealer { get; set; }
        public DbSet<Bot> Bots { get; set; }

        static BlackJackContext()
        {
            Database.SetInitializer<BlackJackContext>(new StoreDbInitializer());
        }

        public BlackJackContext(string connectionString)
            : base(connectionString)
        {
        }

        public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<BlackJackContext>
        {
            protected override void Seed(BlackJackContext db)
            {

                db.Bots.Add(new Bot { Name = "Bot1" });
                db.Bots.Add(new Bot { Name = "Bot2" });
                db.Bots.Add(new Bot { Name = "Bot3" });
                db.Bots.Add(new Bot { Name = "Bot4" });
                db.Bots.Add(new Bot { Name = "Bot5" });

                db.Dealer.Add(new Dealer { Name = "Dealer" });
                db.SaveChanges();
            }
        }
    }
}
