using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rock Paper Scissors World Championship!\n");
            List<Player> opponentList = new List<Player> { new Cutman(), new TheRock(), new RpsMaster() };

            string player1;

            player1 = Validator.GetName("Enter your name: ");
            RoshamboApp.PlayGame(opponentList, player1);
        }
    }
}
