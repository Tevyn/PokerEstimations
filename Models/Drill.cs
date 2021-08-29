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
        public Hand[] hands { get; }
        public double result { get; }

        public Drill(DeckService deckService)
        {
            _deckService = deckService;
            hands = _deckService.Deal(2);


        }



    }
}
