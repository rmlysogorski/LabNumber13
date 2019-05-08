using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber13
{
    abstract class Player
    {
        #region Data members
        private string name;
        private Roshambo rps;
        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public Roshambo Rps { get => rps; set => rps = value; }
        #endregion

        #region Constructors
        public Player() { }
        public Player(string _name)
        {
            name = _name;
        }
        #endregion

        #region Methods
        public abstract Roshambo GenerateRoshambo();

        #endregion
    }
}
