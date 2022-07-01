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

namespace week9_practice_1
{
    public partial class Form1 : Form
    {
        RadioButton[] files = new RadioButton[5];
        List<string> Mult_Path = new List<string>();

        string[] music_list;
        MusicPlayer player = new MusicPlayer();
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 5; i++)
            {
                files[i] = new RadioButton();
                files[i].Location = new Point(10, 20 + i * 50);
                files[i].Size = new Size(1000, 40);
                files[i].Visible = false;
                files[i].CheckedChanged += click;
                groupBox1.Controls.Add(files[i]);
            }


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            /*String stFilter = "WAV(*.wav)|*.wav";
            this.openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = stFilter;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                music_list = openFileDialog1.FileNames;
                foreach(string strFileName in openFileDialog1.FileNames)
                {
                    Mult_Path.Add(strFileName);
                }
            }*/
            player.SelectWavFiles();
            changeRadioStats();


        }

        private void changeRadioStats()
        {
            for (int i = 0; i < player.Playlist.Length; i++)
            {

                files[i].Text = player.Playlist[i];
                files[i].Visible = true;

                //Controls.Add(test[i]);
            }


            for (int i = 5; i > player.Playlist.Length - 1; i--)
            {
                try
                {
                    files[i].Visible = false;
                }
                catch (System.IndexOutOfRangeException)
                {

                }
                catch (System.NullReferenceException)
                {

                }

            }
        }

        private void click(object sender, EventArgs e)
        {
            RadioButton music = sender as RadioButton;
            player.Stop();
            if(music.Checked == true)
            {
                player.SetMusicLocation(music.Text);
                //player.Load();
                //player.Play1();
            }
        }



        private void stop_btn_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            player.Play1();
        }

        private void loop_check_CheckedChanged(object sender, EventArgs e)
        {
            if(loop_check.Checked == true)
            {
                player.Loop = true;
            }
            else
            {
                player.Loop = false;
            }
        }
    }
}
