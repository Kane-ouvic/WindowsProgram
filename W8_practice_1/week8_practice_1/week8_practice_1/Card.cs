using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace week8_practice_1
{
    class Card : Button
    {
        public int number;

        public Card(int number)
        {
            this.number = number;
            this.Text = Convert.ToString(number);
            this.BackColor = Color.AliceBlue;
        }

        public void hideNumber()
        {
            this.Text = "";
            this.BackColor = Color.Gray;
        }

        public void showNumber()
        {
            this.Text = Convert.ToString(number);
            this.BackColor = Color.AliceBlue;
        }   

    }
}
