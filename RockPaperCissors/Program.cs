using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GuessGame
{
    public class program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            string player;
            string computer;
            string answer;

            while(playAgain)
            {
                player = "";
                computer = "";
                answer = "";
                /*the nested loop is for the player in case he enter other words or integers 
                   then it'll ask him to enter only rock,paper and scissors*/
                while(player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }
                //the random method will start from 1 to 3
                switch(random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;

                }
                Console.WriteLine("player :" + player);
                Console.WriteLine("computer :" + computer);

                switch(player)
                {
                    case "ROCK":
                        if(computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if(computer == "PAPER")
                        {
                            Console.WriteLine("You lose");
                        }
                        else
                        {
                            Console.WriteLine("You win");
                        }
                        break;

                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else
                        {
                            Console.WriteLine("You lose");
                        }
                        break;

                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win");
                        }
                        else
                        {
                            Console.WriteLine("it's a draw");
                        }
                        break;
                }
                Console.Write("Would you like to play again(Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                /*this condition will help us to go back in our main loop
                  and start over if the user choose to continue  */
                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing");
            Console.ReadKey();
        }
    }
}