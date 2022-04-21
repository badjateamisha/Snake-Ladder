using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO SNAKE AND LADDER!");

            int playerposition = 0;
            Random random = new Random();

            int win = 100;
            int count = 0;
            while (playerposition < win)
            {
                int rollDie = random.Next(1, 7);
                count++;
                Console.WriteLine("Output of rolled dice is " + rollDie);

                int options = random.Next(0, 3);

                switch (options)
                {
                    case 0:
                        Console.WriteLine("NO PLAY");
                        playerposition += 0;
                        break;
                    case 1:
                        Console.WriteLine("LADDER");
                        playerposition += rollDie;
                        break;
                    case 2:

                        Console.WriteLine("SNAKE");
                        playerposition -= rollDie;
                        if (playerposition < 0)
                        {
                            playerposition = 0;
                        }
                        break;
                    default:
                        break;
                }
                if (playerposition > win)
                {
                    playerposition -= rollDie;
                }
                Console.WriteLine("Player is at " + playerposition);

            }
            if (playerposition == win)
            {
                Console.WriteLine("IT'S A WIN!");
            }

            Console.WriteLine("Number of times the dice rolled to Win the game is " + count);
        }
    }
}

