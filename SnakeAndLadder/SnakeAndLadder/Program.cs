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
            playerOne.PlayerCheck();
        }

        //variable declaration
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        public const int Winning = 100;
        public const int Start = 0;
        public int Count = 0;
        public int Player1Position = 0;
        public int Player2Position = 0;
        bool Player1 = true;
        bool Player2 = false;



        Random random = new Random();
        public int DieRolling()
        {
            int roll = random.Next(1, 7);
            return roll;

        }
        public void PlayerCheck()
        {
            while (Player1Position < Winning && Player2Position < Winning)
            {
                if (Player1)
                {
                    int dieRolling = this.DieRolling();
                    int option = random.Next(0, 3);
                    switch (option)
                    {
                        case No_Play:
                            break;

                        case Ladder:
                            this.Player1Position += dieRolling;
                            if (this.Player1Position > Winning)
                            {
                                this.Player1Position -= dieRolling;
                            }
                            Console.WriteLine("`~~~~~~~~~~~~~~~~~Got Ladder~~~~~~~~~~~~~~~\n");
                            break;

                        case Snake:
                            this.Player1Position -= dieRolling;
                            if (this.Player1Position < 0)
                            {
                                this.Player1Position = Start;
                            }
                            Player2 = true;
                            Player1 = false;
                            Console.WriteLine("`~~~~~~~~~~~~~~~~~Got Snake~~~~~~~~~~~~~~~\n");
                            break;

                    }
                    Count++;
                    Console.WriteLine("The Position of Player1 is :" + this.Player1Position + " " + "with a roll of " + dieRolling);
                }
                if (Player2)
                {
                    int dieRolling = this.DieRolling();
                    int option = random.Next(0, 3);
                    switch (option)
                    {
                        case No_Play:
                            break;

                        case Ladder:
                            this.Player2Position += dieRolling;
                            if (this.Player2Position > Winning)
                            {
                                this.Player2Position -= dieRolling;
                            }
                            Console.WriteLine("`~~~~~~~~~~~~~~~~~Got Ladder~~~~~~~~~~~~~~~\n");
                            break;

                        case Snake:
                            this.Player2Position -= dieRolling;
                            if (this.Player2Position < 0)
                            {
                                this.Player2Position = Start;
                            }
                            Player2 = false;
                            Player1 = true;
                            Console.WriteLine("`~~~~~~~~~~~~~~~~~Got Snake~~~~~~~~~~~~~~~\n");
                            break;

                    }
                    Count++;
                    Console.WriteLine("The Position of Player2 is :" + this.Player2Position + " " + "with a roll of " + dieRolling);
                }
            }
            if (Player1Position == 100)
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~Congratulations Player1 Wins~~~~~~~~~~~");
            }
            if (Player2Position == 100)
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~ Congratulations Player2 Wins~~~~~~~~~~~~~");
            }


            Console.WriteLine("\nThe number of times dice was rolled in the Game is : " + Count);

        }
    }
}