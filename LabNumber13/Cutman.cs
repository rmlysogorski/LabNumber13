using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber13
{
    class Cutman : Player
    {
        public Cutman()
        {
            Name = "Cutman";
            Rps = GenerateRoshambo();
        }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Scissors;
        }
    }
}
