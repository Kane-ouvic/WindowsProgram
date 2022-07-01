using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week5_p2
{
    public partial class Form1 : Form
    {
        Chicken chicken;

        public Form1()
        {
            InitializeComponent();
        }

        private void satisfaction_title_Click(object sender, EventArgs e)
        {

        }

        private void feed_button_Click(object sender, EventArgs e)
        {
            if (chicken.canFeed())
            {
                chicken.Feed();
                history.Items.Add("餵食了" + chicken.name);
            } else
            {
                history.Items.Add("金錢不足無法餵食");
            }
            printStats();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            if (chicken.canPlay())
            {
                chicken.Play();
                history.Items.Add("與" + chicken.name + "玩耍");
            } else
            {
                history.Items.Add("金錢不足無法玩耍");
            }
            printStats();

        }

        private void clean_button_Click(object sender, EventArgs e)
        {
            if (chicken.canClean())
            {
                chicken.Clean();
                history.Items.Add("清理了" + chicken.name);
            } else
            {
                history.Items.Add("金錢不足無法打掃");
            }
            printStats();

        }

        private void doctor_button_Click(object sender, EventArgs e)
        {
            if (chicken.canGotoDoctor())
            {
                chicken.GoToDoctor();
                history.Items.Add("帶" + chicken.name + "去看醫生");
            } else
            {
                history.Items.Add("金錢不足無法看醫生");
            }
            printStats();

        }

        private void name_button_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(name_text.Text) || String.IsNullOrWhiteSpace(name_text.Text))
            {
                chicken = new Chicken("電子雞", 1, 70, 700, 70, 50, 100, false, false, false, false);
            } else
            {
                chicken = new Chicken(name_text.Text, 1, 70, 700, 70, 50, 100, false, false, false, false);
            }

            name_button.Enabled = false;
            name_text.Enabled = false;

            feed_button.Enabled = true;
            play_button.Enabled = true;
            clean_button.Enabled = true;
            doctor_button.Enabled = true;
            end_button.Enabled = true;

            history.Items.Add("你開始養了" + chicken.name);
            history.Items.Add("第" + chicken.age + "天");
            event_label.Text = chicken.name + "出生了";
            printStats();
            
        }

        private void end_button_Click(object sender, EventArgs e)
        {
            chicken.EndDay();
            events();
            printStats();


            history.Items.Add("");
            if(!chicken.isDead )history.Items.Add("第" + chicken.age + "天");

        }

        public void printStats()
        {
            money.Text = chicken.player_money.ToString() + " 元";
            health_label.Text = chicken.health.ToString() + "%";
            weight_label.Text = chicken.weight.ToString() + "g";
            satisfaction_label.Text = chicken.satisfaction.ToString() + "%";
            emotion_label.Text = chicken.emotion.ToString() + "%";

        }

        public void events()
        {
            event_label.Text = "";
            if (chicken.isDead)
            {
                history.Items.Add("死掉了，遊戲結束了");
                event_label.Text = chicken.name + "死掉了";
                feed_button.Enabled = false;
                play_button.Enabled = false;
                clean_button.Enabled = false;
                doctor_button.Enabled = false;
                end_button.Enabled = false;
                return;


            }
            if (chicken.isDirty)
            {
                history.Items.Add("牠大便了");
                event_label.Text += chicken.name + "大便了 ";

            }
            if (chicken.isLay)
            {
                int bonus = chicken.earn();
                history.Items.Add(chicken.name + "下蛋了，賣掉蛋後獲得 " + bonus.ToString() + " 塊錢");
            }
            if (chicken.isSick)
            {
                history.Items.Add(chicken.name + "生病了");
                event_label.Text += chicken.name + "生病了 ";
            }

            if(!chicken.isDead && !chicken.isSick && !chicken.isDirty && !chicken.isLay)
            {
                history.Items.Add("一天平安的過去了");
                event_label.Text = chicken.name + "今天很乖";
            }
            
        }
    }
}
