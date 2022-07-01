using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace week9_practice_1
{
    class MusicPlayer : SoundPlayer
    {
        public bool Loop = false;
        public string[] Playlist;
        //public string now_path;


        public string[] SelectWavFiles()
        {
            OpenFileDialog select = new OpenFileDialog();
            String stFilter = "WAV(*.wav)|*.wav";
            select.Multiselect = true;
            select.Filter = stFilter;

            if(select.ShowDialog() == DialogResult.OK)
            {
                Playlist = select.FileNames;
            }


            return Playlist;
        }
        public void Play1()
        {
            if(Loop == true)
            {

                try
                {
                    this.Load();
                    //this.Play();
                    this.PlayLooping();
                }
                catch (System.NullReferenceException e)
                {

                }
                
            } else
            {
                try
                {
                    this.Load();
                    this.Play();
                }
                catch(System.NullReferenceException e)
                {

                }
                
       
            }
        }
        public void SetMusicLocation(string path)
        {
            this.SoundLocation = path;
        }
        /*public void SavePlaylist()
        {
            this.Stop();
        }

        public string[] LoadPlaylist()
        {

        }*/
    
    }
}
