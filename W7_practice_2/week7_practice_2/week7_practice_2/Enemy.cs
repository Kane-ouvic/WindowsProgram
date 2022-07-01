using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace week7_practice_2
{
    class Enemy : Entity
    {
        public Enemy(String category)
        {
            this.category = category;
            this.block = new Button();
            setAttributes();
        }

        public void setAttributes()
        {
            this.block.Size = new Size(40, 40);
            if(this.category == "fire")
            {
                this.block.Text = "火";
                this.block.BackColor = Color.Red;
                this.speed = 20;
            }
            else if(this.category == "water")
            {
                this.block.Text = "水";
                this.block.BackColor = Color.Blue;
                this.speed = 10;
            }
            else if(this.category == "tree")
            {
                this.block.Text = "木";
                this.block.BackColor = Color.Green;
                this.speed = 30;
            }
        }

        public void changeAttributes(String category)
        {
            this.category = category;
            if (category == "fire")
            {
                this.block.Text = "火";
                this.block.BackColor = Color.Red;
                this.speed = 20;
            }
            else if (category == "water")
            {
                this.block.Text = "水";
                this.block.BackColor = Color.Blue;
                this.speed = 10;
            }
            else if (category == "tree")
            {
                this.block.Text = "木";
                this.block.BackColor = Color.Green;
                this.speed = 30;
            }
        }
    }
}
