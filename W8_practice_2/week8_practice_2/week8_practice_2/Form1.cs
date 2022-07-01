using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week8_practice_2
{
    public partial class Form1 : Form
    {
        Button[,] blocks = new Button[19, 19];
        Character player1;
        Character player2;
        bool P1_turn = true;

        bool player1_choose = false;
        bool player2_choose = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private Button findNextButton1(Button button)
        {
            for(int i = 0; i < 19; i++)
            {
                for(int j = 0; j < 19; j++)
                {
                    if(blocks[i,j] == button && j < 18)
                    {
                        return blocks[i, j+1];
                    }
                }
            }
            return null;
        }

        private Button findNextButton2(Button button)
        {
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (blocks[i, j] == button && i < 18)
                    {
                        return blocks[i+1, j];
                    }
                }
            }
            return null;
        }

        private void dealWithButton()
        {
            start_btn.Visible = false;

            P1_warrior.Visible = false;
            P1_witcher.Visible = false;
            P1_Archer.Visible = false;
            P2_warrior.Visible = false;
            P2_witcher.Visible = false;
            P2_Archer.Visible = false;

            P1_chess_A.Visible = true;
            P1_chess_B.Visible = true;
            P1_chess_C.Visible = true;
            P1_chess_D.Visible = true;

            P2_chess_A.Visible = true;
            P2_chess_B.Visible = true;
            P2_chess_C.Visible = true;
            P2_chess_D.Visible = true;


        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (player1_choose == true && player2_choose == true)
            {
                dealWithButton();
                for (int i = 0; i < 19; i++)
                {
                    for (int j = 0; j < 19; j++)
                    {
                        blocks[i, j] = new Button();
                        blocks[i, j].Size = new Size(21, 21);
                        blocks[i, j].BackColor = Color.Gray;
                        blocks[i, j].Location = new Point(180 + 21 * j, 50 + 21 * i);
                        blocks[i, j].Click += click_chess;

                        Controls.Add(blocks[i, j]);
                    }
                }
                start_btn.Visible = false;
                P1_warrior.Visible = false;
                P1_witcher.Visible = false;
                P1_Archer.Visible = false;
                P2_warrior.Visible = false;
                P2_witcher.Visible = false;
                P2_Archer.Visible = false;

                Player1_label.Text = "P1: " + player1.name;
                Player2_label.Text = "P2: " + player2.name;

                printChessAmount();

                lockPlayer2();
                openPlayer1();

            }
        }

        private void click_chess(object sender, EventArgs e)
        {
            Button chess = sender as Button;
            bool success = false;
           

            //player1.placeChessA(chess);
            if(P1_turn == true)
            {

                if(player1.placeA == true)
                {
                    success = player1.placeChessA(chess);
                }
                else if(player1.placeB == true)
                {
                    Button chess2 = findNextButton1(chess);
                    success = player1.placeChessB(chess, chess2);
                }
                else if(player1.placeC == true)
                {
                    Button chess2 = findNextButton2(chess);
                    success = player1.placeChessC(chess, chess2);
                }
                else if(player1.placeD == true)
                {
                    success = player1.placeChessD(chess);
                }

                
                if (success == true)
                {
                    checkPlate(chess);
                    lockPlayer1();
                    openPlayer2();
                    P1_turn = false;
                    resetPlayer2Chess();
                    printChessAmount();
                }
                

            }
            else
            {

                if (player2.placeA == true)
                {
                    success = player2.placeChessA(chess);
                }
                else if (player2.placeB == true)
                {
                    Button chess2 = findNextButton1(chess);
                    success = player2.placeChessB(chess, chess2);
                }
                else if (player2.placeC == true)
                {
                    Button chess2 = findNextButton2(chess);
                    success = player2.placeChessC(chess, chess2);
                }
                else if (player2.placeD == true)
                {
                    success = player2.placeChessD(chess);
                }

                
                if (success == true)
                {
                    checkPlate(chess);
                    lockPlayer2();
                    openPlayer1();
                    P1_turn = true;
                    resetPlayer1Chess();
                    printChessAmount();
                }

            }
        }

        private void lockAllChess()
        {
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    blocks[i, j].Enabled = false;
                }
            }
        }
        private void openAllChess()
        {
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    blocks[i, j].Enabled = true;
                }
            }
        }

        private void P2_warrior_Click(object sender, EventArgs e)
        {
            player2 = new Warrior("P2");
            P2_warrior.Enabled = false;
            P2_witcher.Enabled = false;
            P2_Archer.Enabled = false;
            player2_choose = true;
        }

        private void P2_witcher_Click(object sender, EventArgs e)
        {
            player2 = new Witcher("P2");
            P2_warrior.Enabled = false;
            P2_witcher.Enabled = false;
            P2_Archer.Enabled = false;
            player2_choose = true;
        }

        private void P2_Archer_Click(object sender, EventArgs e)
        {
            player2 = new Archer("P2");
            P2_warrior.Enabled = false;
            P2_witcher.Enabled = false;
            P2_Archer.Enabled = false;
            player2_choose = true;
        }

        private void P1_warrior_Click(object sender, EventArgs e)
        {
            player1 = new Warrior("P1");
            P1_warrior.Enabled = false;
            P1_witcher.Enabled = false;
            P1_Archer.Enabled = false;
            player1_choose = true;
        }

        private void P1_witcher_Click(object sender, EventArgs e)
        {
            player1 = new Witcher("P1");
            P1_warrior.Enabled = false;
            P1_witcher.Enabled = false;
            P1_Archer.Enabled = false;
            player1_choose = true;
        }

        private void P1_Archer_Click(object sender, EventArgs e)
        {
            player1 = new Archer("P1");
            P1_warrior.Enabled = false;
            P1_witcher.Enabled = false;
            P1_Archer.Enabled = false;
            player1_choose = true;
        }

        private void printChessAmount()
        {
            P1_chess_B.Text = "橫向棋子:" + Convert.ToString(player1.numB) + "顆";
            P1_chess_C.Text = "縱向棋子:" + Convert.ToString(player1.numC) + "顆";
            P1_chess_D.Text = "覆蓋棋子:" + Convert.ToString(player1.numD) + "顆";

            P2_chess_B.Text = "橫向棋子:" + Convert.ToString(player2.numB) + "顆";
            P2_chess_C.Text = "縱向棋子:" + Convert.ToString(player2.numC) + "顆";
            P2_chess_D.Text = "覆蓋棋子:" + Convert.ToString(player2.numD) + "顆";
        }

        private void P2_chess_A_Click(object sender, EventArgs e)
        {
            player2.placeA = true;
            player2.placeB = false;
            player2.placeC = false;
            player2.placeD = false;
        }

        private void P2_chess_B_Click(object sender, EventArgs e)
        {
            player2.placeA = false;
            player2.placeB = true;
            player2.placeC = false;
            player2.placeD = false;
        }

        private void P2_chess_C_Click(object sender, EventArgs e)
        {
            player2.placeA = false;
            player2.placeB = false;
            player2.placeC = true;
            player2.placeD = false;
        }

        private void P2_chess_D_Click(object sender, EventArgs e)
        {
            player2.placeA = false;
            player2.placeB = false;
            player2.placeC = false;
            player2.placeD = true;
        }

        private void P1_chess_A_Click(object sender, EventArgs e)
        {
            player1.placeA = true;
            player1.placeB = false;
            player1.placeC = false;
            player1.placeD = false;
        }

        private void P1_chess_B_Click(object sender, EventArgs e)
        {
            player1.placeA = false;
            player1.placeB = true;
            player1.placeC = false;
            player1.placeD = false;
        }

        private void P1_chess_C_Click(object sender, EventArgs e)
        {
            player1.placeA = false;
            player1.placeB = false;
            player1.placeC = true;
            player1.placeD = false;
        }

        private void P1_chess_D_Click(object sender, EventArgs e)
        {
            player1.placeA = false;
            player1.placeB = false;
            player1.placeC = false;
            player1.placeD = true;
        }

        private void lockPlayer1()
        {
            P1_chess_A.Enabled = false;
            P1_chess_B.Enabled = false;
            P1_chess_C.Enabled = false;
            P1_chess_D.Enabled = false;
            checkPlayer1Chess();
        }

        private void openPlayer1()
        {
            P1_chess_A.Enabled = true;
            P1_chess_B.Enabled = true;
            P1_chess_C.Enabled = true;
            P1_chess_D.Enabled = true;
            checkPlayer1Chess();
        }
        private void lockPlayer2()
        {
            P2_chess_A.Enabled = false;
            P2_chess_B.Enabled = false;
            P2_chess_C.Enabled = false;
            P2_chess_D.Enabled = false;
            checkPlayer2Chess();
        }

        private void openPlayer2()
        {
            P2_chess_A.Enabled = true;
            P2_chess_B.Enabled = true;
            P2_chess_C.Enabled = true;
            P2_chess_D.Enabled = true;
            checkPlayer2Chess();
        }

        private void checkPlayer1Chess()
        {
            if (player1.numB <= 0) P1_chess_B.Enabled = false;
            if (player1.numC <= 0) P1_chess_C.Enabled = false;
            if (player1.numD <= 0) P1_chess_D.Enabled = false;
        }

        private void checkPlayer2Chess()
        {
            if (player2.numB <= 0) P2_chess_B.Enabled = false;
            if (player2.numC <= 0) P2_chess_C.Enabled = false;
            if (player2.numD <= 0) P2_chess_D.Enabled = false;
        }

        private void resetPlayer1Chess()
        {
            player1.placeA = true;
            player1.placeB = false;
            player1.placeC = false;
            player1.placeD = false;
        }
        private void resetPlayer2Chess()
        {
            player2.placeA = true;
            player2.placeB = false;
            player2.placeC = false;
            player2.placeD = false;
        }

        private void checkPlate(Button chess)
        {
            if (chess.BackColor == Color.Gray) return;
            int row = 0;
            int column = 0;
            int count = 0;
            bool win = false;
            Button preChess = chess;
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (blocks[i, j] == chess)
                    {
                        row = i;
                        column = j;
                    }
                }
            }

            for(int k = -4; k <= 4; k++) //檢查橫排
            {
                if (column + k < 0 || column + k >= 19) break;
                if (blocks[row, column + k].BackColor == chess.BackColor)
                {
                    count++;
                }
                else
                {
                    if (count > 0) count--;
                }
                if(count == 5)
                {
                    win = true;
                    break;
                }



            }

            count = 0;
            for (int k = -4; k <= 4; k++) //檢查直排
            {
                if (row + k < 0 || row + k >= 19) break;
                if (blocks[row + k, column].BackColor == chess.BackColor)
                {
                    count++;
                }
                else
                {
                    if (count > 0) count--;
                }
                if(count == 5)
                {
                    win = true;
                    break;
                }

            }

            count = 0;
            for (int k = -4; k <= 4; k++) //檢查左斜
            {
                if (row + k < 0 || row + k >= 19 || column + k < 0 || column + k >= 19) break;
                if (blocks[row + k, column + k].BackColor == chess.BackColor)
                {
                    count++;
                } else
                {
                    if (count > 0) count--;
                }
                if (count == 5)
                {
                    win = true;
                    break;
                }

            }
            count = 0;
            for (int k = -4; k <= 4; k++) //檢查右斜
            {
                if (row - k < 0 || row - k >= 19 || column + k < 0 || column + k >= 19) break;
                if (blocks[row - k, column + k].BackColor == chess.BackColor)
                {
                    count++;
                }
                else
                {
                    if(count > 0) count--;
                }
                if (count == 5)
                {
                    win = true;
                    break;
                }

            }

            if(win == true)
            {
                if(chess.BackColor == Color.DeepSkyBlue || chess.BackColor == Color.DarkBlue || chess.BackColor == Color.BlueViolet)
                {
                    MessageBox.Show("遊戲結束 P1獲勝!!", "", MessageBoxButtons.OK);
                    System.Environment.Exit(0);
                } else if (chess.BackColor == Color.Orange || chess.BackColor == Color.DarkOrange || chess.BackColor == Color.OrangeRed)
                {
                    MessageBox.Show("遊戲結束 P2獲勝!!", "", MessageBoxButtons.OK);
                    System.Environment.Exit(0);
                }
            }
        }
    }
}
