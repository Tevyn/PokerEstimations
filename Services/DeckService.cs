using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokerEstimations.Models;

namespace PokerEstimations.Services
{
    public class DeckService
    {
        private readonly string[] cards = {"2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "Tc", "Jc", "Qc", "Kc", "Ac",
                                           "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "Td", "Jd", "Qd", "Kd", "Ad",
                                           "2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "Th", "Jh", "Qh", "Kh", "Ah",
                                           "2s", "3s", "4s", "5s", "6s", "7s", "8s", "9s", "Ts", "Js", "Qs", "Ks", "As"};

        private readonly Random random = new Random();

        public Hand[] Deal(int numberOfHands) 
        {
            var values = Enumerable.Range(0, 51).OrderBy(x => random.Next()).ToArray();
            var hands = new List<Hand>();

            for (int i = 0; i < numberOfHands; i++)
            {
                var hand = new Hand(cards[values[i + hands.Count()]], cards[values[i + hands.Count() + 1]]);
                hands.Add(hand);
            }

            return hands.ToArray();
        }
    }
}
