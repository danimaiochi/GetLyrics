using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GetLyrics
{
    public partial class Main : Form
    {
        Song song = new Song();
        public Main()
        {
            InitializeComponent();
            song = Functions.getCurrentSong();
            setSong();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            List<Sources.Sites> sources = new List<Sources.Sites>();

            sources.Add(Sources.Sites.Vagalume);
            sources.Add(Sources.Sites.AZLyrics);

            song.Artist = txtArtist.Text ;
            song.Name = txtSong.Text;

            foreach (Sources.Sites src in sources)
            {
                showLyrics(Sources.GetFrom(src, song));
            }
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            song = Functions.getCurrentSong();
            setSong();
        }
        private void setSong()
        {
            txtArtist.Text = song.Artist;
            txtSong.Text = song.Name;
        }
        private void showLyrics(Source src)
        {
            if (!string.IsNullOrEmpty(src.Lyrics))
            {
                LyricsForm lyricsForm = new LyricsForm();
                lyricsForm.song = song;
                lyricsForm.source = src;
                lyricsForm.init();
            }
        }
    }
    public class Song
    {
        public string Name { get; set; }
        public string Artist { get; set; }
    }
    
}
