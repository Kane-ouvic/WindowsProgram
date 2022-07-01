using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace week8_practice_2
{
    class Archer : Character
    {
        //public string name;
        public Archer(string player)
        {
            this.name = "弓箭手";
            this.numA = -1;
            this.numB = 1;
            this.numC = 1;
            this.numD = 3;
            if (player == "P1")
            {
                color = Color.BlueViolet;
            }
            else if (player == "P2")
            {
                color = Color.OrangeRed;
                this.numD++;
            }
        }
    }
}
