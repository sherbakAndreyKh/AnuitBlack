using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackMVC.DAL.Entities.Participants;

namespace BlackJackMVC.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Player> Players { get; }
        IRepository<Dealer> Dealers { get; }
        IRepository<Bot> Bots { get; }
        void Save();
    }
}
