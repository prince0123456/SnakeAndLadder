using System;
using System.Xml.Linq;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO SNAKE AND LADDER Game");
            SnakeAndLadder playerOne = new SnakeAndLadder();
            playerOne.DieRolling();
            //Console.WriteLine(playerOne.DieRolling());
            playerOne.PlayerCheck();
        }

        //variable declaration
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        public const int Winning = 100;
        public const int Start = 0;

        public int StartingPlayerPosition = 0;

        // uc-2 die rolling
        Random random = new Random();
        public int DieRolling()
        {
            int roll = random.Next(1, 7);
            return roll;
        }
        //uc3 player-check
        public void PlayerCheck()
        {
            while (StartingPlayerPosition < Winning)
            {
                int dieRolling = this.DieRolling();
                int option = random.Next(0, 3);
                switch (option)
                {
                    case No_Play:
                        break;

                    case Ladder:
                        this.StartingPlayerPosition += dieRolling;
                        if (this.StartingPlayerPosition > Winning)
                        {
                            this.StartingPlayerPosition -= dieRolling;
                        }
                        break;

                    case Snake:
                        this.StartingPlayerPosition -= dieRolling;
                        if (this.StartingPlayerPosition < 0)
                        {
                            this.StartingPlayerPosition = Start;
                        }

                        break;

                }

                Console.WriteLine("The Position of Player is :" + this.StartingPlayerPosition + " " + "with a roll of " + dieRolling);
            }

            Console.WriteLine("The Player wins the game");
        }
    }
}