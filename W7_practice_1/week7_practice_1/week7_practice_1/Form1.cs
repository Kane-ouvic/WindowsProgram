using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week7_practice_1
{
    public partial class Form1 : Form
    {
        //Button[,] game_blocks;
        Button[,] game_blocks = new Button[4, 6];
        Boolean easyMode = true;
        Boolean gameEnd = false;
        Boolean gameStart = false;
    
        int seconds = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] game_blocks = new Button[4, 6];

            for (int j = 0; j < 6; j++)
            {
                for(int i = 0; i < 4; i++)
                {
                    game_blocks[i, j] = new System.Windows.Forms.Button();
                    game_blocks[i, j].Size = new Size(50,50);
                    game_blocks[i, j].Visible = true;
                    game_blocks[i, j].Location = new Point(20 + 60 * i, 80 + 60 * j);
                    Controls.Add(game_blocks[i, j]);

                }
            }
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    game_blocks[i, j] = new System.Windows.Forms.Button();
                    game_blocks[i, j].Size = new Size(50, 50);
                    game_blocks[i, j].Visible = false;
                    game_blocks[i, j].Location = new Point(20 + 60 * i, 80 + 60 * j);
                    Controls.Add(game_blocks[i, j]);

                }
            }
        }


        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (gameEnd == true) return;
            if (e.KeyCode == Keys.Q && gameEnd == false && gameStart == true)
            {
                for(int i = 5; i >= 0; i--)
                {
                    if(game_blocks[0, i].Text == "")
                    {
                        game_blocks[0, i].Text = number_print.Text;
                        break;
                    }
                }
                if(easyMode == false)
                {
                    seconds = 3;
                }
            } else if (e.KeyCode == Keys.W && gameEnd == false && gameStart == true)
            {
                for (int i = 5; i >= 0; i--)
                {
                    if (game_blocks[1, i].Text == "")
                    {
                        game_blocks[1, i].Text = number_print.Text;
                        break;
                    }
                }
                if (easyMode == false)
                {
                    seconds = 3;
                }
            } else if (e.KeyCode == Keys.E && gameEnd == false && gameStart == true)
            {
                for (int i = 5; i >= 0; i--)
                {
                    if (game_blocks[2, i].Text == "")
                    {
                        game_blocks[2, i].Text = number_print.Text;
                        break;
                    }
                }
                if (easyMode == false)
                {
                    seconds = 3;
                }
            } else if (e.KeyCode == Keys.R && gameEnd == false && gameStart == true)
            {
                for (int i = 5; i >= 0; i--)
                {
                    if (game_blocks[3, i].Text == "")
                    {
                        game_blocks[3, i].Text = number_print.Text;
                        break;
                    }
                }
                if (easyMode == false)
                {
                    seconds = 3;
                }
            }

            if(e.KeyCode == Keys.A && easyMode == true && gameStart == true)
            {
                number_print.Text = "2";
            } else if(e.KeyCode == Keys.S && easyMode == true && gameStart == true)
            {
                number_print.Text = "4";
            } else if(e.KeyCode == Keys.D && easyMode == true && gameStart == true)
            {
                number_print.Text = "8";
            }

            dealWith();
            printResult();
            if (checkOversize())
            {
                MessageBox.Show("遊戲結束!!!\n" + "你的分數: " + score_print.Text , "", MessageBoxButtons.OK);
                gameEnd = true;
                System.Environment.Exit(0);
            }

            if (easyMode == false)
            {
                Random rand = new Random();
                switch (rand.Next(0, 3))
                {
                    case 0:
                        number_print.Text = "2";
                        break;

                    case 1:
                        number_print.Text = "4";
                        break;

                    case 2:
                        number_print.Text = "8";
                        break;

                }
            }
            //deleteRows();
        }

        private Boolean integrateNumber()
        {
            Boolean isIntegrate = false;
            for(int i = 0; i < 4; i++)
            {
                for(int j = 5; j > 0; j--)
                {
                    if(game_blocks[i,j].Text == game_blocks[i, j - 1].Text && game_blocks[i, j].Text != "" && game_blocks[i, j-1].Text != "")
                    {
                        int sum = int.Parse(game_blocks[i, j].Text) + int.Parse(game_blocks[i, j - 1].Text);
                        game_blocks[i, j].Text = Convert.ToString(sum);
                        //game_blocks[i, j-1].Text = "";
                        for(int k = j-1; k > 0; k--)
                        {
                            game_blocks[i, k].Text = game_blocks[i, k - 1].Text;
                        }
                        isIntegrate = true;

                    }
                }
            }
            return isIntegrate;
        }
        private Boolean deleteRows()
        {
            Boolean isDelete = false;
            for(int j = 5; j >= 0; j--)
            {
                if(game_blocks[0,j].Text != "" && game_blocks[0,j].Text == game_blocks[1,j].Text && game_blocks[0, j].Text == game_blocks[2, j].Text && game_blocks[0, j].Text == game_blocks[3, j].Text)
                {
                    int score = int.Parse(game_blocks[0, j].Text);
                    int sum = int.Parse(score_print.Text) + score * score;
                    game_blocks[0, j].Text = ""; game_blocks[1, j].Text = "";
                    game_blocks[2, j].Text = ""; game_blocks[3, j].Text = "";
                    for (int k = j; k > 0; k--)
                    {
                        game_blocks[0, k].Text = game_blocks[0, k - 1].Text;
                        game_blocks[1, k].Text = game_blocks[1, k - 1].Text;
                        game_blocks[2, k].Text = game_blocks[2, k - 1].Text;
                        game_blocks[3, k].Text = game_blocks[3, k - 1].Text;
                    }

                    score_print.Text = Convert.ToString(sum);
                    isDelete = true;
                }
            }
            return isDelete;
        }

        private void dealWith()
        {
            Boolean done = false;
            Boolean isIntegrate = true;
            Boolean isDelete = false;

            while (!done)
            {
                while(isIntegrate)
                {
                    isIntegrate = integrateNumber();
                }
          
                isDelete = deleteRows();
                if (integrateNumber())
                {
                    isIntegrate = true;
                    continue;
                }
                if (!isIntegrate && !isDelete) done = true;
            }
        }

        private Boolean checkOversize()
        {
            for(int i = 0; i < 4; i++)
            {
                if (game_blocks[i, 0].Text != "") return true;
            }

            return false;
        }

        private void printResult()
        {
            for(int j = 0; j < 6; j++)
            {
                for(int i = 0; i < 4; i++)
                {
                    if(game_blocks[i, j].Text != "")
                    {
                        game_blocks[i, j].Visible = true;
                    } else
                    {
                        game_blocks[i, j].Visible = false;
                    }
                }
            }
        }

        private void setTimer()
        {
            //timer1.Enabled = false;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer_print.Text = Convert.ToString(seconds);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gameEnd == true) return;
            timer_print.Text = Convert.ToString(seconds);
            if (seconds == 0)
            {
                seconds = 3;
                Random rand = new Random();
                int category = rand.Next(0, 3);
                switch (category)
                {
                    case 0:
                        for (int i = 5; i >= 0; i--)
                        {
                            if (game_blocks[1, i].Text == "")
                            {
                                game_blocks[1, i].Text = "2";
                                break;
                            }
                        }
                        break;

                    case 1:
                        for (int i = 5; i >= 0; i--)
                        {
                            if (game_blocks[1, i].Text == "")
                            {
                                game_blocks[1, i].Text = "4";
                                break;
                            }
                        }
                        break;

                    case 2:
                        for (int i = 5; i >= 0; i--)
                        {
                            if (game_blocks[1, i].Text == "")
                            {
                                game_blocks[1, i].Text = "8";
                                break;
                            }
                        }
                        break;
                }
                dealWith();
                printResult();
                if (checkOversize())
                {
                    timer1.Enabled = false;
                    MessageBox.Show("遊戲結束!!!\n" + "你的分數: " + score_print.Text, "", MessageBoxButtons.OK);
                    gameEnd = true;
                    System.Environment.Exit(0);
                }

            } else
            {
                seconds--;
            }

        }

        private void easy_mode_Click(object sender, EventArgs e)
        {
            gameStart = true;
            timer1.Enabled = false;
            timer_label.Visible = false;
            timer_print.Visible = false;
            score_label.Visible = true;
            score_print.Visible = true;
            number_label.Visible = true;
            number_print.Visible = true;
            easy_mode.Visible = false;
            normal_mode.Visible = false;
        }

        private void normal_mode_Click(object sender, EventArgs e)
        {
            gameStart = true;
            easyMode = false;
            timer_label.Visible = true;
            timer_print.Visible = true;
            score_label.Visible = true;
            score_print.Visible = true;
            number_label.Visible = true;
            number_print.Visible = true;
            easy_mode.Visible = false;
            normal_mode.Visible = false;
            setTimer();
        }
    }
}
