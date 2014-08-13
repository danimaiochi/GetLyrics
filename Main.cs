using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTunesLib;
using WMPLib;

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
                song.Lyrics = Sources.GetFrom(src, song);
                showLyrics(src);
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
        private void showLyrics(Sources.Sites src)
        {
            if (!string.IsNullOrEmpty(song.Lyrics))
            {
                song.Source = src.ToString(); 
                LyricsForm lyricsForm = new LyricsForm(song);
                lyricsForm.Show();
            }
        }
    }
    public class Song
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Lyrics { get; set; }
        public string Source { get; set; }
    }
    
}
