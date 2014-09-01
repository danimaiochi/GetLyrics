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
            refreshSong();
        }

        private void getLyrics()
        {
            List<Sources.Sites> sources = new List<Sources.Sites>();
            bool lyricFound = false;

            sources.Add(Sources.Sites.Vagalume);
            sources.Add(Sources.Sites.AZLyrics);

            song.Artist = txtArtist.Text;
            song.Name = txtSong.Text;

            foreach (Sources.Sites src in sources)
            {
                lyricFound = showLyrics(Sources.GetFrom(src, song));

                if (lyricFound)
                    break;
            }
            if (!lyricFound)
                MessageBox.Show("No lyric found.");
            
        }

        private void refreshSong()
        {
            song = Functions.getCurrentSong();
            setSong();
            getLyrics();
        }
        private void setSong()
        {
            if (txtArtist.Text != string.Empty && txtSong.Text != string.Empty && (txtArtist.Text != song.Artist || txtSong.Text != song.Name))
            {
                if (MessageBox.Show("Refresh current song?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    txtArtist.Text = song.Artist;
                    txtSong.Text = song.Name;
                }
            }
            else
            {
                txtArtist.Text = song.Artist;
                txtSong.Text = song.Name;
            }
        }
        private bool showLyrics(Source src)
        {
            if (!string.IsNullOrEmpty(src.Lyrics))
            {
                
                this.lyricsForm.song = song;
                this.lyricsForm.source = src;
                this.lyricsForm.init();
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshSong();
        }
    }
    public class Song
    {
        public string Name { get; set; }
        public string Artist { get; set; }
    }
    
}
