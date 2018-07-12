using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackMVC.BLL.DTO.Participant;
using BlackJackMVC.DAL.Entities.Participants;
using BlackJackMVC.DAL.Interfaces;
using BlackJackMVC.BLL.Infrastructure;
using BlackJackMVC.BLL.Interfaces;
using BlackJackMVC.BLL.BusinessModels;
using AutoMapper;

namespace BlackJackMVC.BLL.Services
{
    public class OptionsService : IPlayerService
    {
        IUnitOfWork database { get; set; }

        public OptionsService(IUnitOfWork unitOfWork)
        {
            database = unitOfWork;
        }

        public void GameOptions(Options options)
        {
            Player player = new Player()
            {
                Name = options.NamePlayer
            };

            Bot bot = new Bot()
            {
                Name = options.NameBot
            };

            database.Players.Create(player);
            database.Bots.Create(bot);

            database.Save();
        }

        public void Dispose()
        {
            database.Dispose();
        }
    }
}
