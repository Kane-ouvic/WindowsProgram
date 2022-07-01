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
        TextFont textFont = new TextFont();
        int current = 1;
        public Form1()
        {
            InitializeComponent();
            FigShow();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //current = 1;
            
        }

        public void FigShow()
        {
            pictureBox1.Image = Image.FromFile(@"..\..\picture\pic_0" + current + ".png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void up_left_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (up_left_radio.Checked) textFont.upLeft(title_label);
        }

        private void category1_CheckedChanged(object sender, EventArgs e)
        {
            if(category1.Checked == true)
            {
                textFont.changeFont(title_label, "標楷體");
            }
        }

        private void category2_CheckedChanged(object sender, EventArgs e)
        {
            if (category2.Checked == true)
            {
                textFont.changeFont(title_label, "新明細體");
            }
        }

        private void category3_CheckedChanged(object sender, EventArgs e)
        {
            if (category3.Checked == true)
            {
                textFont.changeFont(title_label, "微軟正黑體");
            }
        }

        private void bold_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            textFont.changeStyle(title_label, bold_checkbox.Checked, italic_checkbox.Checked);

        }

        private void italic_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            textFont.changeStyle(title_label, bold_checkbox.Checked, italic_checkbox.Checked);
        }

        private void up_center_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (up_center_radio.Checked) textFont.upCenter(title_label);
        }

        private void up_right_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (up_right_radio.Checked) textFont.upRight(title_label);
        }

        private void down_left_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (down_left_radio.Checked) textFont.downLeft(title_label);
        }

        private void down_center_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (down_center_radio.Checked) textFont.downCenter(title_label);
        }

        private void down_right_radio_CheckedChanged(object sender, EventArgs e)
        {
            if(down_right_radio.Checked) textFont.downRight(title_label);
        }

        private void fontsize_text_TextChanged(object sender, EventArgs e)
        {
            try
            {
               if(int.Parse(fontsize_text.Text) <= 32 && int.Parse(fontsize_text.Text) >= 1)
                {
                    textFont.changeSize(title_label, int.Parse(fontsize_text.Text));
                } else
                {
                    textFont.changeSize(title_label, 12);
                }
                 
                    //textFont.changeSize(title_label, 12);
            } catch (FormatException)
            
            {
                textFont.changeSize(title_label, 12);
                return;
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            title_label.Text = richTextBox1.Text;
        }

        private void pre_button_Click(object sender, EventArgs e)
        {
            if(current == 1)
            {
                current = 5;
            } else
            {
                current--;
            }
            FigShow();
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if(current == 5)
            {
                current = 1;
            } else
            {
                current++;
            }
            FigShow();
        }
    }
}
