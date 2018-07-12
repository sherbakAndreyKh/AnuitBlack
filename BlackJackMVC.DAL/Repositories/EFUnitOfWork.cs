using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackMVC.DAL.Entities.Participants;
using BlackJackMVC.DAL.EntityFramework;
using BlackJackMVC.DAL.Interfaces;

namespace BlackJackMVC.DAL.Repositories
{
   public class EFUnitOfWork : IUnitOfWork
    {
        private BlackJackContext _db;
        private PlayerRepository _playerRepository;
        private DealerReopsitory _dealerReopsitory;
        private BotRepository _botRepository;

        private bool _disposed;

        public EFUnitOfWork(string connectionString)
        {
            _db = new BlackJackContext(connectionString);
        }

        public IRepository<Player> Players
        {
            get
            {
                if (_playerRepository == null)
                {
                    _playerRepository = new PlayerRepository(_db);
                }
                return _playerRepository;
            }
        }

        public IRepository<Dealer> Dealers
        {
            get
            {
                if (_dealerReopsitory == null)
                {
                    _dealerReopsitory = new DealerReopsitory(_db);
                }
                return _dealerReopsitory;
            }
        }

        public IRepository<Bot> Bots
        {
            get
            {
                if(_botRepository == null)
                {
                    _botRepository = new BotRepository(_db);
                }
                return _botRepository;
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }
            
        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
