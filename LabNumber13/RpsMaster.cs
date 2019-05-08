using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber13
{
    class RpsMaster : Player
    {
        private Random r = new Random();

        public RpsMaster()
        {
            Name = "The RPS Master";
            Rps = GenerateRoshambo();
        }

        public override Roshambo GenerateRoshambo()
        {
            
            switch (r.Next(1, 4))
            {
                case 1: return Roshambo.Rock;
                case 2: return Roshambo.Paper;
                default: return Roshambo.Scissors; 
            }
        }
    }
}
