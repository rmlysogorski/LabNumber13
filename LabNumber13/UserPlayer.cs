using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber13
{
    class UserPlayer : Player
    {
        public UserPlayer(string _name):base(_name){  }

        public override Roshambo GenerateRoshambo()
        {
            return Validator.GetRockPaperScissors("\nRock, paper or scissors? (R/P/S): ");
        }
    }
}
