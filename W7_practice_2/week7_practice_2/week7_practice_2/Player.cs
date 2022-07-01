using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace week7_practice_2
{
    class Player : Entity
    {

        public Player(String category)
        {
            this.category = category;
            this.block = new Button();
            setAttributes();
        }

        public void setAttributes()
        {
            this.block.Size = new Size(40, 40);
            this.block.Text = "你";
            if(this.category == "fire")
            {
                this.block.BackColor = Color.Red;
            }
            else if(this.category == "water")
            {
                this.block.BackColor = Color.Blue;
            }
            else if(this.category == "tree")
            {
                this.block.BackColor = Color.Green;
            }

        }

        public void changeAttributes(String category)
        {
            this.category = category;
            if (category == "fire")
            {
                this.block.BackColor = Color.Red;
            }
            else if (category == "water")
            {
                this.block.BackColor = Color.Blue;
            }
            else if (category == "tree")
            {
                this.block.BackColor = Color.Green;
            }
        }


    }
}
