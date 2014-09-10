using System;
using System.Collections.Generic;
using System.Windows.Forms;
using iTunesLib;
using System.Threading;
using System.Runtime.InteropServices;

namespace GetLyrics
{
    public partial class Main : Form
    {
        Song song = new Song();
        public static iTunesApp itunes = new iTunesApp();

        public Main()
        {
            InitializeComponent();
            refreshSong();
            itunes.OnPlayerPlayEvent += new _IiTunesEvents_OnPlayerPlayEventEventHandler(track_changed);
        }
        public void track_changed(object iTrack)
        {
            refreshSong();
        }

        private void getLyrics()
        {
            if (txtArtist.Text != string.Empty && txtSong.Text != string.Empty)
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
                    showLyrics(new Source() { Lyrics = "Not found!", Name = string.Empty, URL = string.Empty });
            }
        }

        public void refreshSong()
        {
            if (getItunesSong.Checked)
                setSong(Functions.getCurrentSong());
            getLyrics();
        }
        delegate void SetSongCallback(Song song);
        private void setSong(Song song)
        {
            if (this.txtArtist.InvokeRequired)
            {
                SetSongCallback d = new SetSongCallback(setSong);
                this.Invoke(d, new object[] { song });
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

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            itunes.OnPlayerPlayEvent -= track_changed;
            Marshal.ReleaseComObject(itunes);
        }

        private void stayOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = stayOnTop.Checked;
        }

        private void getItunesSong_Click(object sender, EventArgs e)
        {
            if (getItunesSong.Checked)
                itunes.OnPlayerPlayEvent += track_changed;
            else
                itunes.OnPlayerPlayEvent -= track_changed;
        }
    }
    public class Song
    {
        public string Name { get; set; }
        public string Artist { get; set; }
    }
    
}
