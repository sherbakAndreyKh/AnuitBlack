using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackMVC.BLL.DTO.Participant;
using BlackJackMVC.BLL.BusinessModels;

namespace BlackJackMVC.BLL.Interfaces
{
    public interface IPlayerService
    {
        void GameOptions(Options options);

        void Dispose();
    }
}
