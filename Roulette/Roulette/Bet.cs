using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Bet
    {
        public double Value { get; set; }
        public int Pos { get; set; }
        public int BetType { get; set; }
        public bool winningBet { get; set; }
        public Bet(double value, int pos)
        {
            Value = value;
            Pos = pos;

            if (pos > 0 && pos <= 37)
                BetType = 1;
            else if (pos <= 95)
                BetType = 2;
            else if (pos <= 107)
                BetType = 3;
            else if (pos <= 129)
                BetType = 4;
            else if (pos == 130)
                BetType = 5;
            else if (pos <= 141)
                BetType = 6;
            else if (pos <= 147)
                BetType = 7;
            else if (pos <= 153)
                BetType = 8;

            winningBet = false;
            
        }
        public double Payout ()
        {
            winningBet = true;
            switch (BetType)
            {
                case 1:
                    Console.WriteLine("Bet on position " + Pos + " for " + Value + " Won! Your winnings are $" + Value * 35);
                    return Value + Value * 35;  //Straight up
                case 2:
                    Console.WriteLine("Bet on position " + Pos + " for " + Value + " Won! Your winnings are $" + Value * 17);
                    return Value + Value * 17;  //Split
                case 3:
                    Console.WriteLine("Bet on position " + Pos + " for " + Value + " Won! Your winnings are $" + Value * 11);
                    return Value + Value * 11;  //Street
                case 4:
                    Console.WriteLine("Bet on position " + Pos + " for " + Value + " Won! Your winnings are $" + Value * 8);
                    return Value + Value * 8;   //Corner
                case 5:
                    Console.WriteLine("Bet on position " + Pos + " for " + Value + " Won! Your winnings are $" + Value * 6);
                    return Value + Value * 6;   //Basket
                case 6:
                    Console.WriteLine("Bet on position " + Pos + " for " + Value + " Won! Your winnings are $" + Value * 5);
                    return Value + Value * 5;   //Line
                case 7:
                    Console.WriteLine("Bet on position " + Pos + " for " + Value + " Won! Your winnings are $" + Value * 2);
                    return Value + Value * 2;   //Dozen
                case 8:
                    Console.WriteLine("Bet on position " + Pos + " for " + Value + " Won! Your winnings are $" + Value * 1);
                    return Value + Value * 1;   //Half
                default:
                    Console.WriteLine("Invalid bet type");
                    return Value;

            }
        }
    }
}
