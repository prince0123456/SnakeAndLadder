using System;
namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO SNAKE AND LADDER Game");
            SnakeAndLadder playerOne = new SnakeAndLadder();
            playerOne.DieRolling();
            Console.WriteLine(playerOne.DieRolling());
        }

        public int PlayerPosition = 0;
        // uc-2 die rolling
        Random random = new Random();
        public int DieRolling()
        {
            int roll = random.Next(1, 7);
            return roll;
        }
    }
}