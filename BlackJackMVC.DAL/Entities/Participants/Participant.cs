using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackMVC.DAL.Entities.Participants
{
    public abstract class Participant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        //public List<CardDeck.CardEntity> Hand { get; set; }

        public Participant() { }

        public Participant(string name, int score)
        {
            Name = name;
            Score = score;
            //Hand = new List<CardDesk.CardEntity>();
        }

    }
}
