using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Roulette
{
    class Program
    {
        static void writeUI(double money, int numberOfBets, Bet[] bets)
        {
            Console.WriteLine("Money: $" + money);
            Console.Write("Bets:");
            if (numberOfBets == 0)
                Console.WriteLine(" None");
            else
                Console.WriteLine();
                for (int j = 0; j < numberOfBets; j++)
                    Console.WriteLine("$" + bets[j].Value + " on Position " + bets[j].Pos);
        }

        static void Main()
        {
            double money = 10000;

            int betPos = -1;
            double betValue = 0;
            int numberOfBets = 0;
            Bet[] bets = new Bet[10];
            int anotherBet = 1;
            int playAgain = 1;

            Random rand = new Random();
            int WheelLandedOn = -1;
            string WheelLandedOnString = "";


            while (playAgain != 0 && money > 0)
            {
                betPos = -1;
                betValue = 0;
                numberOfBets = 0;
                bets = new Bet[10];
                anotherBet = 1;
                playAgain = 1;

                for (int i = 0; i < 10; i++)
                {
                    Console.Clear();
                    writeUI(money, numberOfBets, bets);
                    for (int j = 0; i < numberOfBets; i++)
                        Console.WriteLine("$" + bets[j].Value + " on Position " + bets[j].Pos);

                    Console.WriteLine();

                    while (true)
                    {
                        Console.WriteLine("Where do you want to place your bet?");
                        Int32.TryParse(Console.ReadLine(), out betPos);
                        if (betPos < 0 || betPos > 153)
                            Console.WriteLine("Invalid Bet Position!");
                        else
                            break;
                    }
                    
                    while (true)
                    {
                        Console.WriteLine("How much?");
                        Double.TryParse(Console.ReadLine(), out betValue);
                        if (betValue > money)
                            Console.WriteLine("Insufficient funds!");
                        else
                            break;
                    }
                    money -= betValue;

                    bets[i] = new Bet(betValue, betPos);
                    numberOfBets++;

                    Console.Clear();
                    writeUI(money, numberOfBets, bets);
                    Console.WriteLine();

                    if (money > 0)
                    {
                        Console.WriteLine("Place another bet? 1 for Yes or 0 for No");
                        Int32.TryParse(Console.ReadLine(), out anotherBet);
                    }
                    Console.Clear();
                    
                    writeUI(money, numberOfBets, bets);
                    if (anotherBet == 0 || money == 0)
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Betting completed, spinning wheel...");
                Console.WriteLine();

                WheelLandedOn = rand.Next(0, 37);
                #region outcomeStringCreator
                switch (WheelLandedOn)
                {
                    case 0:
                        WheelLandedOnString = "0";
                        break;
                    case 1:
                        WheelLandedOnString = "1 Red";
                        break;
                    case 2:
                        WheelLandedOnString = "2 Black";
                        break;
                    case 3:
                        WheelLandedOnString = "3 Red";
                        break;
                    case 4:
                        WheelLandedOnString = "4 Black";
                        break;
                    case 5:
                        WheelLandedOnString = "5 Red";
                        break;
                    case 6:
                        WheelLandedOnString = "6 Black";
                        break;
                    case 7:
                        WheelLandedOnString = "7 Red";
                        break;
                    case 8:
                        WheelLandedOnString = "8 Black";
                        break;
                    case 9:
                        WheelLandedOnString = "9 Red";
                        break;
                    case 10:
                        WheelLandedOnString = "10 Black";
                        break;
                    case 11:
                        WheelLandedOnString = "11 Black";
                        break;
                    case 12:
                        WheelLandedOnString = "12 Red";
                        break;
                    case 13:
                        WheelLandedOnString = "13 Black";
                        break;
                    case 14:
                        WheelLandedOnString = "14 Red";
                        break;
                    case 15:
                        WheelLandedOnString = "15 Black";
                        break;
                    case 16:
                        WheelLandedOnString = "16 Red";
                        break;
                    case 17:
                        WheelLandedOnString = "17 Black";
                        break;
                    case 18:
                        WheelLandedOnString = "18 Red";
                        break;
                    case 19:
                        WheelLandedOnString = "19 Red";
                        break;
                    case 20:
                        WheelLandedOnString = "20 Black";
                        break;
                    case 21:
                        WheelLandedOnString = "21 Red";
                        break;
                    case 22:
                        WheelLandedOnString = "22 Black";
                        break;
                    case 23:
                        WheelLandedOnString = "23 Red";
                        break;
                    case 24:
                        WheelLandedOnString = "24 Black";
                        break;
                    case 25:
                        WheelLandedOnString = "25 Red";
                        break;
                    case 26:
                        WheelLandedOnString = "26 Black";
                        break;
                    case 27:
                        WheelLandedOnString = "27 Red";
                        break;
                    case 28:
                        WheelLandedOnString = "28 Black";
                        break;
                    case 29:
                        WheelLandedOnString = "29 Black";
                        break;
                    case 30:
                        WheelLandedOnString = "30 Red";
                        break;
                    case 31:
                        WheelLandedOnString = "31 Black";
                        break;
                    case 32:
                        WheelLandedOnString = "32 Red";
                        break;
                    case 33:
                        WheelLandedOnString = "33 Black";
                        break;
                    case 34:
                        WheelLandedOnString = "34 Red";
                        break;
                    case 35:
                        WheelLandedOnString = "35 Black";
                        break;
                    case 36:
                        WheelLandedOnString = "36 Red";
                        break;
                    case 37:
                        WheelLandedOnString = "00";
                        break;
                    default:
                        WheelLandedOnString = "error";
                        break;
                    
                }
                #endregion

                Console.WriteLine("The wheel landed on: " + WheelLandedOnString);
                Console.WriteLine();

                for (int i = 0; i < numberOfBets; i++)
                {
                    #region outcomeChecker
                    switch (bets[i].Pos)
                    {
                        case 0:
                            if (WheelLandedOn == 0)
                                money += bets[i].Payout();
                            break;
                        case 1:
                            if (WheelLandedOn == 1)
                                money += bets[i].Payout();
                            break;
                        case 2:
                            if (WheelLandedOn == 2)
                                money += bets[i].Payout();
                            break;
                        case 3:
                            if (WheelLandedOn == 3)
                                money += bets[i].Payout();
                            break;
                        case 4:
                            if (WheelLandedOn == 4)
                                money += bets[i].Payout();
                            break;
                        case 5:
                            if (WheelLandedOn == 5)
                                money += bets[i].Payout();
                            break;
                        case 6:
                            if (WheelLandedOn == 6)
                                money += bets[i].Payout();
                            break;
                        case 7:
                            if (WheelLandedOn == 7)
                                money += bets[i].Payout();
                            break;
                        case 8:
                            if (WheelLandedOn == 8)
                                money += bets[i].Payout();
                            break;
                        case 9:
                            if (WheelLandedOn == 9)
                                money += bets[i].Payout();
                            break;
                        case 10:
                            if (WheelLandedOn == 10)
                                money += bets[i].Payout();
                            break;
                        case 11:
                            if (WheelLandedOn == 11)
                                money += bets[i].Payout();
                            break;
                        case 12:
                            if (WheelLandedOn == 12)
                                money += bets[i].Payout();
                            break;
                        case 13:
                            if (WheelLandedOn == 13)
                                money += bets[i].Payout();
                            break;
                        case 14:
                            if (WheelLandedOn == 14)
                                money += bets[i].Payout();
                            break;
                        case 15:
                            if (WheelLandedOn == 15)
                                money += bets[i].Payout();
                            break;
                        case 16:
                            if (WheelLandedOn == 16)
                                money += bets[i].Payout();
                            break;
                        case 17:
                            if (WheelLandedOn == 17)
                                money += bets[i].Payout();
                            break;
                        case 18:
                            if (WheelLandedOn == 18)
                                money += bets[i].Payout();
                            break;
                        case 19:
                            if (WheelLandedOn == 19)
                                money += bets[i].Payout();
                            break;
                        case 20:
                            if (WheelLandedOn == 20)
                                money += bets[i].Payout();
                            break;
                        case 21:
                            if (WheelLandedOn == 21)
                                money += bets[i].Payout();
                            break;
                        case 22:
                            if (WheelLandedOn == 22)
                                money += bets[i].Payout();
                            break;
                        case 23:
                            if (WheelLandedOn == 23)
                                money += bets[i].Payout();
                            break;
                        case 24:
                            if (WheelLandedOn == 24)
                                money += bets[i].Payout();
                            break;
                        case 25:
                            if (WheelLandedOn == 25)
                                money += bets[i].Payout();
                            break;
                        case 26:
                            if (WheelLandedOn == 26)
                                money += bets[i].Payout();
                            break;
                        case 27:
                            if (WheelLandedOn == 27)
                                money += bets[i].Payout();
                            break;
                        case 28:
                            if (WheelLandedOn == 28)
                                money += bets[i].Payout();
                            break;
                        case 29:
                            if (WheelLandedOn == 29)
                                money += bets[i].Payout();
                            break;
                        case 30:
                            if (WheelLandedOn == 30)
                                money += bets[i].Payout();
                            break;
                        case 31:
                            if (WheelLandedOn == 31)
                                money += bets[i].Payout();
                            break;
                        case 32:
                            if (WheelLandedOn == 32)
                                money += bets[i].Payout();
                            break;
                        case 33:
                            if (WheelLandedOn == 33)
                                money += bets[i].Payout();
                            break;
                        case 34:
                            if (WheelLandedOn == 34)
                                money += bets[i].Payout();
                            break;
                        case 35:
                            if (WheelLandedOn == 35)
                                money += bets[i].Payout();
                            break;
                        case 36:
                            if (WheelLandedOn == 36)
                                money += bets[i].Payout();
                            break;
                        case 37:
                            if (WheelLandedOn == 37)
                                money += bets[i].Payout();
                            break;
                        case 38:
                            if (WheelLandedOn == 2 || WheelLandedOn == 3)
                                money += bets[i].Payout();
                            break;
                        case 39:
                            if (WheelLandedOn == 5 || WheelLandedOn == 6)
                                money += bets[i].Payout();
                            break;
                        case 40:
                            if (WheelLandedOn == 8 || WheelLandedOn == 9)
                                money += bets[i].Payout();
                            break;
                        case 41:
                            if (WheelLandedOn == 11 || WheelLandedOn == 12)
                                money += bets[i].Payout();
                            break;
                        case 42:
                            if (WheelLandedOn == 14 || WheelLandedOn == 15)
                                money += bets[i].Payout();
                            break;
                        case 43:
                            if (WheelLandedOn == 17 || WheelLandedOn == 18)
                                money += bets[i].Payout();
                            break;
                        case 44:
                            if (WheelLandedOn == 20 || WheelLandedOn == 21)
                                money += bets[i].Payout();
                            break;
                        case 45:
                            if (WheelLandedOn == 23 || WheelLandedOn == 24)
                                money += bets[i].Payout();
                            break;
                        case 46:
                            if (WheelLandedOn == 26 || WheelLandedOn == 27)
                                money += bets[i].Payout();
                            break;
                        case 47:
                            if (WheelLandedOn == 29 || WheelLandedOn == 30)
                                money += bets[i].Payout();
                            break;
                        case 48:
                            if (WheelLandedOn == 32 || WheelLandedOn == 33)
                                money += bets[i].Payout();
                            break;
                        case 49:
                            if (WheelLandedOn == 35 || WheelLandedOn == 36)
                                money += bets[i].Payout();
                            break;
                        case 50:
                            if (WheelLandedOn == 1 || WheelLandedOn == 2)
                                money += bets[i].Payout();
                            break;
                        case 51:
                            if (WheelLandedOn == 4 || WheelLandedOn == 5)
                                money += bets[i].Payout();
                            break;
                        case 52:
                            if (WheelLandedOn == 7 || WheelLandedOn == 8)
                                money += bets[i].Payout();
                            break;
                        case 53:
                            if (WheelLandedOn == 10 || WheelLandedOn == 11)
                                money += bets[i].Payout();
                            break;
                        case 54:
                            if (WheelLandedOn == 13 || WheelLandedOn == 14)
                                money += bets[i].Payout();
                            break;
                        case 55:
                            if (WheelLandedOn == 16 || WheelLandedOn == 17)
                                money += bets[i].Payout();
                            break;
                        case 56:
                            if (WheelLandedOn == 19 || WheelLandedOn == 20)
                                money += bets[i].Payout();
                            break;
                        case 57:
                            if (WheelLandedOn == 22 || WheelLandedOn == 23)
                                money += bets[i].Payout();
                            break;
                        case 58:
                            if (WheelLandedOn == 25 || WheelLandedOn == 26)
                                money += bets[i].Payout();
                            break;
                        case 59:
                            if (WheelLandedOn == 28 || WheelLandedOn == 29)
                                money += bets[i].Payout();
                            break;
                        case 60:
                            if (WheelLandedOn == 31 || WheelLandedOn == 32)
                                money += bets[i].Payout();
                            break;
                        case 61:
                            if (WheelLandedOn == 34 || WheelLandedOn == 35)
                                money += bets[i].Payout();
                            break;
                        case 62:
                            if (WheelLandedOn == 3 || WheelLandedOn == 6)
                                money += bets[i].Payout();
                            break;
                        case 63:
                            if (WheelLandedOn == 6 || WheelLandedOn == 9)
                                money += bets[i].Payout();
                            break;
                        case 64:
                            if (WheelLandedOn == 9 || WheelLandedOn == 12)
                                money += bets[i].Payout();
                            break;
                        case 65:
                            if (WheelLandedOn == 12 || WheelLandedOn == 15)
                                money += bets[i].Payout();
                            break;
                        case 66:
                            if (WheelLandedOn == 15 || WheelLandedOn == 18)
                                money += bets[i].Payout();
                            break;
                        case 67:
                            if (WheelLandedOn == 18 || WheelLandedOn == 21)
                                money += bets[i].Payout();
                            break;
                        case 68:
                            if (WheelLandedOn == 21 || WheelLandedOn == 24)
                                money += bets[i].Payout();
                            break;
                        case 69:
                            if (WheelLandedOn == 24 || WheelLandedOn == 27)
                                money += bets[i].Payout();
                            break;
                        case 70:
                            if (WheelLandedOn == 27 || WheelLandedOn == 30)
                                money += bets[i].Payout();
                            break;
                        case 71:
                            if (WheelLandedOn == 30 || WheelLandedOn == 33)
                                money += bets[i].Payout();
                            break;
                        case 72:
                            if (WheelLandedOn == 33 || WheelLandedOn == 36)
                                money += bets[i].Payout();
                            break;
                        case 73:
                            if (WheelLandedOn == 2 || WheelLandedOn == 5)
                                money += bets[i].Payout();
                            break;
                        case 74:
                            if (WheelLandedOn == 5 || WheelLandedOn == 8)
                                money += bets[i].Payout();
                            break;
                        case 75:
                            if (WheelLandedOn == 8 || WheelLandedOn == 11)
                                money += bets[i].Payout();
                            break;
                        case 76:
                            if (WheelLandedOn == 11 || WheelLandedOn == 14)
                                money += bets[i].Payout();
                            break;
                        case 77:
                            if (WheelLandedOn == 14 || WheelLandedOn == 17)
                                money += bets[i].Payout();
                            break;
                        case 78:
                            if (WheelLandedOn == 17 || WheelLandedOn == 20)
                                money += bets[i].Payout();
                            break;
                        case 79:
                            if (WheelLandedOn == 20 || WheelLandedOn == 23)
                                money += bets[i].Payout();
                            break;
                        case 80:
                            if (WheelLandedOn == 23 || WheelLandedOn == 26)
                                money += bets[i].Payout();
                            break;
                        case 81:
                            if (WheelLandedOn == 26 || WheelLandedOn == 29)
                                money += bets[i].Payout();
                            break;
                        case 82:
                            if (WheelLandedOn == 29 || WheelLandedOn == 32)
                                money += bets[i].Payout();
                            break;
                        case 83:
                            if (WheelLandedOn == 32 || WheelLandedOn == 35)
                                money += bets[i].Payout();
                            break;
                        case 84:
                            if (WheelLandedOn == 1 || WheelLandedOn == 4)
                                money += bets[i].Payout();
                            break;
                        case 85:
                            if (WheelLandedOn == 4 || WheelLandedOn == 7)
                                money += bets[i].Payout();
                            break;
                        case 86:
                            if (WheelLandedOn == 7 || WheelLandedOn == 10)
                                money += bets[i].Payout();
                            break;
                        case 87:
                            if (WheelLandedOn == 10 || WheelLandedOn == 13)
                                money += bets[i].Payout();
                            break;
                        case 88:
                            if (WheelLandedOn == 13 || WheelLandedOn == 16)
                                money += bets[i].Payout();
                            break;
                        case 89:
                            if (WheelLandedOn == 16 || WheelLandedOn == 19)
                                money += bets[i].Payout();
                            break;
                        case 90:
                            if (WheelLandedOn == 19 || WheelLandedOn == 22)
                                money += bets[i].Payout();
                            break;
                        case 91:
                            if (WheelLandedOn == 22 || WheelLandedOn == 25)
                                money += bets[i].Payout();
                            break;
                        case 92:
                            if (WheelLandedOn == 25 || WheelLandedOn == 28)
                                money += bets[i].Payout();
                            break;
                        case 93:
                            if (WheelLandedOn == 28 || WheelLandedOn == 31)
                                money += bets[i].Payout();
                            break;
                        case 94:
                            if (WheelLandedOn == 31 || WheelLandedOn == 34)
                                money += bets[i].Payout();
                            break;
                        case 95:
                            if (WheelLandedOn == 0 || WheelLandedOn == 37)
                                money += bets[i].Payout();
                            break;
                        case 96:
                            if (WheelLandedOn == 1 || WheelLandedOn == 2 || WheelLandedOn == 3)
                                money += bets[i].Payout();
                            break;
                        case 97:
                            if (WheelLandedOn == 4 || WheelLandedOn == 5 || WheelLandedOn == 6)
                                money += bets[i].Payout();
                            break;
                        case 98:
                            if (WheelLandedOn == 7 || WheelLandedOn == 8 || WheelLandedOn == 9)
                                money += bets[i].Payout();
                            break;
                        case 99:
                            if (WheelLandedOn == 10 || WheelLandedOn == 11 || WheelLandedOn == 12)
                                money += bets[i].Payout();
                            break;
                        case 100:
                            if (WheelLandedOn == 13 || WheelLandedOn == 14 || WheelLandedOn == 15)
                                money += bets[i].Payout();
                            break;
                        case 101:
                            if (WheelLandedOn == 16 || WheelLandedOn == 17 || WheelLandedOn == 18)
                                money += bets[i].Payout();
                            break;
                        case 102:
                            if (WheelLandedOn == 19 || WheelLandedOn == 20 || WheelLandedOn == 21)
                                money += bets[i].Payout();
                            break;
                        case 103:
                            if (WheelLandedOn == 22 || WheelLandedOn == 23 || WheelLandedOn == 24)
                                money += bets[i].Payout();
                            break;
                        case 104:
                            if (WheelLandedOn == 25 || WheelLandedOn == 26 || WheelLandedOn == 27)
                                money += bets[i].Payout();
                            break;
                        case 105:
                            if (WheelLandedOn == 28 || WheelLandedOn == 29 || WheelLandedOn == 30)
                                money += bets[i].Payout();
                            break;
                        case 106:
                            if (WheelLandedOn == 31 || WheelLandedOn == 32 || WheelLandedOn == 33)
                                money += bets[i].Payout();
                            break;
                        case 107:
                            if (WheelLandedOn == 34 || WheelLandedOn == 35 || WheelLandedOn == 36)
                                money += bets[i].Payout();
                            break;
                        case 108:
                            if (WheelLandedOn == 2 || WheelLandedOn == 3 || WheelLandedOn == 5 || WheelLandedOn == 6)
                                money += bets[i].Payout();
                            break;
                        case 109:
                            if (WheelLandedOn == 5 || WheelLandedOn == 6 || WheelLandedOn == 8 || WheelLandedOn == 9)
                                money += bets[i].Payout();
                            break;
                        case 110:
                            if (WheelLandedOn == 8 || WheelLandedOn == 9 || WheelLandedOn == 11 || WheelLandedOn == 12)
                                money += bets[i].Payout();
                            break;
                        case 111:
                            if (WheelLandedOn == 11 || WheelLandedOn == 12 || WheelLandedOn == 14 || WheelLandedOn == 15)
                                money += bets[i].Payout();
                            break;
                        case 112:
                            if (WheelLandedOn == 14 || WheelLandedOn == 15 || WheelLandedOn == 17 || WheelLandedOn == 18)
                                money += bets[i].Payout();
                            break;
                        case 113:
                            if (WheelLandedOn == 17 || WheelLandedOn == 18 || WheelLandedOn == 20 || WheelLandedOn == 21)
                                money += bets[i].Payout();
                            break;
                        case 114:
                            if (WheelLandedOn == 20 || WheelLandedOn == 21 || WheelLandedOn == 23 || WheelLandedOn == 24)
                                money += bets[i].Payout();
                            break;
                        case 115:
                            if (WheelLandedOn == 23 || WheelLandedOn == 24 || WheelLandedOn == 26 || WheelLandedOn == 27)
                                money += bets[i].Payout();
                            break;
                        case 116:
                            if (WheelLandedOn == 26 || WheelLandedOn == 27 || WheelLandedOn == 29 || WheelLandedOn == 30)
                                money += bets[i].Payout();
                            break;
                        case 117:
                            if (WheelLandedOn == 29 || WheelLandedOn == 30 || WheelLandedOn == 32 || WheelLandedOn == 33)
                                money += bets[i].Payout();
                            break;
                        case 118:
                            if (WheelLandedOn == 32 || WheelLandedOn == 33 || WheelLandedOn == 35 || WheelLandedOn == 36)
                                money += bets[i].Payout();
                            break;
                        case 119:
                            if (WheelLandedOn == 1 || WheelLandedOn == 2 || WheelLandedOn == 4 || WheelLandedOn == 5)
                                money += bets[i].Payout();
                            break;
                        case 120:
                            if (WheelLandedOn == 4 || WheelLandedOn == 5 || WheelLandedOn == 7 || WheelLandedOn == 8)
                                money += bets[i].Payout();
                            break;
                        case 121:
                            if (WheelLandedOn == 7 || WheelLandedOn == 8 || WheelLandedOn == 10 || WheelLandedOn == 11)
                                money += bets[i].Payout();
                            break;
                        case 122:
                            if (WheelLandedOn == 10 || WheelLandedOn == 11 || WheelLandedOn == 13 || WheelLandedOn == 14)
                                money += bets[i].Payout();
                            break;
                        case 123:
                            if (WheelLandedOn == 13 || WheelLandedOn == 14 || WheelLandedOn == 16 || WheelLandedOn == 17)
                                money += bets[i].Payout();
                            break;
                        case 124:
                            if (WheelLandedOn == 16 || WheelLandedOn == 17 || WheelLandedOn == 19 || WheelLandedOn == 20)
                                money += bets[i].Payout();
                            break;
                        case 125:
                            if (WheelLandedOn == 19 || WheelLandedOn == 20 || WheelLandedOn == 22 || WheelLandedOn == 23)
                                money += bets[i].Payout();
                            break;
                        case 126:
                            if (WheelLandedOn == 22 || WheelLandedOn == 23 || WheelLandedOn == 25 || WheelLandedOn == 26)
                                money += bets[i].Payout();
                            break;
                        case 127:
                            if (WheelLandedOn == 25 || WheelLandedOn == 26 || WheelLandedOn == 28 || WheelLandedOn == 29)
                                money += bets[i].Payout();
                            break;
                        case 128:
                            if (WheelLandedOn == 28 || WheelLandedOn == 29 || WheelLandedOn == 31 || WheelLandedOn == 32)
                                money += bets[i].Payout();
                            break;
                        case 129:
                            if (WheelLandedOn == 31 || WheelLandedOn == 32 || WheelLandedOn == 34 || WheelLandedOn == 35)
                                money += bets[i].Payout();
                            break;
                        case 130:
                            if (WheelLandedOn == 0 || WheelLandedOn == 37 || WheelLandedOn == 1 || WheelLandedOn == 2 || WheelLandedOn == 3)
                                money += bets[i].Payout();
                            break;
                        case 131:
                            if (WheelLandedOn == 1 || WheelLandedOn == 2 || WheelLandedOn == 3 || WheelLandedOn == 4 || WheelLandedOn == 5 || WheelLandedOn == 6)
                                money += bets[i].Payout();
                            break;
                        case 132:
                            if (WheelLandedOn == 4 || WheelLandedOn == 5 || WheelLandedOn == 6 || WheelLandedOn == 7 || WheelLandedOn == 8 || WheelLandedOn == 9)
                                money += bets[i].Payout();
                            break;
                        case 133:
                            if (WheelLandedOn == 7 || WheelLandedOn == 8 || WheelLandedOn == 9 || WheelLandedOn == 10 || WheelLandedOn == 11 || WheelLandedOn == 12)
                                money += bets[i].Payout();
                            break;
                        case 134:
                            if (WheelLandedOn == 10 || WheelLandedOn == 11 || WheelLandedOn == 12 || WheelLandedOn == 13 || WheelLandedOn == 14 || WheelLandedOn == 15)
                                money += bets[i].Payout();
                            break;
                        case 135:
                            if (WheelLandedOn == 13 || WheelLandedOn == 14 || WheelLandedOn == 15 || WheelLandedOn == 16 || WheelLandedOn == 17 || WheelLandedOn == 18)
                                money += bets[i].Payout();
                            break;
                        case 136:
                            if (WheelLandedOn == 16 || WheelLandedOn == 17 || WheelLandedOn == 18 || WheelLandedOn == 19 || WheelLandedOn == 20 || WheelLandedOn == 21)
                                money += bets[i].Payout();
                            break;
                        case 137:
                            if (WheelLandedOn == 19 || WheelLandedOn == 20 || WheelLandedOn == 21 || WheelLandedOn == 22 || WheelLandedOn == 23 || WheelLandedOn == 24)
                                money += bets[i].Payout();
                            break;
                        case 138:
                            if (WheelLandedOn == 22 || WheelLandedOn == 23 || WheelLandedOn == 24 || WheelLandedOn == 25 || WheelLandedOn == 26 || WheelLandedOn == 27)
                                money += bets[i].Payout();
                            break;
                        case 139:
                            if (WheelLandedOn == 25 || WheelLandedOn == 26 || WheelLandedOn == 27 || WheelLandedOn == 28 || WheelLandedOn == 29 || WheelLandedOn == 30)
                                money += bets[i].Payout();
                            break;
                        case 140:
                            if (WheelLandedOn == 28 || WheelLandedOn == 29 || WheelLandedOn == 30 || WheelLandedOn == 31 || WheelLandedOn == 32 || WheelLandedOn == 33)
                                money += bets[i].Payout();
                            break;
                        case 141:
                            if (WheelLandedOn == 31 || WheelLandedOn == 32 || WheelLandedOn == 33 || WheelLandedOn == 34 || WheelLandedOn == 35 || WheelLandedOn == 36)
                                money += bets[i].Payout();
                            break;
                        case 142:
                            if (WheelLandedOn >= 1 && WheelLandedOn <= 12)
                                money += bets[i].Payout();
                            break;
                        case 143:
                            if (WheelLandedOn >= 13 && WheelLandedOn <= 24)
                                money += bets[i].Payout();
                            break;
                        case 144:
                            if (WheelLandedOn >= 25 && WheelLandedOn <= 36)
                                money += bets[i].Payout();
                            break;
                        case 145:
                            if ((WheelLandedOn >= 1 && WheelLandedOn <= 36) && WheelLandedOn % 3 == 0)
                                money += bets[i].Payout();
                            break;
                        case 146:
                            if ((WheelLandedOn >= 1 && WheelLandedOn <= 36) && WheelLandedOn % 3 == 2)
                                money += bets[i].Payout();
                            break;
                        case 147:
                            if ((WheelLandedOn >= 1 && WheelLandedOn <= 36) && WheelLandedOn % 3 == 1)
                                money += bets[i].Payout();
                            break;
                        case 148:
                            if (WheelLandedOn >= 1 && WheelLandedOn <= 18)
                                money += bets[i].Payout();
                            break;
                        case 149:
                            if ((WheelLandedOn >= 1 && WheelLandedOn <= 36) && WheelLandedOn % 2 == 0)
                                money += bets[i].Payout();
                            break;
                        case 150:
                            if (WheelLandedOn == 2 || WheelLandedOn == 4 || WheelLandedOn == 6 || WheelLandedOn == 8 || WheelLandedOn == 10 || WheelLandedOn == 11 ||
                                WheelLandedOn == 13 || WheelLandedOn == 15 || WheelLandedOn == 17 || WheelLandedOn == 20 || WheelLandedOn == 22 || WheelLandedOn == 24 ||
                                WheelLandedOn == 26 || WheelLandedOn == 28 || WheelLandedOn == 29 || WheelLandedOn == 31 || WheelLandedOn == 33 || WheelLandedOn == 35)
                                money += bets[i].Payout();
                            break;
                        case 151:
                            if (WheelLandedOn == 1 || WheelLandedOn == 3 || WheelLandedOn == 5 || WheelLandedOn == 7 || WheelLandedOn == 9 || WheelLandedOn == 12 ||
                                WheelLandedOn == 14 || WheelLandedOn == 16 || WheelLandedOn == 18 || WheelLandedOn == 19 || WheelLandedOn == 21 || WheelLandedOn == 23 ||
                                WheelLandedOn == 25 || WheelLandedOn == 27 || WheelLandedOn == 30 || WheelLandedOn == 32 || WheelLandedOn == 34 || WheelLandedOn == 36)
                                money += bets[i].Payout();
                            break;
                        case 152:
                            if ((WheelLandedOn >= 1 && WheelLandedOn <= 36) && WheelLandedOn % 2 == 1)
                                money += bets[i].Payout();
                            break;
                        case 153:
                            if (WheelLandedOn >= 19 && WheelLandedOn <= 36)
                                money += bets[i].Payout();
                            break;
                        default:
                            break;
                    }
                    #endregion
                    if (!bets[i].winningBet)
                        Console.WriteLine("Bet on position " + bets[i].Pos + " for " + bets[i].Value + " Lost!");
                }


                Console.WriteLine();
                if (money > 0)
                {
                    Console.WriteLine("Keep playing? 1 for Yes or 0 for No");
                    Int32.TryParse(Console.ReadLine(), out playAgain);
                }
            }

            if (money == 0)
                Console.WriteLine("Out of money!");
            
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();


        }

        
    }
}
