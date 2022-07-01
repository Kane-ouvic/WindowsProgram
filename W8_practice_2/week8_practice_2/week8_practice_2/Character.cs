using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace week8_practice_2
{
    class Character
    {
        public string name;
        public int numA;
        public int numB;
        public int numC;
        public int numD;

        public bool placeA = true;
        public bool placeB = false;
        public bool placeC = false;
        public bool placeD = false;

        public System.Drawing.Color color;

        public bool placeChessA(Button chess)
        {
            if (chess.BackColor == Color.Gray)
            {
                chess.BackColor = color;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool placeChessB(Button chess1, Button chess2)
        {
            numB--;
            
            if(chess1.BackColor == Color.Gray)
            {
                chess1.BackColor = color;
            }
            else
            {
                return false;
            }

            if (chess2 == null) return true;
            if (chess2.BackColor == Color.Gray) chess2.BackColor = color;

            return true;
            
        }
        public bool placeChessC(Button chess1, Button chess2)
        {
            numC--;

            if (chess1.BackColor == Color.Gray)
            {
                chess1.BackColor = color;
            }
            else
            {
                return false;
            }

            if (chess2 == null) return true;
            if (chess2.BackColor == Color.Gray) chess2.BackColor = color;

            return true;

        }

        public bool placeChessD(Button chess)
        {
            numD--;
            chess.BackColor = color;
            return true;
        }

    }
}
