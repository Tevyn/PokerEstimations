using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoldemHand;

namespace PokerEstimations.Services
{
    public class CalculateEquityService
    {
        double myGuess;
        double answer;

        public double[] CalculateEquity(string[] pocketCards)
        {
            long[] wins = new long[2];
            long[] losses = new long[2];
            long[] ties = new long[2];
            long totalhands = 0;
            double[] playerValue = new double[2];

            Hand.HandOdds(pocketCards, "", "", wins, ties, losses, ref totalhands);

            for (int i = 0; i < 2; i++)
            {
                playerValue[i] = (((double)wins[i]) + ((double)ties[i]) / 2.0) / ((double)totalhands);
            }
            return playerValue;
        }
    }
}
