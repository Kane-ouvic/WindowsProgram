using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week9_practice_1
{
    public partial class Form2 : Form
    {
        Label[,] spectrums = new Label[4, 10];
        public Form2()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for(int j = 0; j < 10; j++)
            {
                for(int i = 0; i < 4; i++)
                {
                    spectrums[i, j] = new Label();
                    spectrums[i, j].Text = Convert.ToString(i) + "," +  Convert.ToString(j);
                    spectrums[i, j].BackColor = Color.Transparent;
                    spectrums[i, j].Size = new Size(80, 20);
                    spectrums[i, j].Location = new Point(120 + 100 * i, 40 + 40 * j);
                    Controls.Add(spectrums[i, j]);
                }
            }
            setTimer();
        }

        private void setTimer()
        {
            timer1.Interval = 500;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            reset();
            randGenerate();
            
        }
        private void randGenerate()
        {
            Random rand = new Random();

            int max = rand.Next(0, trackBar1.Value);
            for(int i = 9; i >= 10 - max; i--)
            {
                spectrums[0, i].BackColor = Color.Blue;
            }
            max = rand.Next(0, trackBar1.Value + 1);
            for (int i = 9; i >= 10 - max; i--)
            {
                spectrums[1, i].BackColor = Color.Blue;
            }
            max = rand.Next(0, trackBar1.Value + 1);
            for (int i = 9; i >= 10 - max; i--)
            {
                spectrums[2, i].BackColor = Color.Blue;
            }
            max = rand.Next(0, trackBar1.Value + 1);
            for (int i = 9; i >= 10 - max; i--)
            {
                spectrums[3, i].BackColor = Color.Blue;
            }

        }

        private void reset()
        {
            for(int j = 0; j <  10; j++)
            {
                for(int i = 0; i < 4; i++)
                {
                    spectrums[i, j].BackColor = Color.Transparent;
                }
            }
        }
    }
}
