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
using AutoMapper;

namespace BlackJackMVC.BLL.Services
{
    class OptionsService : IPlayerService
    {
        IUnitOfWork database { get; set; }

        public OptionsService(IUnitOfWork unitOfWork)
        {
            database = unitOfWork;
        }

        public void GameOptions(PlayerDTO playerDTO, BotDTO botDTO)
        {
            Player player = new Player()
            {
                Name = playerDTO.Name,
                Score = playerDTO.Score
            };

            Bot bot = new Bot()
            {
                Name = botDTO.Name,
                Score = botDTO.Score
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
