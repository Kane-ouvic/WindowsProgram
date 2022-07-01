using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week7_practice_2
{
    public partial class Form1 : Form
    {
        Enemy enemy1 = new Enemy("fire");
        Enemy enemy2 = new Enemy("water");
        Enemy enemy3 = new Enemy("tree");
        Enemy enemy4 = new Enemy("tree");

        Player player;
        String pre_attribute;
        Bullet[] bullet = new Bullet[60];
        int bullet_amount = 0;
        int cooldown = 0;
        bool shoot = false;
        bool isGameEnd = false;
        int timer = 600;

        //Enemy enemy1; Enemy enemy2;
        //Enemy enemy3; Enemy enemy4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }



        private void button6_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) //左右移動
            {
                if(player.getLocationX() != 50)
                {
                    player.move(-50, 0);
                    //Controls.Add(player.getBlock());
                }

            } 
            else if(e.KeyCode == Keys.D)
            {
                if(player.getLocationX() != 200)
                {
                    player.move(50, 0);
                }
            }

            if(e.KeyCode == Keys.W) //發射子彈
            {
                if(shoot == false && cooldown == 0)
                {
                    bullet[bullet_amount] = new Bullet(player.getCategory());
                    bullet[bullet_amount].setLocation(player.getLocationX() + 10, player.getLocationY());
                    Controls.Add(bullet[bullet_amount].getBlock());
                    bullet_amount++;
                    shoot = true;
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            enemyMove();
            bulletMove();
            checkBottom();
            checkTop();

            pre_attribute = player.getCategory();
            conflict(enemy1);
            conflict(enemy2);
            conflict(enemy3);
            conflict(enemy4);
            bulletConflict(enemy1);
            bulletConflict(enemy2);
            bulletConflict(enemy3);
            bulletConflict(enemy4);

            checkScores();
            printAttribute();

            if (shoot == true)
            {
                cooldown++;
            }
            if (cooldown == 10)
            {
                shoot = false;
                cooldown = 0;
            }
            if(timer == 0)
            {
                timer_text.Text = Convert.ToString(timer/10);
                gameEnd();
                MessageBox.Show("遊戲結束\n" + "你的分數: " + scores_text.Text, "", MessageBoxButtons.OK);
                System.Environment.Exit(0);

            } else
            {
                timer_text.Text = Convert.ToString(timer/10);
                timer--;
            }

        }

        private void setTimer()
        {
            timer1.Interval = 100;
            timer1.Enabled = true;

        }

        private void conflict(Enemy enemy)
        {
            if(Math.Abs(player.getLocationY() - enemy.getLocationY()) < 40 && player.getLocationX() == enemy.getLocationX())
            {
                if(player.getCategory() == "water")
                {
                    if(enemy.getCategory() == "fire")
                    {
                        scores_text.Text = Convert.ToString(int.Parse(scores_text.Text) + 5);
                        player.changeAttributes("fire");
                        randGenerate(enemy);
                    } else if (enemy.getCategory() == "tree")
                    {
                        scores_text.Text = Convert.ToString(int.Parse(scores_text.Text) - 5);
                        player.changeAttributes("tree");
                        randGenerate(enemy);
                    } else
                    {

                    }
                } else if (player.getCategory() == "fire")
                {
                    if (enemy.getCategory() == "tree")
                    {
                        scores_text.Text = Convert.ToString(int.Parse(scores_text.Text) + 5);
                        player.changeAttributes("tree");
                        randGenerate(enemy);
                    }
                    else if (enemy.getCategory() == "water")
                    {
                        scores_text.Text = Convert.ToString(int.Parse(scores_text.Text) - 5);
                        player.changeAttributes("water");
                        randGenerate(enemy);
                    }
                    else
                    {

                    }
                } else if (player.getCategory() == "tree")
                {
                    if (enemy.getCategory() == "water")
                    {
                        scores_text.Text = Convert.ToString(int.Parse(scores_text.Text) + 5);
                        player.changeAttributes("water");
                        randGenerate(enemy);
                    }
                    else if (enemy.getCategory() == "fire")
                    {
                        scores_text.Text = Convert.ToString(int.Parse(scores_text.Text) - 5);
                        player.changeAttributes("fire");
                        randGenerate(enemy);
                    }
                    else
                    {

                    }
                }
            }
        }

        private void bulletConflict(Enemy enemy)
        {
            for(int i = 0; i < bullet_amount; i++)
            {
                if (Math.Abs(bullet[i].getLocationY() - enemy.getLocationY()) < 40 && bullet[i].getLocationX() - 10 == enemy.getLocationX())
                {
           
                    if (bullet[i].getCategory() == "water")
                    {
                        if(enemy.getCategory() == "fire")
                        {
                            scores_text.Text = Convert.ToString(int.Parse(scores_text.Text) + 2);
                        } else if (enemy.getCategory() == "tree")
                        {
                            scores_text.Text = Convert.ToString(int.Parse(scores_text.Text) - 2);
                        }
                    }
                    if (bullet[i].getCategory() == "fire")
                    {
                        if (enemy.getCategory() == "tree")
                        {
                            scores_text.Text = Convert.ToString(int.Parse(scores_text.Text) + 2);
                        }
                        else if (enemy.getCategory() == "water")
                        {
                            scores_text.Text = Convert.ToString(int.Parse(scores_text.Text) - 2);
                        }
                    }
                    if (bullet[i].getCategory() == "tree")
                    {
                        if (enemy.getCategory() == "water")
                        {
                            scores_text.Text = Convert.ToString(int.Parse(scores_text.Text) + 2);
                        }
                        else if (enemy.getCategory() == "fire")
                        {
                            scores_text.Text = Convert.ToString(int.Parse(scores_text.Text) - 2);
                        }
                    }
                    randGenerate(enemy);
                    Controls.Remove(bullet[i].getBlock());
                    bullet[i].setLocation(0, 0);
                }
            }
        }

        private void checkBottom()
        {
            if (enemy1.getLocationY() >= 400)
            {
                //enemy1.setLocation(50, 50);
                randGenerate(enemy1);
            }
            if(enemy2.getLocationY() >= 400)
            {
                //enemy2.setLocation(100, 50);
                randGenerate(enemy2);
            }
            if(enemy3.getLocationY() >= 400)
            {
                //enemy3.setLocation(150, 50);
                randGenerate(enemy3);
            }
            if(enemy4.getLocationY() >= 400)
            {
                //enemy4.setLocation(200, 50);
                randGenerate(enemy4);
            }
        }

        private void randGenerate(Enemy enemy)
        {
            Random rand = new Random();
            switch (rand.Next(0, 3))
            {
                case 0:
                    enemy.changeAttributes("fire");
                    break;
                case 1:
                    enemy.changeAttributes("water");
                    break;
                case 2:
                    enemy.changeAttributes("tree");
                    break;
            }
            enemy.setLocation(enemy.getLocationX(), 50);
        }

        private void enemyMove()
        {
            enemy1.move(0, enemy1.getSpeed());
            enemy2.move(0, enemy2.getSpeed());
            enemy3.move(0, enemy3.getSpeed());
            enemy4.move(0, enemy4.getSpeed());
        }

        private void checkTop()
        {
            for(int i = 0; i < bullet_amount; i++)
            {
                if(bullet[i].getLocationY() <= 50)
                {
                    Controls.Remove(bullet[i].getBlock());
                }
            }
        }

        private void bulletMove()
        {
            for(int i = 0; i < bullet_amount; i++)
            {
                bullet[i].move(0, -bullet[i].getSpeed());
            }
        }

        private void gameEnd()
        {
            isGameEnd = true;
            timer1.Enabled = false;
        }

        private void checkScores()
        {
            if(int.Parse(scores_text.Text) < 0)
            {
                scores_text.Text = "0";
                gameEnd();
                if (pre_attribute == "fire")
                {
                    MessageBox.Show("你被熄滅了!\n" + "你的分數: 0", "", MessageBoxButtons.OK);
                    System.Environment.Exit(0);

                }
                else if (pre_attribute == "water")
                {
                    MessageBox.Show("你枯竭了!\n" + "你的分數: 0", "", MessageBoxButtons.OK);
                    System.Environment.Exit(0);
                }
                else if (pre_attribute == "tree")
                {
                    MessageBox.Show("你燒起來了!\n" + "你的分數: 0", "", MessageBoxButtons.OK);
                    System.Environment.Exit(0);
                }
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            if(water_button.Checked == true)
            {
                player = new Player("water");
                attribute_text.Text = "水";
            } else if(fire_button.Checked == true)
            {
                player = new Player("fire");
                attribute_text.Text = "火";
            } else if(tree_button.Checked == true)
            {
                player = new Player("tree");
                attribute_text.Text = "木";
            }

            player.setLocation(200, 300);
            Controls.Add(player.getBlock());

            enemy1.setLocation(50, 50);
            enemy2.setLocation(100, 50);
            enemy3.setLocation(150, 50);
            enemy4.setLocation(200, 50);

            Random rand = new Random();
            int num1, num2, num3, num4;
            num1 = rand.Next(0, 3);
            num2 = rand.Next(0, 3);
            num3 = rand.Next(0, 3);
            num4 = rand.Next(0, 3);

            initEnemy(enemy1, num1);
            initEnemy(enemy2, num2);
            initEnemy(enemy3, num3);
            initEnemy(enemy4, num4);

            Controls.Add(enemy1.getBlock());
            Controls.Add(enemy2.getBlock());
            Controls.Add(enemy3.getBlock());
            Controls.Add(enemy4.getBlock());

            attribute_label.Visible = true;
            attribute_text.Visible = true;
            scores_label.Visible = true;
            scores_text.Visible = true;
            timer_label.Visible = true;
            timer_text.Visible = true;

            choice_label.Visible = false;
            water_button.Visible = false;
            fire_button.Visible = false;
            tree_button.Visible = false;
            start_button.Visible = false;

            setTimer();
        }
        private void printAttribute()
        {
            if (player.getCategory() == "water")
            {
                attribute_text.Text = "水";
            }
            else if (player.getCategory() == "fire")
            {
                attribute_text.Text = "火";
            }
            else if (player.getCategory() == "tree")
            {
                attribute_text.Text = "木";
            }
        }

        private void initEnemy(Enemy enemy, int num)
        {
            switch (num)
            {
                case 0:
                    enemy.changeAttributes("fire");
                    break;
                case 1:
                    enemy.changeAttributes("water");
                    break;
                case 2:
                    enemy.changeAttributes("tree");
                    break;
            }
        }
    }


}
