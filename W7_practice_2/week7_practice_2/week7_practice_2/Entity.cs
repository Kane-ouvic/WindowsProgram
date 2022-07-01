using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Data;



namespace week7_practice_2
{
    class Entity
    {
        protected Button block;
        protected String category;
        protected int speed;

        public void setLocation(int x, int y)
        {
            this.block.Location = new Point(x, y);
            
        }

        public void move(int x, int y)
        {
            this.block.Location = new Point(this.block.Location.X + x, this.block.Location.Y + y);
        }

        public int getLocationX()
        {
            return this.block.Location.X;
        }

        public int getLocationY()
        {
            return this.block.Location.Y;
        }

        public Button getBlock()
        {
            return this.block;
        }
   
        public String getCategory()
        {
            return this.category;
        }

        public int getSpeed()
        {
            return this.speed;
        }
    }
}
