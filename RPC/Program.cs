using System;

namespace RPC
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.Write("Choose between Rock, Paper or Scissors: ");
                    string inputPlayer = Console.ReadLine().ToLower(); // Convert input to lowercase

                    Random rnd = new Random();
                    int randInt = rnd.Next(1, 4); // Generate a new random number for each round

                    string inputCPU = "";

                    switch (randInt)
                    {
                        case 1:
                            inputCPU = "rock";
                            Console.WriteLine("Computer Choose 'ROCK'");
                            break;
                        case 2:
                            inputCPU = "paper";
                            Console.WriteLine("Computer Choose 'PAPER'");
                            break;
                        case 3:
                            inputCPU = "scissors";
                            Console.WriteLine("Computer Choose 'SCISSORS'");
                            break;
                    }
                    System.Console.WriteLine("\n\nScores:\tPLAYER:\t(0)\tCPU:\t(1)", scorePlayer, scoreCPU);

                    if (inputPlayer == inputCPU)
                    {
                        Console.WriteLine("DRAW...!! \n");
                    }
                    else if ((inputPlayer == "rock" && inputCPU == "scissors") ||
                             (inputPlayer == "paper" && inputCPU == "rock") ||
                             (inputPlayer == "scissors" && inputCPU == "paper"))
                    {
                        Console.WriteLine("Player Wins...!! \n");
                        scorePlayer++;
                    }
                    else
                    {
                        Console.WriteLine("Computer Wins...!! \n");
                        scoreCPU++;
                    }
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player wins..!!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("Computer wins...!");
                }
                
                Console.WriteLine("Do you want to play again? (y/n)");
                string loop = Console.ReadLine();
                if (loop == "y" || loop == "Y" || loop == "yes" || loop == "YES")
                {
                    playAgain = true;
                    Console.Clear();
                }else if (loop == "n" || loop == "N" || loop == "No" || loop == "NO")
                {
                    playAgain = false;
                }
            }
        }
    }
}
