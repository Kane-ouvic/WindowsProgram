using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5_p2
{
    class Chicken
    {
        public String name;
        public int age;
        public int health;
        public int weight;
        public int satisfaction;
        public int emotion;
        public int player_money;
        public bool isDirty;
        public bool isSick;
        public bool isLay;
        public bool isDead;

        public Chicken(String name1, int age1, int health1, int weight1, int satisfaction1, int emotion1, int player_money1, bool isDirty1, bool isSick1, bool isLay1, bool isDead1)
        {
            this.name = name1;
            this.age = age1;
            this.health = health1;
            this.weight = weight1;
            this.satisfaction = satisfaction1;
            this.emotion = emotion1;
            this.player_money = player_money1;
            this.isDirty = isDirty1;
            this.isSick = isSick1;
            this.isLay = isLay1;
            this.isDead = isDead1;
            

        }

        public void Feed()
        {
            this.player_money -= 10;
            Random rand = new Random();
            this.satisfaction += rand.Next(0, 20);
            this.weight += rand.Next(50, 100);
            if(this.isDirty)
            {
                this.health -= 10;
            }
            fixStats();

        }

        public bool canFeed()
        {
            if (this.player_money < 10)
            {
                return false;
            } else
            {
                return true;
            }
            
        }

        public void Play()
        {
            this.player_money -= 5;
            Random rand = new Random();
            this.health += rand.Next(0, 20);
            this.emotion += rand.Next(0, 20);
            this.satisfaction -= rand.Next(0, 20);
            fixStats();

        }

        public bool canPlay()
        {
            if (this.player_money < 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Clean()
        {
            this.player_money -= 5;
            this.isDirty = false;

        }

        public bool canClean()
        {
            if (this.player_money < 5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void GoToDoctor()
        {
            this.player_money -= 20;
            this.health += 30;
            this.emotion -= 20;
            this.isSick = false;
            fixStats();

        }

        public bool canGotoDoctor()
        {
            if (this.player_money < 20)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Poop()
        {
            if(this.satisfaction >= 50)
            {
                this.isDirty = true;
            }
            
        }

        public void Sick()
        {
            Random rand = new Random();
            if(this.health <= 50 && this.emotion <= 50 && rand.Next(0, 99) < 100 - this.health)
            {
                this.isSick = true;
            }
        }

        public void Lay()
        {
            Random rand = new Random();
            if (this.weight > 1000 && this.health > 60 && rand.Next(0,99) < this.emotion)
            {

                this.health -= 5;
                this.isLay = true;
                fixStats();
            } else
            {
                this.isLay = false;
                fixStats();
            }
            

        }

        public int earn()
         {
            if (isLay)
            {
                Random rand = new Random();
                int bonus = rand.Next(15, 25);
                this.player_money += bonus;
                return bonus;
            }
            return 0;
        }

        public void Death()
        {
            Random rand = new Random();
            if(this.health < 10 && this.weight < 1000 && rand.Next(0, 99) < 100 - this.emotion)
            {
                this.isDead = true;
            }

        }

        public void EndDay()
        {
            this.satisfaction -= 20;
            fixStats();
            if (this.satisfaction == 0)
            {
                this.weight -= 200;
            }
            if (this.isSick)
            {
                this.weight -= 150;
                this.emotion -= 20;
            }
            if (this.isDirty) this.health -= 30;
            if (this.age %10 == 0) this.health -= 10;
            fixStats();
            Death();
            Poop();
            Lay();
            Sick();
            age++;
            
        }

        public void fixStats()
        {
            if (this.health > 100) this.health = 100;
            if (this.health < 0) this.health = 0;
            if (this.weight > 4000) this.weight = 4000;
            if (this.weight < 600) this.weight = 600;
            if (this.satisfaction > 100) this.satisfaction = 100;
            if (this.satisfaction < 0) this.satisfaction = 0;
            if (this.emotion > 100) this.emotion = 100;
            if (this.emotion < 0) this.emotion = 0;
        }

    }
}
