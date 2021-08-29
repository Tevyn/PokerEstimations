using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerEstimations.Models
{
    public class Hand
    {
        private readonly Card _cardOne;
        private readonly Card _cardTwo;

        public Card CardOne { get { return _cardOne; } }
        public Card CardTwo { get { return _cardTwo; } }

        public Hand(Card cardOne, Card cardTwo)
        {
            _cardOne = cardOne;
            _cardTwo = cardTwo;
        }

        public Hand(string cardIdOne, string cardIdTwo)
        {
            _cardOne = new Card(cardIdOne);
            _cardTwo = new Card(cardIdTwo);
        }

        public string GetCardIds()
        {
            return $"{_cardOne.Id}{_cardTwo.Id}";
        }
    }
}
