using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week5_p1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            title.Text = "歷史紀錄";
            alphabet.Visible = false;
            code_text.Visible = false;
            button5.Visible = false;
            button6.Visible = false;

            input_label.Visible = false;
            input_text.Visible = false;
            output_label.Visible = false;
            output_text.Visible = false;
            history.Visible = true;
            check.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            title.Text = "替換表";

            alphabet.Visible = true;
            code_text.Visible = true;
            button5.Visible = true;
            button6.Visible = true;

            input_label.Visible = false;
            input_text.Visible = false;
            output_label.Visible = false;
            output_text.Visible = false;
            history.Visible = false;
            check.Visible = true;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            title.Text = "加密";
            alphabet.Visible = false;
            code_text.Visible = false;
            button5.Visible = false;
            button6.Visible = true;

            input_label.Visible = true;
            input_label.Text = "輸入字串";
            input_text.Text = "";
            input_text.Visible = true;
            output_label.Visible = true;
            output_label.Text = "加密結果";
            output_text.Text = "";
            output_text.Visible = true;
            history.Visible = false;
            check.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            title.Text = "解密";
            alphabet.Visible = false;
            code_text.Visible = false;
            button5.Visible = false;
            button6.Visible = true;

            input_label.Visible = true;
            input_label.Text = "輸入密文";
            input_text.Text = "";
            input_text.Visible = true;
            output_label.Visible = true;
            output_label.Text = "解密結果";
            output_text.Text = "";
            output_text.Visible = true;
            history.Visible = false;
            check.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Key transform = new Key();
            code_text.Text = transform.Alphabet(alphabet.Text);

            history.Items.Add("新的替換表");
            history.Items.Add(transform.Alphabet(alphabet.Text));
            history.Items.Add("");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(String.Equals(title.Text, "替換表"))
            {
                Key checking = new Key();
                if(checking.IsValid(alphabet.Text, code_text.Text))
                {
                    check.Text = "合法替換表";
                } else
                {
                    check.Text = "替換表不合法! 請重新輸入";
                }
            }

            if(String.Equals(title.Text, "加密"))
            {
                Key encode = new Key();
                if(encode.IsValid(alphabet.Text, code_text.Text))
                {
                    output_text.Text = encode.Encrypt(alphabet.Text, code_text.Text, input_text.Text);
                    history.Items.Add("加密");
                    history.Items.Add("明文: " + input_text.Text);
                    history.Items.Add("密文: " + encode.Encrypt(alphabet.Text, code_text.Text, input_text.Text));
                    history.Items.Add("");
                }
            }

            if (String.Equals(title.Text, "解密"))
            {
                Key encode = new Key();
                if (encode.IsValid(alphabet.Text, code_text.Text))
                {
                    output_text.Text = encode.Decrypt(alphabet.Text, code_text.Text, input_text.Text);
                    history.Items.Add("解密");
                    history.Items.Add("密文: " + input_text.Text);
                    history.Items.Add("明文: " + encode.Decrypt(alphabet.Text, code_text.Text, input_text.Text));
                    history.Items.Add("");
                }
            }

            if (String.Equals(title.Text, "歷史紀錄"))
            {
                //history.Items.Add("測試");
            }

            

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
