using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber13
{
    class RoshamboApp
    {
        
        public static void PlayGame(List<Player> opponentList, string name)
        {
            Player player1; //Holds the player information
            bool keepPlaying = true; 
            int player1Wins = 0, player1Losses = 0;

            Console.Write("Would you like to play as...\n"); //Displays the player options
            DisplayOpponents(opponentList);
            Console.Write(" or 4) yourself?: ");
            int player = Validator.GetOpponent(opponentList.Count + 1);
            
            switch (player) //Initializes the player character
            {
                case 1:
                    player1 = opponentList[0];
                    break;
                case 2:
                    player1 = opponentList[1];
                    break;
                case 3:
                    player1 = opponentList[2];
                    break;
                default:
                    player1 = new UserPlayer(name);
                    break;
            }
                    

            Console.Write("Would you like to play against...\n");//Displays the list of Opponents
            DisplayOpponents(opponentList);
            Console.Write("?: ");
            int opponent = Validator.GetOpponent(opponentList.Count);        



            while (keepPlaying) //The game starts here with the above settings
            {

                player1.Rps = player1.GenerateRoshambo();
                opponentList[opponent - 1].Rps = opponentList[opponent - 1].GenerateRoshambo();
                Console.WriteLine($"\n{player1.Name}: {player1.Rps.ToString()}");
                Console.WriteLine($"{opponentList[opponent - 1].Name}: {opponentList[opponent - 1].Rps.ToString()}");

                //Generates the win conditions
                if (player1.Rps == opponentList[opponent - 1].Rps)
                {
                    Console.WriteLine("Draw!");
                }
                else if (player1.Rps == Roshambo.Rock && opponentList[opponent - 1].Rps == Roshambo.Scissors)
                {
                    Console.WriteLine("You win!");
                    player1Wins++;
                }
                else if (player1.Rps == Roshambo.Scissors && opponentList[opponent - 1].Rps == Roshambo.Paper)
                {
                    Console.WriteLine("You win!");
                    player1Wins++;
                }
                else if (player1.Rps == Roshambo.Paper && opponentList[opponent - 1].Rps == Roshambo.Rock)
                {
                    Console.WriteLine("You win!");
                    player1Wins++;
                }
                else
                {
                    Console.WriteLine("You lose!");
                    player1Losses++;
                }

                //Prompts user to continue
                //If they select no, then it prints out their stats for this session
                Console.WriteLine();
                keepPlaying = Validator.GetKeepPlaying("Play again?");
                if (keepPlaying == false)
                {
                    Console.WriteLine($"\n{player1.Name} won {player1Wins} time(s) and lost {player1Losses} time(s).\n");
                }
            }

        }        

        public static void DisplayOpponents(List<Player> opponentList)
        {
            for (int i = 0; i < opponentList.Count; i++)
            {
                Console.Write($"{i + 1}) {opponentList[i].Name}");
                if (i < opponentList.Count - 1)
                {
                    Console.Write(" or ");
                }
            }
        }
    }
}
