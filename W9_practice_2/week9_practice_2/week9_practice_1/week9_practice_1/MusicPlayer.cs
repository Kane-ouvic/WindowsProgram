using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

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
        public void SavePlaylist()
        {
            SaveFileDialog select = new SaveFileDialog();
            select.Filter = "*所有檔案 (*.*)|*.*";
            select.FileName = "";
            //select.DefaultExt = "txt";
            select.AddExtension = true;

            if(select.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(select.FileName))
                {
                    for (int i = 0; i < Playlist.Length; i++)
                    {
                        sw.WriteLine(Playlist[i]);
                    }
                }
                    

            }
        }

        public string[] LoadPlaylist()
        {
            OpenFileDialog select = new OpenFileDialog();
            //String stFilter = "";
            List<string> load_files = new List<string>();

           // select.Filter = stFilter;

            if (select.ShowDialog() == DialogResult.OK)
            {
                string line = "";
                using (StreamReader sr = new StreamReader(select.FileName))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        load_files.Add(line);
                    }
                }
            }

            Playlist = load_files.ToArray();


            return Playlist;
        }
    
    }
}
