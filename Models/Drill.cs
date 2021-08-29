using PokerEstimations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerEstimations.Models
{
    public class Drill
    {
        private readonly DeckService _deckService;
        public Hand[] Hands { get; }
        public double Result { get; }
        public double Guess { get; set; }

        public Drill(DeckService deckService)
        {
            _deckService = deckService;
            Hands = _deckService.Deal(2);
            var pocketCards = new string[Hands.Length];
            for (int i = 0; i < Hands.Length; i++)
            {
                pocketCards[i] = Hands[i].GetCardIds();
            }

            var calculateEquitySerice = new CalculateEquityService();
            Result = calculateEquitySerice.CalculateEquity(pocketCards)[0];
        }



    }
}
