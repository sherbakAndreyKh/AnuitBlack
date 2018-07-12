using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackJackMVC.WEB.Models
{
    public class PlayerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        //public List<CardDeck.CardEntity> Hand { get; set; }

        public PlayerViewModel() { }

        public PlayerViewModel(string name, int score)
        {
            Name = name;
            Score = score;
            //Hand = new List<CardDesk.CardEntity>();
        }

    }
}