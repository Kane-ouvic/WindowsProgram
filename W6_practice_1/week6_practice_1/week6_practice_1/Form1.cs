using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week6_practice_2
{
    public partial class Form1 : Form
    {
        PictureBox[,] pb1_print;
        PictureBox[,] pb2_print;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch(whisValid(width_text.Text, height_text.Text))
                {
                case 1:
                    MessageBox.Show("請輸入範圍內的數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox3.Enabled = false;
                    return;
                case 2:
                    MessageBox.Show("高不能為偶數", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox3.Enabled = false;
                    return;
                case 3:
                    MessageBox.Show("請輸入數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox3.Enabled = false;
                    return;
                default:
                    break;

            }
            textBox3.Enabled = true;
            pb1_print = new PictureBox[10,15];
            pb2_print = new PictureBox[10,15];
            for (int i = this.Controls.Count- 1; i >= 0; i--)
            {
                if (this.Controls[i] is PictureBox) this.Controls[i].Dispose();
            }

            //int Num = 0;
            int width = 263 / int.Parse(width_text.Text);
            int height = 360 /int.Parse(height_text.Text);
            PictureBox[,] pb1;
            PictureBox[,] pb2;
            //Num = 100;
            pb1 = new PictureBox[width, height];
            pb2 = new PictureBox[width, height];

            for(int j = 0; j < int.Parse(height_text.Text); j++)
            {
                for(int i = 0; i < int.Parse(width_text.Text); i++)
                {
                    pb1[i, j] = new System.Windows.Forms.PictureBox();
                    pb2[i, j] = new System.Windows.Forms.PictureBox();
                    pb1[i, j].BackColor = System.Drawing.Color.White;
                    pb2[i, j].BackColor = System.Drawing.Color.White;
                    pb1[i, j].BorderStyle = BorderStyle.FixedSingle;
                    pb2[i, j].BorderStyle = BorderStyle.FixedSingle;
                    pb1[i, j].Location = new Point(150 + i * width, 10 + j * height);
                    pb2[i, j].Location = new Point(150 + 283 + i * width, 10 + j * height);
                    pb1[i, j].Size = new Size(width, height);
                    pb2[i, j].Size = new Size(width, height);
                    Controls.Add(pb1[i, j]);
                    Controls.Add(pb2[i, j]);
                    pb1_print[i, j] = pb1[i, j];
                    pb2_print[i, j] = pb2[i, j];
                }
            }

            if (isValid(textBox3.Text))
            {
                printNumber(int.Parse(textBox3.Text));
            } else
            {
                for (int j = 0; j < int.Parse(height_text.Text); j++)
                {
                    for (int i = 0; i < int.Parse(width_text.Text); i++)
                    {
                        pb1_print[i, j].BackColor = System.Drawing.Color.White;
                        pb2_print[i, j].BackColor = System.Drawing.Color.White;
                    }
                }
            }

            //printNumber(int.Parse(textBox3.Text));
            //test[0,0] = pb1[0, 0];

            /*for(int i = 0; i < height; i++)
            {
                pb[i] = new System.Windows.Forms.PictureBox();

                pb[i].BackColor = System.Drawing.Color.AliceBlue;
                pb[i].BorderStyle = BorderStyle.FixedSingle;
                pb[i].Location = new Point(150 , 10 + i*height);
                pb[i].Size = new Size(width, height);
                //pb[i].SizeMode = PictureBoxSizeMode.Zoom;
                //pb[i].Visible = true;
                Controls.Add(pb[i]);

            }*/
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int height = int.Parse(height_text.Text);
            int width = int.Parse(width_text.Text);
            //height_label.Text = textBox3.Text;
            for (int j = 0; j < height; j++)
            {
                for(int i = 0; i < width; i++)
                {
                    pb1_print[i, j].BackColor = System.Drawing.Color.White;
                    pb2_print[i, j].BackColor = System.Drawing.Color.White;
                }
            }
            if(isValid(textBox3.Text)) printNumber(int.Parse(textBox3.Text));
            
        }

        private int whisValid(String width, String height)
        {
            try
            {
                if(int.Parse(height) > 15 || int.Parse(height) < 7 || int.Parse(width) > 10 || int.Parse(width) < 5)
                {
                    return 1;
                } else if(int.Parse(height)%2 == 0)
                {
                    return 2;
                }

            }catch (FormatException e)
            {
                return 3;
            }
            return 0;
        }
        private bool isValid(String input)
        {
            try
            {
                if (int.Parse(input) <= 99 && int.Parse(input) >= -9)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } catch (FormatException e)
            {
                return false;
            }
           
        }

        private void printNumber(int number)
        {
            int height = int.Parse(height_text.Text);
            int width = int.Parse(width_text.Text);
            if(number >= 0)
            {
                int a = number / 10;
                int b = number % 10;

                switch (a)
                {
                    case 1:
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb1_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb1_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 2:
                        for(int i = 1; i < width-1; i++)
                        {
                            pb1_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb1_print[i, (height-1)/2].BackColor = System.Drawing.Color.Blue;
                            pb1_print[i, height-1].BackColor = System.Drawing.Color.Blue;
                        }
                        for(int i = 1; i < (height-1)/2; i++)
                        {
                            pb1_print[width-1, i].BackColor = System.Drawing.Color.Blue;
                            pb1_print[0, i+ (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 3:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb1_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb1_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb1_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb1_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb1_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 4:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb1_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb1_print[0, i].BackColor = System.Drawing.Color.Blue;
                            pb1_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb1_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 5:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb1_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb1_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb1_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb1_print[0, i].BackColor = System.Drawing.Color.Blue;
                            pb1_print[width-1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 6:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb1_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb1_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb1_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb1_print[0, i].BackColor = System.Drawing.Color.Blue;
                            pb1_print[0, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb1_print[width-1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 7:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb1_print[i, 0].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb1_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb1_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 8:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb1_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb1_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb1_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb1_print[0, i].BackColor = System.Drawing.Color.Blue;
                            pb1_print[0, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb1_print[width - 1, i ].BackColor = System.Drawing.Color.Blue;
                            pb1_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 9:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb1_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb1_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb1_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb1_print[0, i].BackColor = System.Drawing.Color.Blue;
                            pb1_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb1_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 0:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb1_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb1_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb1_print[0, i].BackColor = System.Drawing.Color.Blue;
                            pb1_print[0, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb1_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb1_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                }

                switch (b)
                {
                    case 1:
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 2:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb2_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[0, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 3:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb2_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 4:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb2_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[0, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 5:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb2_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[0, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 6:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb2_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[0, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[0, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 7:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb2_print[i, 0].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 8:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb2_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[0, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[0, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 9:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb2_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[0, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 0:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb2_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[0, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[0, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                }

            } else
            {
                int b = -number;
                for (int i = 1; i < width - 1; i++)
                {
                    pb1_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                }
                switch (b)
                {
                    case 1:
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 2:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb2_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[0, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 3:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb2_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 4:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb2_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[0, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 5:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb2_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[0, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 6:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb2_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[0, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[0, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 7:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb2_print[i, 0].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 8:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb2_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[0, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[0, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 9:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb2_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[0, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                    case 0:
                        for (int i = 1; i < width - 1; i++)
                        {
                            pb2_print[i, 0].BackColor = System.Drawing.Color.Blue;
                            pb2_print[i, height - 1].BackColor = System.Drawing.Color.Blue;
                        }
                        for (int i = 1; i < (height - 1) / 2; i++)
                        {
                            pb2_print[0, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[0, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i].BackColor = System.Drawing.Color.Blue;
                            pb2_print[width - 1, i + (height - 1) / 2].BackColor = System.Drawing.Color.Blue;
                        }
                        break;
                }
            }

        }
        

      
    }
}
