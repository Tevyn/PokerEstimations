using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerEstimations.Models
{
    public class Card
    {
        public string Id { get; }

        public Card(string cardId)
        {
            Id = cardId;
        }
    }
}
