using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackMVC.BLL.DTO.Participant;

namespace BlackJackMVC.BLL.Interfaces
{
    interface IPlayerService
    {
        void GameOptions(PlayerDTO playerDTO, BotDTO botDTO);
        void Dispose();
    }
}
