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
        //List<string> Mult_Path = new List<string>();
        //string[] music_list;

        RadioButton[] files = new RadioButton[5];
        MusicPlayer player = new MusicPlayer();
        Form2 fr2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            
            for(int i = 0; i < 5; i++)
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
            this.Text = music.Text;
            fr2.Hide();
        }



        private void stop_btn_Click(object sender, EventArgs e)
        {
            player.Stop();
            fr2.Hide();
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (player.Playlist.Length == 0)
                {
                    MessageBox.Show("請先建立播放清單");
                }
                else
                {
                    player.Play1();
                    fr2.Show();
                }
            } catch (System.NullReferenceException)
            {
                MessageBox.Show("請先建立播放清單");
            }
            
            
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

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                changeColorAndFont(colorDialog1.Color, fontDialog1.Font);
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                changeColorAndFont(colorDialog1.Color, fontDialog1.Font);
            }
        }

        private void changeColorAndFont(Color color, Font font)
        {
            for(int i = 0; i < 5; i++)
            {
                try
                {
                    files[i].Font = font;
                }
                catch (System.NullReferenceException e)
                {
                }
                try
                {
                    files[i].ForeColor = color;
                }
                catch (System.NullReferenceException e)
                {
                }

            }
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFiles();
        }

        private void loadFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.LoadPlaylist();
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.S && e.Control == true)
            {
                saveFiles();
            }
            if (e.KeyCode == Keys.L && e.Control == true)
            {
                player.LoadPlaylist();
                changeRadioStats();
            }
        }

        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveFiles()
        {
            try
            {
                if (player.Playlist.Length == 0)
                {
                    MessageBox.Show("請先建立播放清單");
                }
                else
                {
                    player.SavePlaylist();
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("請先建立播放清單");
            }
        }
        private void loadFiles()
        {

        }
    }
}
