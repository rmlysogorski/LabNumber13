using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber13
{
    class Validator
    {
        public static string GetName(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if(input == string.Empty)
            {
                Console.WriteLine("Oops - you forgot to type your name!");
                return GetName(message);
            }
            else
            {
                return input;
            }
        }

        public static int GetOpponent(int listLength)
        {
            string input = Console.ReadLine();
            if(input == string.Empty)
            {
                Console.WriteLine("Are you too chicken to choose?");
                return GetOpponent(listLength);
            }
            else if(!int.TryParse(input, out int number))
            {
                Console.WriteLine($"Please enter a number between 1-{listLength}");
                return GetOpponent(listLength);
            }
            else if(number < 1 || number > listLength)
            {
                Console.WriteLine($"Please enter a number between 1-{listLength}");
                return GetOpponent(listLength);
            }
            else
            {
                return number;
            }
        }

        public static Roshambo GetRockPaperScissors(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine().ToLower();
            if(input == "r" || input == "rock")
            {
                return Roshambo.Rock;
            }
            else if(input == "p" || input == "paper")
            {
                return Roshambo.Paper;
            }
            else if (input == "s" || input == "scissors")
            {
                return Roshambo.Scissors;
            }
            else
            {
                Console.WriteLine("Make your choice R - rock, P - paper or S - scissors.");
                return GetRockPaperScissors(message);
            }
        }

        public static bool GetKeepPlaying(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine().ToLower();
            if(input == "y")
            {
                return true;
            }
            else if(input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please enter \"y\" for yes or \"n\" for no.");
                return GetKeepPlaying(message);
            }
        }
    }
}
