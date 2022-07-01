using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace week8_practice_2
{
    class Warrior : Character
    {
        //public string name;
        public Warrior(string player)
        {
            this.name = "戰士";
            this.numA = -1;
            this.numB = 0;
            this.numC = 0;
            this.numD = 5;
            if(player == "P1")
            {
                color = Color.DeepSkyBlue;
            }
            else if(player == "P2")
            {
                color = Color.Orange;
                this.numD++;
            }
        }
    }
}
