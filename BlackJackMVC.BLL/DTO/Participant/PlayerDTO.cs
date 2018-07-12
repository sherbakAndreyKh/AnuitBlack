using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackMVC.BLL.DTO.Participant
{
    class PlayerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public PlayerDTO() { }

        public PlayerDTO(string name, int score)
        {
            Name = name;
            Score = score;
            //Hand = new List<CardDesk.CardEntity>();
        }
    }
}
