using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace week8_practice_1
{
    public partial class Form1 : Form
    {
        Card[,] cards;
        Card p1_card;
        Card p2_card;
        int rounds = 1;
        int p1_score = 0;
        int p2_score = 0;
        int p1_number = 0;
        int p2_number = 0;
        bool p1_draw = false;
        bool p2_draw = false;
        bool p1_first = true;
        int hide_time = 3;
        int show_time = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void hideAllcards()
        {
            for(int i = 0; i < cards.GetLength(0); i++)
            {
                for(int j = 0; j < cards.GetLength(1); j++)
                {
                    cards[i, j].hideNumber();
                }
            }
        }

        private void card_click(object sender, EventArgs e)
        {
            Card card = sender as Card;
            card.showNumber();
            int number = card.number;

            if(player_label.Text == "P1")
            {
                p1_card = card;
                if(p1_first == true)
                {
                    P1_P2_round(number);
                    player_label.Text = "P2";
                } else
                {
                    P2_P1_round(number);
                }
                
            }
            else if(player_label.Text == "P2")
            {
                p2_card = card;
                if (p1_first == true)
                {
                    P1_P2_round(number);
                }
                else
                {
                    P2_P1_round(number);
                    player_label.Text = "P1";
                }
                
            }

            if (p1_draw == true && p2_draw == true)
            {
                timer2.Enabled = true;
                cantDraw();
            }
            printRound();
        }

        private void setTimer()
        {
            timer1.Interval = 1000;
            timer2.Interval = 1000;
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(hide_time == 0)
            {
                hideAllcards();
                canDraw();
            }
            hide_time--;
        }

        private void P1_P2_round(int number)
        {
            if(p1_draw == false && player_label.Text == "P1")
            {
                p1_number = number;
                p1_draw = true;
            }
            else if(p2_draw == false && player_label.Text == "P2")
            {
                p2_number = number;
                p2_draw = true;
            }

        }
        private void P2_P1_round(int number)
        {
            if (p1_draw == false && player_label.Text == "P1")
            {
                p1_number = number;
                p1_draw = true;
            }
            else if (p2_draw == false && player_label.Text == "P2")
            {
                p2_number = number;
                p2_draw = true;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(show_time == 0)
            {
                show_time = 3;
                timer2.Enabled = false;
                if(p1_first == true)
                {
                    if(p2_number > p1_number)
                    {
                        p2_score += p2_number - p1_number;
                        p1_card.Visible = false;
                        p2_card.Visible = false;
                    } else
                    {
                        p1_card.hideNumber();
                        p2_card.hideNumber();
                    }
                }
                else
                {
                    if (p1_number > p2_number)
                    {
                        p1_score += p1_number - p2_number;
                        p1_card.Visible = false;
                        p2_card.Visible = false;
                    }
                    else
                    {
                        p1_card.hideNumber();
                        p2_card.hideNumber();
                    }
                }
                rounds++;
                p1_draw = false;
                p2_draw = false;
                if (rounds % 2 == 0)
                {
                    p1_first = false;
                    player_label.Text = "P2";
                }
                else
                {
                    p1_first = true;
                    player_label.Text = "P1";
                }
                printRound();
                checkCards();
                canDraw();
            }

            show_time--;
        }

        private void printRound()
        {
            round_label.Text = "第" + Convert.ToString(rounds) + "回合 輪到";
            P1score_label.Text = "P1:" + Convert.ToString(p1_score) + "分";
            P2score_label.Text = "P2:" + Convert.ToString(p2_score) + "分";
        }

        private void cantDraw()
        {
            for(int i = 0; i < cards.GetLength(0); i++)
            {
                for(int j = 0; j < cards.GetLength(1); j++)
                {
                    cards[i, j].Enabled = false;
                }
            }
        }

        private void canDraw()
        {
            for (int i = 0; i < cards.GetLength(0); i++)
            {
                for (int j = 0; j < cards.GetLength(1); j++)
                {
                    cards[i, j].Enabled = true;
                }
            }
        }

        private void checkCards()
        {
            int count = 0;
            for (int i = 0; i < cards.GetLength(0); i++)
            {
                for (int j = 0; j < cards.GetLength(1); j++)
                {
                    if (cards[i, j].Visible == false) count++;
                }
            }
            if(count >= cards.Length/2)
            {
                if(p1_score > p2_score)
                {
                    MessageBox.Show("遊戲結束 P1獲勝!!", "", MessageBoxButtons.OK);
                    System.Environment.Exit(0);
                }
                else if(p1_score < p2_score)
                {
                    MessageBox.Show("遊戲結束 P2獲勝!!", "", MessageBoxButtons.OK);
                    System.Environment.Exit(0);
                }
                else
                {
                    MessageBox.Show("遊戲結束 雙方平手!!", "", MessageBoxButtons.OK);
                    System.Environment.Exit(0);
                }
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            round_label.Visible = true;
            player_label.Visible = true;
            P1score_label.Visible = true;
            P2score_label.Visible = true;
            start_button.Visible = false;

            //
            setTimer();
            string filename = @"card.map";
            StreamReader reader = new StreamReader(filename);
            int size_x; int size_y;

            string data = reader.ReadLine();
            string[] input = data.Split(' ');
            size_x = int.Parse(input[0]);
            size_y = int.Parse(input[1]);
            cards = new Card[size_x, size_y];
            int[,] numbers = new int[size_x, size_y];

            for (int i = 0; i < cards.GetLength(0); i++)
            {
                data = reader.ReadLine();
                string[] input_numbers = data.Split(' ');
                for (int j = 0; j < input_numbers.Length; j++)
                {
                    numbers[i, j] = int.Parse(input_numbers[j]);
                }
            }

            for (int i = 0; i < cards.GetLength(0); i++)
            {
                for (int j = 0; j < cards.GetLength(1); j++)
                {
                    cards[i, j] = new Card(numbers[i, j]);
                    cards[i, j].Size = new Size(400 / size_y, 400 / size_x);
                    cards[i, j].Location = new Point(150 + (400 / size_y) * j, 50 + (400 / size_x) * i);
                    cards[i, j].Click += card_click;
                    Controls.Add(cards[i, j]);
                }
            }
            cantDraw();
        }
    }
}
