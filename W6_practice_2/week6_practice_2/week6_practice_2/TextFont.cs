using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    class TextFont
    {
        public void changeSize(Label labeltext,int size)
        {
            if (size == 0) return;
            labeltext.Font = new System.Drawing.Font(labeltext.Font.FontFamily, size, labeltext.Font.Style);
        }
        public void changeFont(Label labeltext, String font)
        {
            labeltext.Font = new System.Drawing.Font(font, labeltext.Font.Size, labeltext.Font.Style);
        }

        public void changeStyle(Label labeltext, bool bold, bool italic)
        {
            if (bold == true && italic == true)
            {
                labeltext.Font = new System.Drawing.Font(labeltext.Font.FontFamily, labeltext.Font.Size, FontStyle.Bold | FontStyle.Italic);
            } else if(bold == true && italic == false)
            {
                labeltext.Font = new System.Drawing.Font(labeltext.Font.FontFamily, labeltext.Font.Size, FontStyle.Bold);
            } else if(bold == false && italic == true)
            {
                labeltext.Font = new System.Drawing.Font(labeltext.Font.FontFamily, labeltext.Font.Size, FontStyle.Italic);
            } else
            {
                labeltext.Font = new System.Drawing.Font(labeltext.Font.FontFamily, labeltext.Font.Size, FontStyle.Regular);
            }
        }
        public void changeStyleBold(Label labeltext)
        {
            if(labeltext.Font.Style != FontStyle.Bold)
            {
                //labeltext.Font.Style = FontStyle.Bold;
                labeltext.Font = new System.Drawing.Font(labeltext.Font.FontFamily, labeltext.Font.Size, FontStyle.Bold | FontStyle.Italic);
            } else
            {
                labeltext.Font = new System.Drawing.Font(labeltext.Font.FontFamily, labeltext.Font.Size, FontStyle.Regular);
            }
        }
        
        public void changeStyleItalic(Label labeltext)
        {
            if(labeltext.Font.Style != FontStyle.Underline)
            {
                labeltext.Font = new System.Drawing.Font(labeltext.Font.FontFamily, labeltext.Font.Size, FontStyle.Underline);
            } else
            {
                labeltext.Font = new System.Drawing.Font(labeltext.Font.FontFamily, labeltext.Font.Size, FontStyle.Regular);
            }
        }

        public void upLeft(Label labeltext)
        {
            labeltext.Location = new Point(22, 30);
        }
        public void upCenter(Label labeltext)
        {
            labeltext.Location = new Point(211, 30);
        }
        public void upRight(Label labeltext)
        {
            labeltext.Location = new Point(400, 30);
        }
        public void downLeft(Label labeltext)
        {
            labeltext.Location = new Point(22, 415);
        }
        public void downCenter(Label labeltext)
        {
            labeltext.Location = new Point(211, 415);
        }
        public void downRight(Label labeltext)
        {
            labeltext.Location = new Point(400, 415);
        }

    }
}
