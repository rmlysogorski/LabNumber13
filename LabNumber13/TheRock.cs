using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber13
{
    class TheRock : Player
    {
        public TheRock()
        {
            Name = "The Rock";
            Rps = GenerateRoshambo();
        }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }

        
    }
}
